using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLCamera
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            bus = new BUS_NhanVien();
            InitializeComponent();
        }
        private BUS_NhanVien bus;
        private List<NhanVien> nhanViens = new List<NhanVien>();
        private FormMode formMode = FormMode.Them;
        private int currentId = -1;
        private List<ComboboxItems> capBacs = new List<ComboboxItems>();
        private void btThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = this.RenderMaNhanVien();


            this.NewNV();


        }
        
        private void ThemNhanVien(NhanVien nhanVien)
        {
            if (this.bus.ThemNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
                var nv = this.nhanViens.Where(x => x.MaNV.Trim() == nhanVien.MaNV.Trim()).FirstOrDefault();
                if (nv != null)
                    this.currentId = nv.Id;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapNhatNhanVien(NhanVien nhanVien)
        {
            if (this.bus.CapNhatNhanVien(nhanVien))
            {
                this.currentId = nhanVien.Id;
                MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaNhanVien()
        {
            if (this.bus.XoaNhanVien(this.currentId))
            {
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string RenderMaNhanVien()
        {
            var stt = (nhanViens?.Count ?? 0) + 1;
            var curLength = stt.ToString().Length + Utilities.PREFIX_MaNV.Length;
            string additionalZero = "";
            for (int i = 0; i < Utilities.MaNV_LENGTH - curLength; i++)
            {
                additionalZero += "0";
            }
            return Utilities.PREFIX_MaNV + additionalZero + stt.ToString();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = this.RenderMaNhanVien();
            this.LoadCapBac();
            this.LoadData();
        }
        private void LoadData(string key = "")
        {
            nhanViens = bus.GetNhanViens(key);
            nhanViens.ForEach(x =>
            {
                x.TenCapBac = x.CapBac == (int)CapBacNhanVien.Admin ? "Admin" : "Staff";
            });
            dgvQLNV.DataSource = nhanViens;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            switch (this.formMode)
            {
                case FormMode.Them:
                    var nv = new NhanVien
                    {
                        MaNV = txtMaNV.Text.Trim(),
                        HoTenNV = txtTenNV.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Sdt = txtSDT.Text.Trim(),
                        Cmnd = txtCmnd.Text.Trim(),
                        Luong = double.Parse(nmrLuong.Value.ToString()),
                        CapBac = int.Parse(cbCapBac.SelectedValue.ToString())
                        
                    };

                    this.ThemNhanVien(nv);
                    break;
                case FormMode.Sua:

                    nv = this.bus.GetNhanVien(this.currentId);

                    nv.MaNV = txtMaNV.Text.Trim();
                    nv.HoTenNV = txtTenNV.Text.Trim();
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.Email = txtEmail.Text.Trim();
                    nv.Sdt = txtSDT.Text.Trim();
                    nv.Cmnd = txtCmnd.Text.Trim();
                    nv.Luong = double.Parse(nmrLuong.Value.ToString());
                    nv.CapBac = int.Parse(cbCapBac.SelectedValue.ToString());
                    this.CapNhatNhanVien(nv);
                    break;
                default:
                    break;
            }
        }
        private void NewNV()
        {
            this.formMode = FormMode.Them;

            txtMaNV.Text = this.RenderMaNhanVien();
            txtTenNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCmnd.Text = string.Empty;
            nmrLuong.Value = 0;
        }

        private void dgvQLNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLNV.SelectedRows.Count == 1)
            {
                var selectedId = dgvQLNV.SelectedRows[0].Cells[0].Value.ToString();
                if (int.TryParse(selectedId, out this.currentId))
                {
                    var nv = this.bus.GetNhanVien(this.currentId);
                    txtMaNV.Text = nv.MaNV;
                    txtTenNV.Text = nv.HoTenNV;
                    txtDiaChi.Text = nv.DiaChi;
                    txtEmail.Text = nv.Email;
                    txtSDT.Text = nv.Sdt;
                    txtCmnd.Text = nv.Cmnd;
                    this.cbCapBac.SelectedValue = nv.CapBac;
                    nmrLuong.Value = decimal.Parse(nv.Luong.ToString());
                }

                this.formMode = FormMode.Sua;
            }
        }

        private void LoadCapBac()
        {
            this.capBacs = new List<ComboboxItems>()
            {
                new ComboboxItems()
                {
                    Id = (int)CapBacNhanVien.Admin,
                    Label = Utilities.ADMIN_LABEL
                },
                new ComboboxItems()
                {
                    Id = (int)CapBacNhanVien.Staff,
                    Label = Utilities.STAFF_LABEL
                },

            };

            this.cbCapBac.DataSource = this.capBacs;
            this.cbCapBac.DisplayMember = "Label";
            this.cbCapBac.ValueMember = "Id";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.LoadData(this.txtTimKiem.Text.Trim());
        }
    }
}
