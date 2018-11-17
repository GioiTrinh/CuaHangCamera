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
    public partial class FrmNhapHangTuNCC : Form
    {
        BUS_SanPham bus;
        private FormMode formMode = FormMode.Them;
        private List<SanPham> sanPhams = new List<SanPham>();
        public FrmNhapHangTuNCC()
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
            this.LoadSanPham();
        }
        
        private void LoadSanPham(string key = "")
        {
            key = key.Trim().ToLower();
            this.sanPhams = this.bus.GetSanPhams(key);
        }

        private void Binding()
        {
            
        }

        private void Luu(FormMode mode, SanPham sp)
        {
            switch (mode)
            {
                case FormMode.Them:
                    this.bus.ThemSanPham(sp);
                    break;
                case FormMode.Sua:
                    this.bus.CapNhatSanPham(sp);
                    break;
                default:
                    MessageBox.Show("Vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }
            
    }
}
