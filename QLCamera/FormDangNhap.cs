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
            try
            {
                if(bus.CheckLogIn(txtTaiKhoan.Text.Trim(), txtPassword.Text.Trim()))
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
    }
}
