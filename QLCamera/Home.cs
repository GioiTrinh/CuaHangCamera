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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.tàiKhoảnToolStripMenuItem.Visible = Program._CapBac == (int)CapBacNhanVien.Admin;
        }

        private void mnsSP_Click(object sender, EventArgs e)
        {
            FrmQLSP QLSP = new FrmQLSP();
            QLSP.StartPosition = FormStartPosition.CenterScreen;
            QLSP.MdiParent = this;
            QLSP.Show();
        }

        private void mnsQLKH_Click(object sender, EventArgs e)
        {
            FrmQLKH QLKH = new FrmQLKH();
            QLKH.StartPosition = FormStartPosition.CenterScreen;
            QLKH.MdiParent = this;
            QLKH.Show();
        }

        private void mnsQLNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien QLNV = new FrmNhanVien();
            QLNV.StartPosition = FormStartPosition.CenterScreen;
            QLNV.MdiParent = this;
            QLNV.Show();
        }

        private void mnsQLNCC_Click(object sender, EventArgs e)
        {
            FrmQLNCC QLNCC = new FrmQLNCC();
            QLNCC.StartPosition = FormStartPosition.CenterScreen;
            QLNCC.MdiParent = this;
            QLNCC.Show();
        }

        private void mnsQLKho_Click(object sender, EventArgs e)
        {
            FrmQLKho Kho = new FrmQLKho();
            Kho.StartPosition = FormStartPosition.CenterScreen;
            Kho.MdiParent = this;
            Kho.Show();
        }
        
        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTaiKhoan tk = new FormQLTaiKhoan();
            tk.StartPosition = FormStartPosition.CenterScreen;
            tk.MdiParent = this;
            tk.Show();
        }
    }
}
