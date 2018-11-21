namespace QLCamera
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsSP = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnKýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQLNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQLKho = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSP,
            this.quảnKýNhânViênToolStripMenuItem,
            this.mnsQLKH,
            this.mnsQLNV,
            this.mnsQLNCC,
            this.mnsQLKho,
            this.bánHàngToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1357, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsSP
            // 
            this.mnsSP.Name = "mnsSP";
            this.mnsSP.Size = new System.Drawing.Size(87, 24);
            this.mnsSP.Text = "Sản phẩm";
            this.mnsSP.Click += new System.EventHandler(this.mnsSP_Click);
            // 
            // quảnKýNhânViênToolStripMenuItem
            // 
            this.quảnKýNhânViênToolStripMenuItem.Name = "quảnKýNhânViênToolStripMenuItem";
            this.quảnKýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.quảnKýNhânViênToolStripMenuItem.Text = "Hóa đơn";
            this.quảnKýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnKýNhânViênToolStripMenuItem_Click);
            // 
            // mnsQLKH
            // 
            this.mnsQLKH.Name = "mnsQLKH";
            this.mnsQLKH.Size = new System.Drawing.Size(98, 24);
            this.mnsQLKH.Text = "Khách hàng";
            this.mnsQLKH.Click += new System.EventHandler(this.mnsQLKH_Click);
            // 
            // mnsQLNV
            // 
            this.mnsQLNV.Name = "mnsQLNV";
            this.mnsQLNV.Size = new System.Drawing.Size(93, 24);
            this.mnsQLNV.Text = "Nhân Viên ";
            this.mnsQLNV.Click += new System.EventHandler(this.mnsQLNV_Click);
            // 
            // mnsQLNCC
            // 
            this.mnsQLNCC.Name = "mnsQLNCC";
            this.mnsQLNCC.Size = new System.Drawing.Size(112, 24);
            this.mnsQLNCC.Text = "Nhà cung cấp";
            this.mnsQLNCC.Click += new System.EventHandler(this.mnsQLNCC_Click);
            // 
            // mnsQLKho
            // 
            this.mnsQLKho.Name = "mnsQLKho";
            this.mnsQLKho.Size = new System.Drawing.Size(47, 24);
            this.mnsQLKho.Text = "Kho";
            this.mnsQLKho.Click += new System.EventHandler(this.mnsQLKho_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QLCamera.Properties.Resources.logo1_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1357, 564);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsSP;
        private System.Windows.Forms.ToolStripMenuItem quảnKýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsQLKH;
        private System.Windows.Forms.ToolStripMenuItem mnsQLNV;
        private System.Windows.Forms.ToolStripMenuItem mnsQLNCC;
        private System.Windows.Forms.ToolStripMenuItem mnsQLKho;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
    }
}