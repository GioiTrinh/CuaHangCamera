using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCamera
{
    public partial class FrmNhapHangTuNCC : Form
    {
        BUS_NhaCungCap bus;
        BUS_SanPham sp;
        BUS_Kho kho;
        private List<SanPham> sanPhams = new List<SanPham>();
        private List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
        private List<Kho> khos = new List<Kho>();
        BindingList<ChiTietHoaDonMua> dataChiTietHoaDonMuas = new BindingList<ChiTietHoaDonMua>();
        private List<ChiTietHoaDonMua> chiTietHoaDonMuas = new List<ChiTietHoaDonMua>();
        public FrmNhapHangTuNCC()
        {
            bus = new BUS_NhaCungCap();
            sp = new BUS_SanPham();
            kho = new BUS_Kho();
            InitializeComponent();
        }

        private void FrmNhapHangTuNCC_Load(object sender, EventArgs e)
        {
            this.LoadSanPham();
            this.LoadNhaCungCap();
            this.LoadKho();

            if(this.sanPhams?.Count == 0 || this.nhaCungCaps?.Count == 0 || this.khos?.Count == 0)
                MessageBox.Show(
                    (this.sanPhams?.Count == 0 ? "Sản phẩm" + 
                        (this.nhaCungCaps?.Count == 0 || this.khos?.Count == 0 ? ", " : "") 
                        : "") + 
                    (this.nhaCungCaps?.Count == 0 ? ("Nhà cung cấp" + 
                    (this.khos?.Count == 0 ? ", " : "")) : "" ) + 
                    (this.khos?.Count == 0 ? "Kho" : "" ) + 
                    " không tồn tại.\n Vui lòng thêm các thông tin và thử lại"
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void LoadSanPham()
        {
            this.cbSanPham.DataSource = this.sanPhams = this.sp.GetSanPhams();

            this.cbSanPham.DisplayMember = "TenSp";
            this.cbSanPham.ValueMember = "Id";
            if(this.sanPhams?.Count > 0)
            {
                this.cbSanPham.SelectedIndex = 0;
            }
        }
        private void LoadKho()
        {
            this.cbKho.DataSource = this.khos = this.kho.GetKhos();
            this.cbKho.DisplayMember = "TenKho";
            this.cbKho.ValueMember = "Id";
            if (this.khos?.Count > 0)
            {
                this.cbKho.SelectedIndex = 0;
            }
        }

        private void LoadNhaCungCap()
        {
            this.cbNhaCungCap.DataSource = this.nhaCungCaps = this.bus.GetNhaCungCaps();
            this.cbNhaCungCap.DisplayMember = "TenNCC";
            this.cbNhaCungCap.ValueMember = "Id";
            if(this.nhaCungCaps?.Count > 0)
            {
                this.cbNhaCungCap.SelectedIndex = 0;
            }
        }

        private void Binding()
        {
            this.dgvSanPhamDat.ResetBindings();
            this.dgvSanPhamDat.DataSource = this.dataChiTietHoaDonMuas;
            dgvSanPhamDat.Update();
            dgvSanPhamDat.Refresh();
        }

        int id = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.nmrSoLuong.Value != 0)
            {
                if (this.chiTietHoaDonMuas.Where(x => x.SanPhamId == int.Parse(this.cbSanPham.SelectedValue.ToString())).Any())
                {
                    this.chiTietHoaDonMuas.Where(x => x.SanPhamId == int.Parse(this.cbSanPham.SelectedValue.ToString())).First().SoLuong += int.Parse(this.nmrSoLuong.Value.ToString());

                    var item = this.chiTietHoaDonMuas.Where(x => x.SanPhamId == int.Parse(this.cbSanPham.SelectedValue.ToString())).First();
                    var index = this.dataChiTietHoaDonMuas.IndexOf(item);

                    this.dataChiTietHoaDonMuas.RemoveAt(index);
                    this.dataChiTietHoaDonMuas.Insert(index, item);
                }
                else
                {
                    var newItem = new ChiTietHoaDonMua()
                    {
                        Id = ++id,
                        SanPhamId = int.Parse(this.cbSanPham.SelectedValue.ToString()),
                        SoLuong = int.Parse(this.nmrSoLuong.Value.ToString()),
                        TenSanPham = this.sanPhams.Where(x => x.Id == int.Parse(this.cbSanPham.SelectedValue.ToString())).FirstOrDefault().TenSp
                    };
                    this.chiTietHoaDonMuas.Add(newItem);
                    this.dataChiTietHoaDonMuas.Insert(id - 1, newItem);
                }

                this.nmrSoLuong.Value = 0;
                this.Binding();
            }
            else
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(this.chiTietHoaDonMuas.Count > 0)
            {
                List<string> tenSanPhamCapNhatLois = new List<string>();
         
                if(this.bus.NhapHangTuNhaCungCap(Utilities.currentUserId, int.Parse(this.cbNhaCungCap.SelectedValue.ToString()) , this.chiTietHoaDonMuas))
                {
                    chiTietHoaDonMuas.ForEach(x =>
                    {
                        if(!sp.CapNhatSoLuong(x.SanPhamId, sp.KiemTraSoLuongHangHienCo(x.SanPhamId) + x.SoLuong))
                        {
                            MessageBox.Show("Lỗi trong quá trình cập nhật thêm số lượng sản phẩm.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tenSanPhamCapNhatLois.Add(x.TenSanPham);
                        }
                    });

                    MessageBox.Show("Nhập hàng từ nhà cung cấp vào kho thành công.\n" + 
                        (tenSanPhamCapNhatLois.Count > 0 ? 
                        string.Join(", ", tenSanPhamCapNhatLois) + " cập nhật thất bại."
                        : ""),
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ít nhất phải chọn 1 hàng hóa.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
