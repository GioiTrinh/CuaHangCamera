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
    public partial class FrmHoaDon : Form
    {

        public FrmHoaDon()
        {
            bus = new BUS_HoaDon();
            sp = new BUS_SanPham();
            InitializeComponent();
        }
        private BUS_HoaDon bus;
        private BUS_SanPham sp;
        private List<HoaDon> hoaDons = new List<HoaDon>();

        private void FrmQLKH_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            hoaDons = bus.GetHoaDons();
            dgvQLKH.DataSource = hoaDons;
        }

        private int currentKhachHangId = -1;
        private int currentNhanVienId = -1;
        private int currentSanPhamId = -1;
        private int currentHoaDonId = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            if(currentKhachHangId != -1 && currentNhanVienId != -1)
            {
                if (dgvChiTiet.SelectedRows.Count > 0) {
                    if (this.sp.ThemBaoHanh(new ThongTinBaoHanh()
                    {
                        HoaDonId = this.currentHoaDonId,
                        NhanVienId = currentNhanVienId,
                        SanPhamId = currentSanPhamId,
                        ThoiGian = DateTime.Now,
                        LanThu = this.sp.GetLanBaoHanh(currentHoaDonId, currentSanPhamId) + 1
                    }))
                    {
                        MessageBox.Show("Cập nhật số lần bảo hành thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblSoLanBaoHanh.Text = this.sp.GetLanBaoHanh(currentHoaDonId, currentSanPhamId).ToString();
                    }
                }

            }
        }

        private void dgvQLKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLKH.SelectedRows.Count > 0)
            {
                try
                {
                    var x = dgvQLKH.SelectedRows[0];
                    currentNhanVienId = (int)x.Cells[2].Value;
                    currentKhachHangId = (int)x.Cells[3].Value;
                    currentHoaDonId = int.Parse(x.Cells[0].Value.ToString());
                    this.dgvChiTiet.DataSource = this.bus.GetChiTietHoaDon(currentHoaDonId);
                }
                catch (Exception)
                {

                }
            }
        }

        private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvChiTiet.SelectedRows.Count > 0)
            {
                try
                {
                    var x = dgvChiTiet.SelectedRows[0];
                    currentSanPhamId = (int)x.Cells[2].Value;
                    lblSoLanBaoHanh.Text = this.sp.GetLanBaoHanh(currentHoaDonId, currentSanPhamId).ToString();
                }
                catch (Exception)
                {
                }

            }
        }
    }
}
