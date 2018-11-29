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
    public partial class FrmQLKH : Form
    {

        public FrmQLKH()
        {
            bus = new BUS_KhachHang();
            InitializeComponent();
        }
        private BUS_KhachHang bus;
        private List<KhachHang> khachHangs = new List<KhachHang>();
        private FormMode formMode = FormMode.Them;
        private int currentId = -1;
        private void btThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = this.RenderMaKhachHang();
            this.NewKH();
        }
        private void ThemKhachHang(KhachHang khachHang)
        {
            if (this.bus.ThemKhachHang(khachHang))
            {
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
                var kh = this.khachHangs.Where(x => x.MaKH.Trim() == khachHang.MaKH.Trim()).FirstOrDefault();
                if (kh != null)
                    this.currentId = kh.Id;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapNhatKhachHang(KhachHang khachHang)
        {
            if (this.bus.CapNhatKhachHang(khachHang))
            {
                this.currentId = khachHang.Id;
                MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaKhachHang()
        {
            if (this.bus.XoaKhachHang(this.currentId))
            {
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string RenderMaKhachHang()
        {
            var stt = GetMaxId() + 1;
            var curLength = stt.ToString().Length + Utilities.PREFIX_MaKH.Length;
            string additionalZero = "";
            for (int i = 0; i < Utilities.MaKH_LENGTH - curLength; i++)
            {
                additionalZero += "0";
            }
            return Utilities.PREFIX_MaKH + additionalZero + stt.ToString();
        }

        private int GetMaxId()
        {
            if (khachHangs == null || !khachHangs.Any())
                return 0;
            else
            {
                var listIds = khachHangs.Select(x => x.Id).ToList();
                var maxId = listIds.Max();
                var maNv = khachHangs.Find(x => x.Id == maxId).MaKH;
                var d = maNv.Replace(Utilities.PREFIX_MaKH, "");
                if (int.TryParse(d, out int m))
                {
                    return m;
                }
                return 0;
            }
        }

        private void FrmQLKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = this.RenderMaKhachHang();
            this.LoadData();
        }
        private void LoadData(string key = "")
        {
            khachHangs = bus.GetKhachHangs(key);
            dgvQLKH.DataSource = khachHangs;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            switch (this.formMode)
            {
                case FormMode.Them:
                    var kh = new KhachHang
                    {
                        MaKH = txtMaKH.Text.Trim(),
                        HoTenKH = txtTenKH.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        Sdt = txtSDT.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };
                    this.ThemKhachHang(kh);
                    break;
                case FormMode.Sua:
                    kh = this.bus.GetKhachHang(this.currentId);

                    kh.MaKH = txtMaKH.Text.Trim();
                    kh.HoTenKH = txtTenKH.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text.Trim();
                    kh.Sdt = txtSDT.Text.Trim();
                    kh.Email = txtEmail.Text.Trim();
                    
                    this.CapNhatKhachHang(kh);
                    break;
                default:
                    break;
            }
            
        }
        private void NewKH()
        {
            this.formMode = FormMode.Them;

            txtMaKH.Text = this.RenderMaKhachHang();
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            
        }

        private void dgvQLKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLKH.SelectedRows.Count == 1)
            {
                var selectedId = dgvQLKH.SelectedRows[0].Cells[0].Value.ToString();
                if (int.TryParse(selectedId, out this.currentId))
                {
                    var kh = this.bus.GetKhachHang(this.currentId);
                    txtMaKH.Text = kh.MaKH;
                    txtTenKH.Text = kh.HoTenKH;
                    txtDiaChi.Text = kh.DiaChi;                    
                    txtSDT.Text = kh.Sdt;
                    txtEmail.Text = kh.Email;
                }
                this.formMode = FormMode.Sua;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            this.LoadData(this.txtTimKiem.Text.Trim());
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.bus.XoaKhachHang(this.currentId))
            {
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
