using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLCamera
{
    public partial class FrmQLKho : Form
    {
        BUS_Kho bus;
        private FormMode formMode = FormMode.Them;

        Kho khoEdit = new Kho();
        private List<Kho> khos = new List<Kho>();
        public FrmQLKho()
        {
            bus = new BUS_Kho();
            InitializeComponent();
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.LoadKho(this.txtTimKiem.Text);
        }

        private void FrmQLSP_Load(object sender, EventArgs e)
        {
            this.txtMaKho.Text = this.RenderMaKho();
            this.LoadKho();
        }
        
        private void LoadKho(string key = "")
        {
            key = key.Trim().ToLower();
            this.khos = this.bus.GetKhos(key);
            this.dgvQLSP.DataSource = this.khos;
        }
        

        private void Luu(FormMode mode, Kho sp)
        {
            switch (mode)
            {
                case FormMode.Them:
                    if (this.bus.CheckTonTaiKhoByTen(txtTenKho.Text))
                    {
                        MessageBox.Show("Tên sản phẩm đã tồn tại.\n Vui lòng sử dụng tên khác", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (this.bus.ThemKho(sp))
                        MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm thất bại.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadKho();
                    break;
                case FormMode.Sua: 
                    if(this.bus.CapNhatKho(sp))
                        MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cập nhật thất bại.\nVui lòng thử lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadKho();
                    break;
                default:
                    MessageBox.Show("Vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.formMode = FormMode.Them;
            this.txtMaKho.Text = this.RenderMaKho();
            this.ResetForm();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            this.khoEdit = new Kho()
            {
                Id = this.khoEdit.Id,
                MaKho = this.txtMaKho.Text.Trim(),
                TenKho = this.txtTenKho.Text.Trim()
            };
            this.Luu(this.formMode, khoEdit);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(this.khoEdit != null)
            {
                if (this.bus.XoaKho(this.khoEdit.Id))
                {
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadKho();
                    this.khoEdit = new Kho();
                    this.Binding();
                }
                else {
                    MessageBox.Show("Xóa thất bại.\n Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string RenderMaKho()
        {
            var stt = (GetMaxId() + 1);
            var curLength = Utilities.PREFIX_MAKHO.Length + stt.ToString().Length;
            string additionalZero = "";
            for (int i = 0; i < Utilities.MAKHO_LENGTH - curLength; i++)
            {
                additionalZero += "0";
            }
            return Utilities.PREFIX_MAKHO + additionalZero + stt.ToString();
        }

        private int GetMaxId()
        {
            if (khos == null || !khos.Any())
                return 0;
            else
            {
                var listIds = khos.Select(x => x.Id).ToList();
                var maxId = listIds.Max();
                var maNv = khos.Find(x => x.Id == maxId).MaKho;
                var d = maNv.Replace(Utilities.PREFIX_MAKHO, "");
                if (int.TryParse(d, out int m))
                {
                    return m;
                }
                return 0;
            }
        }
        private void dgvQLSP_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvQLSP.SelectedRows.Count == 1)
            {
                this.formMode = FormMode.Sua;
                var selected = dgvQLSP.SelectedRows[0];
                int.TryParse(selected.Cells[0].Value.ToString(), out int id);
                this.khoEdit = this.bus.GetKho(id);
                this.Binding();
            }
        }

        private void Binding()
        {
            this.txtMaKho.Text = this.khoEdit.MaKho;
            this.txtTenKho.Text = this.khoEdit.TenKho;
        }

        private void ResetForm()
        {
            txtTenKho.Text = "";
        }
    }
}
