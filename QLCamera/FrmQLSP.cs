﻿using BUS;
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
    public partial class FrmQLSP : Form
    {
        BUS_SanPham bus;
        private FormMode formMode = FormMode.Them;
        private List<SanPham> sanPhams = new List<SanPham>();
        public FrmQLSP()
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
            this.dgvQLSP.DataSource = this.sanPhams;
        }
        

        private void Luu(FormMode mode, SanPham sp)
        {
            switch (mode)
            {
                case FormMode.Them:
                    this.bus.ThemSanPham(sp);
                    this.LoadSanPham();
                    break;
                case FormMode.Sua:
                    this.bus.CapNhatSanPham(sp);
                    this.LoadSanPham();
                    break;
                default:
                    MessageBox.Show("Vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            var sanPham = new SanPham();
            this.Luu(this.formMode, sanPham);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        private string RenderMaSanPham()
        {
            var stt = ((sanPhams?.Count ?? 0) + 1);
            var curLength = Utilities.PREFIX_MASANPHAM.Length + stt.ToString().Length;
            string additionalZero = "";
            for (int i = 0; i < Utilities.MASP_LENGTH - curLength; i++)
            {
                additionalZero += "0";
            }
            return Utilities.PREFIX_MASANPHAM + additionalZero + stt.ToString();
        }
    }
}
