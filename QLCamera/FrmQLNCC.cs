using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCamera
{
    public partial class FrmQLNCC : Form
    {
        private readonly BUS_NhaCungCap bus;
        private List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
        private List<NhaCungCap> allNhaCungCaps = new List<NhaCungCap>();
        private FormMode formMode = FormMode.Them;
        private int currentId = -1;
        public FrmQLNCC()
        {
            bus = new BUS_NhaCungCap();
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(this.formMode == FormMode.Them)
            {
                var ncc = new NhaCungCap
                {
                    MaNCC = txtMa.Text.Trim(),
                    TenNCC = txtTenNhaCungCap.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Sdt = txtSoDienThoai.Text.Trim(),
                    Website = txtWebsite.Text.Trim()
                };

                this.ThemNhaCungCap(ncc);
            }
            else
            {
                var ncc = this.bus.GetNhaCungCap(this.currentId);

                ncc.MaNCC = txtMa.Text.Trim();
                ncc.TenNCC = txtTenNhaCungCap.Text.Trim();
                ncc.DiaChi = txtDiaChi.Text.Trim();
                ncc.Email = txtEmail.Text.Trim();
                ncc.Sdt = txtSoDienThoai.Text.Trim();
                ncc.Website = txtWebsite.Text.Trim();

                this.CapNhatNhaCungCap(ncc);
            }
        }

        private void FrmQLNCC_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            allNhaCungCaps = nhaCungCaps = bus.GetNhaCungCaps();
            dgvQLNCC.DataSource = nhaCungCaps;
            txtMa.Text = this.RenderMaNhaCungCap();
        }

        private void TimKiem(string key)
        {
            key = key.ToLower();
            nhaCungCaps = allNhaCungCaps;
            nhaCungCaps = nhaCungCaps.Where(x => x.TenNCC.ToLower().Contains(key) ||
                                                 x.MaNCC.ToLower().Contains(key) ||
                                                 x.DiaChi.ToLower().Contains(key) ||
                                                 x.Email.ToLower().Contains(key) ||
                                                 x.Sdt.ToLower().Contains(key) ||
                                                 x.Website.ToLower().Contains(key)
                          ).ToList();
            dgvQLNCC.DataSource = nhaCungCaps;
        }

        private void ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (this.bus.ThemNhaCungCap(nhaCungCap))
            {
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
                var ncc = this.allNhaCungCaps.Where(x => x.MaNCC.Trim() == nhaCungCap.MaNCC.Trim()).FirstOrDefault();
                if (ncc != null)
                    this.currentId = ncc.Id;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (this.bus.CapNhatNhaCungCap(nhaCungCap))
            {
                this.currentId = nhaCungCap.Id;
                MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaNhaCungCap()
        {
            if (this.bus.XoaNhaCungCap(this.currentId))
            {
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string RenderMaNhaCungCap()
        {
            var stt = (allNhaCungCaps?.Count ?? 0) + 1;
            var curLength = stt.ToString().Length + Utilities.PREFIX_MANCC.Length;
            string additionalZero = "";
            for (int i = 0; i < Utilities.MANCC_LENGTH - curLength; i++)
            {
                additionalZero += "0";
            }
            return Utilities.PREFIX_MANCC + additionalZero + stt.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.XoaNhaCungCap();
        }
    }
}
