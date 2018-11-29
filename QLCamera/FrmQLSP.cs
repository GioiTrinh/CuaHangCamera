using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLCamera
{
    public partial class FrmQLSP : Form
    {
        BUS_SanPham bus;
        private FormMode formMode = FormMode.Them;

        SanPham sanPhamEdit = new SanPham();
        private List<SanPham> sanPhams = new List<SanPham>();
        public FrmQLSP()
        {
            bus = new BUS_SanPham();
            InitializeComponent();
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.LoadSanPham(this.txtTimKiem.Text);
        }

        private void FrmQLSP_Load(object sender, EventArgs e)
        {
            this.txtMaSanPham.Text = this.RenderMaSanPham();
            this.LoadSanPham();
        }
        
        private void LoadSanPham(string key = "")
        {
            key = key.Trim().ToLower();
            this.sanPhams = this.bus.GetSanPhams(key);
            this.dgvQLSP.DataSource = this.sanPhams;
        }
        

        private void Luu(FormMode mode, SanPham sp)
        {
            switch (mode)
            {
                case FormMode.Them:
                    if (this.bus.CheckTonTaiSanPhamByTen(txtTenSanPham.Text))
                    {
                        MessageBox.Show("Tên sản phẩm đã tồn tại.\n Vui lòng sử dụng tên khác", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (this.bus.ThemSanPham(sp))
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm thất bại.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadSanPham();
                    break;
                case FormMode.Sua: 
                    if(this.bus.CapNhatSanPham(sp))
                        MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cập nhật thất bại.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadSanPham();
                    break;
                default:
                    MessageBox.Show("Vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.formMode = FormMode.Them;
            this.txtMaSanPham.Text = this.RenderMaSanPham();
            this.ResetForm();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            this.sanPhamEdit = new SanPham()
            {
                Id = this.sanPhamEdit.Id,
                MaSp = this.txtMaSanPham.Text.Trim(),
                TenSp = this.txtTenSanPham.Text.Trim(),
                Gia = double.Parse(this.nmrGia.Value.ToString()),
                NamBaoHanh = (int)nmrNam.Value,
                ThangBaoHanh = (int)nmrThang.Value,
            };
            this.Luu(this.formMode, sanPhamEdit);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(this.sanPhamEdit != null)
            {
                if (this.bus.XoaSanPham(this.sanPhamEdit.Id))
                {
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadSanPham();
                    this.sanPhamEdit = new SanPham();
                    this.Binding();
                }
                else {
                    MessageBox.Show("Xóa thất bại.\n Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string RenderMaSanPham()
        {
            var stt = (GetMaxId() + 1);
            var curLength = Utilities.PREFIX_MASANPHAM.Length + stt.ToString().Length;
            string additionalZero = "";
            for (int i = 0; i < Utilities.MASP_LENGTH - curLength; i++)
            {
                additionalZero += "0";
            }
            return Utilities.PREFIX_MASANPHAM + additionalZero + stt.ToString();
        }

        private int GetMaxId()
        {
            if (sanPhams == null || !sanPhams.Any())
                return 0;
            else
            {
                var listIds = sanPhams.Select(x => x.Id).ToList();
                var maxId = listIds.Max();
                var maNv = sanPhams.Find(x => x.Id == maxId).MaSp;
                var d = maNv.Replace(Utilities.PREFIX_MASANPHAM, "");
                if (int.TryParse(d, out int m))
                {
                    return m;
                }
                return 0;
            }
        }
        private void nmrThang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvQLSP_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvQLSP.SelectedRows.Count == 1)
            {
                this.formMode = FormMode.Sua;
                var selected = dgvQLSP.SelectedRows[0];
                int.TryParse(selected.Cells[0].Value.ToString(), out int id);
                this.sanPhamEdit = this.bus.GetSanPham(id);
                this.Binding();
            }
        }

        private void Binding()
        {
            this.txtMaSanPham.Text = this.sanPhamEdit.MaSp;
            this.txtTenSanPham.Text = this.sanPhamEdit.TenSp;

            this.nmrNam.Value = this.sanPhamEdit.NamBaoHanh; 
            this.nmrThang.Value = this.sanPhamEdit.ThangBaoHanh; 
            this.nmrGia.Value = decimal.Parse(this.sanPhamEdit.Gia.ToString());
        }

        private void ResetForm()
        {
            txtTenSanPham.Text = "";
            nmrGia.Value = 0;
            nmrNam.Value = 0;
            nmrThang.Value = 0;
        }
    }
}
