namespace QLCamera
{
    partial class FrmHoaDon
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
            this.dgvQLKH = new System.Windows.Forms.DataGridView();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHangName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoLanBaoHanh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.AllowUserToAddRows = false;
            this.dgvQLKH.AllowUserToDeleteRows = false;
            this.dgvQLKH.AutoGenerateColumns = false;
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.NhanVienName,
            this.nhanVienIdDataGridViewTextBoxColumn,
            this.khachHangIdDataGridViewTextBoxColumn,
            this.KhachHangName,
            this.thoiGianDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dgvQLKH.DataSource = this.hoaDonBindingSource;
            this.dgvQLKH.Location = new System.Drawing.Point(12, 13);
            this.dgvQLKH.Name = "dgvQLKH";
            this.dgvQLKH.ReadOnly = true;
            this.dgvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLKH.Size = new System.Drawing.Size(653, 495);
            this.dgvQLKH.TabIndex = 10;
            this.dgvQLKH.SelectionChanged += new System.EventHandler(this.dgvQLKH_SelectionChanged);
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(DTO.HoaDon);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(DTO.KhachHang);
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoGenerateColumns = false;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.hoaDonIdDataGridViewTextBoxColumn,
            this.sanPhamIdDataGridViewTextBoxColumn,
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.dgvChiTiet.DataSource = this.chiTietHoaDonBindingSource;
            this.dgvChiTiet.Location = new System.Drawing.Point(701, 49);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(341, 368);
            this.dgvChiTiet.TabIndex = 11;
            this.dgvChiTiet.SelectionChanged += new System.EventHandler(this.dgvChiTiet_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
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
            this.sanPhamIdDataGridViewTextBoxColumn.DataPropertyName = "SanPhamId";
            this.sanPhamIdDataGridViewTextBoxColumn.HeaderText = "SanPhamId";
            this.sanPhamIdDataGridViewTextBoxColumn.Name = "sanPhamIdDataGridViewTextBoxColumn";
            this.sanPhamIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sanPhamIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            this.tenSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSanPhamDataGridViewTextBoxColumn.Width = 200;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataSource = typeof(DTO.ChiTietHoaDon);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chi tiết";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Bảo hành";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // NhanVienName
            // 
            this.NhanVienName.DataPropertyName = "NhanVienName";
            this.NhanVienName.HeaderText = "Nhân viên";
            this.NhanVienName.Name = "NhanVienName";
            this.NhanVienName.ReadOnly = true;
            this.NhanVienName.Width = 200;
            // 
            // nhanVienIdDataGridViewTextBoxColumn
            // 
            this.nhanVienIdDataGridViewTextBoxColumn.DataPropertyName = "NhanVienId";
            this.nhanVienIdDataGridViewTextBoxColumn.HeaderText = "NhanVienId";
            this.nhanVienIdDataGridViewTextBoxColumn.Name = "nhanVienIdDataGridViewTextBoxColumn";
            this.nhanVienIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.nhanVienIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // khachHangIdDataGridViewTextBoxColumn
            // 
            this.khachHangIdDataGridViewTextBoxColumn.DataPropertyName = "KhachHangId";
            this.khachHangIdDataGridViewTextBoxColumn.HeaderText = "KhachHangId";
            this.khachHangIdDataGridViewTextBoxColumn.Name = "khachHangIdDataGridViewTextBoxColumn";
            this.khachHangIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.khachHangIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // KhachHangName
            // 
            this.KhachHangName.DataPropertyName = "KhachHangName";
            this.KhachHangName.HeaderText = "Khách hàng";
            this.KhachHangName.Name = "KhachHangName";
            this.KhachHangName.ReadOnly = true;
            this.KhachHangName.Width = 200;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bảo hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đã bảo hành";
            // 
            // lblSoLanBaoHanh
            // 
            this.lblSoLanBaoHanh.AutoSize = true;
            this.lblSoLanBaoHanh.Location = new System.Drawing.Point(817, 469);
            this.lblSoLanBaoHanh.Name = "lblSoLanBaoHanh";
            this.lblSoLanBaoHanh.Size = new System.Drawing.Size(0, 20);
            this.lblSoLanBaoHanh.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(859, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "lần";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoLanBaoHanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.dgvQLKH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FrmQLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvQLKH;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVienIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHangIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangName;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoLanBaoHanh;
        private System.Windows.Forms.Label label5;
    }
}