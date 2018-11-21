using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCamera
{
    public partial class FormDangNhap : Form
    {
        BUS_TaiKhoan bus;
        public FormDangNhap()
        {
            bus = new BUS_TaiKhoan();
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }

        private void DangNhap()
        {
            try
            {
                if (string.IsNullOrEmpty(txtTaiKhoan.Text.Trim())){
                    MessageBox.Show("Phải nhập vào tài khoản", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show("Phải nhập vào mật khẩu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (bus.CheckLogIn(txtTaiKhoan.Text.Trim(), txtPassword.Text.Trim()))
                {
                    Program._isSignedIn = true;
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.DangNhap();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DangNhap();
            }
        }
    }
}
