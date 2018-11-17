namespace QLCamera
{
    partial class FrmNhanVien
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cbCapBac = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nmrLuong = new System.Windows.Forms.NumericUpDown();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capBacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCapBacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(494, 20);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(169, 20);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.AllowUserToAddRows = false;
            this.dgvQLNV.AllowUserToDeleteRows = false;
            this.dgvQLNV.AutoGenerateColumns = false;
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cmndDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.capBacDataGridViewTextBoxColumn,
            this.tenCapBacDataGridViewTextBoxColumn});
            this.dgvQLNV.DataSource = this.nhanVienBindingSource;
            this.dgvQLNV.Location = new System.Drawing.Point(2, 65);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.ReadOnly = true;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(652, 382);
            this.dgvQLNV.TabIndex = 15;
            this.dgvQLNV.SelectionChanged += new System.EventHandler(this.dgvQLNV_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmrLuong);
            this.panel1.Controls.Add(this.cbCapBac);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCmnd);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Location = new System.Drawing.Point(670, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 413);
            this.panel1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "CMND";
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(112, 180);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(157, 20);
            this.txtCmnd.TabIndex = 13;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(221, 23);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(48, 28);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 152);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(221, 292);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(48, 29);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu ";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(165, 292);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(48, 29);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(112, 25);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(101, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(112, 121);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(157, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(112, 90);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(157, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(112, 59);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(157, 20);
            this.txtTenNV.TabIndex = 3;
            // 
            // cbCapBac
            // 
            this.cbCapBac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapBac.FormattingEnabled = true;
            this.cbCapBac.Location = new System.Drawing.Point(112, 235);
            this.cbCapBac.Name = "cbCapBac";
            this.cbCapBac.Size = new System.Drawing.Size(157, 21);
            this.cbCapBac.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lương";
            // 
            // nmrLuong
            // 
            this.nmrLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrLuong.Location = new System.Drawing.Point(112, 208);
            this.nmrLuong.Name = "nmrLuong";
            this.nmrLuong.Size = new System.Drawing.Size(157, 23);
            this.nmrLuong.TabIndex = 18;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(DTO.NhanVien);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            this.hoTenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmndDataGridViewTextBoxColumn
            // 
            this.cmndDataGridViewTextBoxColumn.DataPropertyName = "Cmnd";
            this.cmndDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cmndDataGridViewTextBoxColumn.Name = "cmndDataGridViewTextBoxColumn";
            this.cmndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Lương";
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capBacDataGridViewTextBoxColumn
            // 
            this.capBacDataGridViewTextBoxColumn.DataPropertyName = "CapBac";
            this.capBacDataGridViewTextBoxColumn.HeaderText = "Cấp Bậc";
            this.capBacDataGridViewTextBoxColumn.Name = "capBacDataGridViewTextBoxColumn";
            this.capBacDataGridViewTextBoxColumn.ReadOnly = true;
            this.capBacDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenCapBacDataGridViewTextBoxColumn
            // 
            this.tenCapBacDataGridViewTextBoxColumn.DataPropertyName = "TenCapBac";
            this.tenCapBacDataGridViewTextBoxColumn.HeaderText = "Cấp Bậc";
            this.tenCapBacDataGridViewTextBoxColumn.Name = "tenCapBacDataGridViewTextBoxColumn";
            this.tenCapBacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.ComboBox cbCapBac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmrLuong;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capBacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCapBacDataGridViewTextBoxColumn;
    }
}