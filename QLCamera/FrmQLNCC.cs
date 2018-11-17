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
        private FormMode formMode = FormMode.Them;
        private int currentId = -1;
        public FrmQLNCC()
        {
            bus = new BUS_NhaCungCap();
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (this.formMode)
            {
                case FormMode.Them:
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
                    break;
                case FormMode.Sua:

                    ncc = this.bus.GetNhaCungCap(this.currentId);

                    ncc.MaNCC = txtMa.Text.Trim();
                    ncc.TenNCC = txtTenNhaCungCap.Text.Trim();
                    ncc.DiaChi = txtDiaChi.Text.Trim();
                    ncc.Email = txtEmail.Text.Trim();
                    ncc.Sdt = txtSoDienThoai.Text.Trim();
                    ncc.Website = txtWebsite.Text.Trim();

                    this.CapNhatNhaCungCap(ncc);
                    break;
                default:
                    break;
            }
        }

        private void FrmQLNCC_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData(string key = "")
        {
            nhaCungCaps = bus.GetNhaCungCaps(key);
            dgvQLNCC.DataSource = nhaCungCaps;
        }

        private void ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (this.bus.ThemNhaCungCap(nhaCungCap))
            {
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
                var ncc = this.nhaCungCaps.Where(x => x.MaNCC.Trim() == nhaCungCap.MaNCC.Trim()).FirstOrDefault();
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
            var stt = (nhaCungCaps?.Count ?? 0) + 1;
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.LoadData(txtTimKiem.Text.Trim().ToLower());
        }

        private void dgvQLNCC_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvQLNCC.SelectedRows.Count == 1)
            {
                var selectedId = dgvQLNCC.SelectedRows[0].Cells[0].Value.ToString();
                if(int.TryParse(selectedId, out this.currentId))
                {
                    var ncc = this.bus.GetNhaCungCap(this.currentId);
                    txtMa.Text = ncc.MaNCC;
                    txtTenNhaCungCap.Text = ncc.TenNCC;
                    txtDiaChi.Text = ncc.DiaChi;
                    txtEmail.Text = ncc.Email;
                    txtSoDienThoai.Text = ncc.Sdt;
                    txtWebsite.Text = ncc.Website;
                }

                this.formMode = FormMode.Sua;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if(txtSoDienThoai.Text.Trim().Length > 20)
            {
                MessageBox.Show("Số điện thoại không lớn hơn 20 ký tự, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Text = txtSoDienThoai.Text.Trim().Substring(0, 19);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.NewNCC();
        }

        private void NewNCC()
        {
            this.formMode = FormMode.Them;

            txtMa.Text = this.RenderMaNhaCungCap();
            txtTenNhaCungCap.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtWebsite.Text = string.Empty;
        }
    }
}
