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
    public partial class FormQLTaiKhoan : Form
    {
        BUS_TaiKhoan bus;
        BUS_NhanVien nv;
        List<NhanVien> nvs = new List<NhanVien>();
        int currentUserIdChoosen = -1;
        bool isNewTK = false;
        int currentTkId = -1;
        public FormQLTaiKhoan()
        {
            bus = new BUS_TaiKhoan();
            nv = new BUS_NhanVien();
            InitializeComponent();
        }

        private void InitData()
        {
            nvs = nv.GetNhanViens();
            cbNhanVien.DataSource = nvs;
            cbNhanVien.DisplayMember = "HoTenNV";
            cbNhanVien.ValueMember = "Id";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống tên tài khoản");
                return;
            }
            if (txtPassword.Text.Trim() == txtRetypepassword.Text.Trim())
            {
                if (this.isNewTK)
                {
                    if(bus.TaoTaiKhoan(new TaiKhoan
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        UserId = this.currentUserIdChoosen
                    }))

                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bại\nVui lòng thử lại");
                }
                else
                {
                    if(bus.DoiMatKhau(txtPassword.Text, this.currentTkId))
                        MessageBox.Show("Cập nhật mật khẩu thành công");
                    else
                        MessageBox.Show("Cập nhật mật khẩu thất bại\nVui lòng thử lại");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập mật khẩu mà nhập lại mật khẩu trùng nhau để tiếp tục");
            }
        }

        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            this.InitData();
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = this.cbNhanVien.SelectedValue;
            var nv = this.cbNhanVien.SelectedValue as NhanVien;

            this.currentUserIdChoosen = nv == null ? (int)a : nv.Id;
            var tk = GetTaiKhoanByNhanVien(this.currentUserIdChoosen);
            if (tk != null)
            {
                txtUsername.Text = tk.Username;
                txtUsername.Enabled = string.IsNullOrEmpty(tk.Username);
                txtPassword.Text = tk.Password;
                this.isNewTK = string.IsNullOrEmpty(tk.Username);
                this.currentTkId = tk.Id;
            }
        }

        private TaiKhoan GetTaiKhoanByNhanVien(int id)
        {
            return bus.GetTaiKhoanNhanVienHienTai(id);
        }
    }
}
