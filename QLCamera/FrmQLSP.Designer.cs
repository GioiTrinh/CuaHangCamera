namespace QLCamera
{
    partial class FrmQLSP
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
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrGia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.nmrThang = new System.Windows.Forms.NumericUpDown();
            this.nmrNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(145, 37);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(140, 20);
            this.txtMaSanPham.TabIndex = 15;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(145, 13);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(140, 20);
            this.txtTenSanPham.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nmrGia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.nmrThang);
            this.panel1.Controls.Add(this.nmrNam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaSanPham);
            this.panel1.Controls.Add(this.txtTenSanPham);
            this.panel1.Location = new System.Drawing.Point(646, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 191);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "VND";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrGia
            // 
            this.nmrGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrGia.Location = new System.Drawing.Point(145, 120);
            this.nmrGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrGia.Name = "nmrGia";
            this.nmrGia.Size = new System.Drawing.Size(90, 23);
            this.nmrGia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(200, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 25);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(293, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 27);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(279, 155);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(74, 25);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // nmrThang
            // 
            this.nmrThang.Location = new System.Drawing.Point(145, 96);
            this.nmrThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrThang.Name = "nmrThang";
            this.nmrThang.Size = new System.Drawing.Size(72, 20);
            this.nmrThang.TabIndex = 14;
            // 
            // nmrNam
            // 
            this.nmrNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrNam.Location = new System.Drawing.Point(145, 68);
            this.nmrNam.Name = "nmrNam";
            this.nmrNam.Size = new System.Drawing.Size(72, 23);
            this.nmrNam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời Gian Bảo Hành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.AllowUserToAddRows = false;
            this.dgvQLSP.AllowUserToDeleteRows = false;
            this.dgvQLSP.AutoGenerateColumns = false;
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maSpDataGridViewTextBoxColumn,
            this.tenSpDataGridViewTextBoxColumn,
            this.baoHanhDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dgvQLSP.DataSource = this.sanPhamBindingSource;
            this.dgvQLSP.Location = new System.Drawing.Point(12, 40);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.ReadOnly = true;
            this.dgvQLSP.Size = new System.Drawing.Size(628, 484);
            this.dgvQLSP.TabIndex = 3;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(DTO.SanPham);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(488, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(152, 23);
            this.txtTimKiem.TabIndex = 103;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataSource = typeof(DTO.NhaCungCap);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maSpDataGridViewTextBoxColumn
            // 
            this.maSpDataGridViewTextBoxColumn.DataPropertyName = "MaSp";
            this.maSpDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSpDataGridViewTextBoxColumn.Name = "maSpDataGridViewTextBoxColumn";
            this.maSpDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSpDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenSpDataGridViewTextBoxColumn
            // 
            this.tenSpDataGridViewTextBoxColumn.DataPropertyName = "TenSp";
            this.tenSpDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSpDataGridViewTextBoxColumn.Name = "tenSpDataGridViewTextBoxColumn";
            this.tenSpDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSpDataGridViewTextBoxColumn.Width = 200;
            // 
            // baoHanhDataGridViewTextBoxColumn
            // 
            this.baoHanhDataGridViewTextBoxColumn.DataPropertyName = "BaoHanh";
            this.baoHanhDataGridViewTextBoxColumn.HeaderText = "Bảo Hành";
            this.baoHanhDataGridViewTextBoxColumn.Name = "baoHanhDataGridViewTextBoxColumn";
            this.baoHanhDataGridViewTextBoxColumn.ReadOnly = true;
            this.baoHanhDataGridViewTextBoxColumn.Width = 130;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvQLSP);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQLSP";
            this.Text = "FrmQLSP";
            this.Load += new System.EventHandler(this.FrmQLSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmrThang;
        private System.Windows.Forms.NumericUpDown nmrNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
    }
}