namespace QLCamera
{
    partial class FrmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPhamDat = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHoaDonMuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHienCo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonMuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSanPham
            // 
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(30, 170);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(356, 28);
            this.cbSanPham.TabIndex = 0;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSoLuong.Location = new System.Drawing.Point(420, 171);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(120, 26);
            this.nmrSoLuong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(579, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 28);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSanPhamDat
            // 
            this.dgvSanPhamDat.AllowUserToAddRows = false;
            this.dgvSanPhamDat.AllowUserToDeleteRows = false;
            this.dgvSanPhamDat.AutoGenerateColumns = false;
            this.dgvSanPhamDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hoaDonIdDataGridViewTextBoxColumn,
            this.sanPhamIdDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dgvSanPhamDat.DataSource = this.chiTietHoaDonMuaBindingSource;
            this.dgvSanPhamDat.Location = new System.Drawing.Point(30, 244);
            this.dgvSanPhamDat.Name = "dgvSanPhamDat";
            this.dgvSanPhamDat.ReadOnly = true;
            this.dgvSanPhamDat.RowTemplate.Height = 24;
            this.dgvSanPhamDat.Size = new System.Drawing.Size(643, 373);
            this.dgvSanPhamDat.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoaDonIdDataGridViewTextBoxColumn
            // 
            this.hoaDonIdDataGridViewTextBoxColumn.DataPropertyName = "HoaDonId";
            this.hoaDonIdDataGridViewTextBoxColumn.HeaderText = "HoaDonId";
            this.hoaDonIdDataGridViewTextBoxColumn.Name = "hoaDonIdDataGridViewTextBoxColumn";
            this.hoaDonIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoaDonIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sanPhamIdDataGridViewTextBoxColumn
            // 
            this.sanPhamIdDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.sanPhamIdDataGridViewTextBoxColumn.HeaderText = "Sản phẩm";
            this.sanPhamIdDataGridViewTextBoxColumn.Name = "sanPhamIdDataGridViewTextBoxColumn";
            this.sanPhamIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sanPhamIdDataGridViewTextBoxColumn.Width = 400;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 200;
            // 
            // chiTietHoaDonMuaBindingSource
            // 
            this.chiTietHoaDonMuaBindingSource.DataSource = typeof(DTO.ChiTietHoaDonMua);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(579, 644);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 28);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(30, 72);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(356, 28);
            this.cbKhachHang.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hiện có";
            // 
            // lblHienCo
            // 
            this.lblHienCo.AutoSize = true;
            this.lblHienCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienCo.Location = new System.Drawing.Point(236, 133);
            this.lblHienCo.Name = "lblHienCo";
            this.lblHienCo.Size = new System.Drawing.Size(0, 20);
            this.lblHienCo.TabIndex = 6;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 684);
            this.Controls.Add(this.lblHienCo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvSanPhamDat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrSoLuong);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.cbSanPham);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBanHang";
            this.Text = "FrmQLSP";
            this.Load += new System.EventHandler(this.FrmNhapHangTuNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonMuaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSanPhamDat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource chiTietHoaDonMuaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHienCo;
    }
}