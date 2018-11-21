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
    public partial class FrmBanHang : Form
    {
        BUS_KhachHang bus;
        BUS_SanPham sp;
        BUS_Kho kho;
        private List<SanPham> sanPhams = new List<SanPham>();
        private List<SanPham> sanPhamTemps = new List<SanPham>();
        private List<KhachHang> khachHangs = new List<KhachHang>();
        BindingList<ChiTietHoaDon> dataChiTietHoaDons = new BindingList<ChiTietHoaDon>();
        private List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
        public FrmBanHang()
        {
            bus = new BUS_KhachHang();
            sp = new BUS_SanPham();
            kho = new BUS_Kho();
            InitializeComponent();
        }

        private void FrmNhapHangTuNCC_Load(object sender, EventArgs e)
        {
            this.LoadSanPham();
            this.LoadKhachHang();
        }

        private void LoadSanPham()
        {
            this.cbSanPham.DataSource = this.sanPhamTemps = this.sanPhams = this.sp.GetSanPhams();

            this.cbSanPham.DisplayMember = "TenSp";
            this.cbSanPham.ValueMember = "Id";
            if(this.sanPhams?.Count > 0)
            {
                this.cbSanPham.SelectedIndex = 0;
            }
        }

        private void LoadKhachHang()
        {
            this.cbKhachHang.DataSource = this.khachHangs = this.bus.GetKhachHangs();
            this.cbKhachHang.DisplayMember = "HoTenKH";
            this.cbKhachHang.ValueMember = "Id";
            if(this.khachHangs?.Count > 0)
            {
                this.cbKhachHang.SelectedIndex = 0;
            }
        }

        private void Binding()
        {
            this.dgvSanPhamDat.ResetBindings();
            this.dgvSanPhamDat.DataSource = this.dataChiTietHoaDons;
            dgvSanPhamDat.Update();
            dgvSanPhamDat.Refresh();
        }

        int id = 0;
        private int currentSoLuongSanPham = 0;
        private int currentIdSanPham = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.nmrSoLuong.Value != 0)
            {
                if (this.nmrSoLuong.Value > currentSoLuongSanPham)
                {
                    MessageBox.Show("Không thể nhập quá số lượng yêu cầu.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (this.chiTietHoaDons.Where(x => x.SanPhamId == int.Parse(this.cbSanPham.SelectedValue.ToString())).Any())
                {
                    this.chiTietHoaDons.Where(x => x.SanPhamId == int.Parse(this.cbSanPham.SelectedValue.ToString())).First().SoLuong += int.Parse(this.nmrSoLuong.Value.ToString());

                    var item = this.chiTietHoaDons.Where(x => x.SanPhamId == int.Parse(this.cbSanPham.SelectedValue.ToString())).First();
                    var index = this.dataChiTietHoaDons.IndexOf(item);

                    this.dataChiTietHoaDons.RemoveAt(index);
                    this.dataChiTietHoaDons.Insert(index, item);
                }
                else
                {
                    var newItem = new ChiTietHoaDon()
                    {
                        Id = ++id,
                        SanPhamId = int.Parse(this.cbSanPham.SelectedValue.ToString()),
                        SoLuong = int.Parse(this.nmrSoLuong.Value.ToString()),
                        TenSanPham = this.sanPhams.Where(x => x.Id == int.Parse(this.cbSanPham.SelectedValue.ToString())).FirstOrDefault().TenSp
                    };
                    this.chiTietHoaDons.Add(newItem);
                    this.dataChiTietHoaDons.Insert(id - 1, newItem);
                }
                this.currentSoLuongSanPham = this.sanPhamTemps.Where(x => x.Id == this.currentIdSanPham).FirstOrDefault().HienCo -= (int)this.nmrSoLuong.Value;
                UpdateHienCo();
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
            if(this.chiTietHoaDons.Count > 0)
            {
                List<string> tenSanPhamCapNhatLois = new List<string>();
         
                if(this.bus.BanHang(Utilities.currentUserId, int.Parse(this.cbKhachHang.SelectedValue.ToString()) , this.chiTietHoaDons))
                {
                    chiTietHoaDons.ForEach(x =>
                    {
                        if(!sp.CapNhatSoLuong(x.SanPhamId, sp.KiemTraSoLuongHangHienCo(x.SanPhamId) - x.SoLuong))
                        {
                            MessageBox.Show("Lỗi trong quá trình cập nhật thêm số lượng sản phẩm.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tenSanPhamCapNhatLois.Add(x.TenSanPham);
                        }

                        if (!sp.ThemBaoHanh(new ThongTinBaoHanh()
                        {
                            NhanVienId = Utilities.currentUserId,
                            SanPhamId = x.SanPhamId,
                            HoaDonId = this.bus.GetLastHoaDonId(),
                            ThoiGian = DateTime.Now,
                            LanThu = 1
                        }))
                        {
                            MessageBox.Show("Lỗi trong quá trình cập nhật bảo hành.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    });

                    MessageBox.Show("Thêm hóa đơn thành công thành công.\n" + 
                        (tenSanPhamCapNhatLois.Count > 0 ? 
                        string.Join(", ", tenSanPhamCapNhatLois) + " cập nhật thất bại."
                        : ""),
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Ít nhất phải chọn 1 hàng hóa.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHienCo();
        }

        private void UpdateHienCo()
        {
            try
            {
                this.currentIdSanPham = this.sanPhamTemps[cbSanPham.SelectedIndex].Id;
                currentSoLuongSanPham = this.sanPhamTemps.Where(x => x.Id == this.currentIdSanPham).FirstOrDefault().HienCo;
                this.lblHienCo.Text = currentSoLuongSanPham.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void ClearForm()
        {
            this.LoadSanPham();
            this.LoadKhachHang();
            this.Binding();
        }
    }
}
