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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSP,
            this.quảnKýNhânViênToolStripMenuItem,
            this.mnsQLKH,
            this.mnsQLNV,
            this.mnsQLNCC,
            this.mnsQLKho});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsSP
            // 
            this.mnsSP.Name = "mnsSP";
            this.mnsSP.Size = new System.Drawing.Size(72, 20);
            this.mnsSP.Text = "Sản phẩm";
            this.mnsSP.Click += new System.EventHandler(this.mnsSP_Click);
            // 
            // quảnKýNhânViênToolStripMenuItem
            // 
            this.quảnKýNhânViênToolStripMenuItem.Name = "quảnKýNhânViênToolStripMenuItem";
            this.quảnKýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.quảnKýNhânViênToolStripMenuItem.Text = "Hóa đơn";
            // 
            // mnsQLKH
            // 
            this.mnsQLKH.Name = "mnsQLKH";
            this.mnsQLKH.Size = new System.Drawing.Size(82, 20);
            this.mnsQLKH.Text = "Khách hàng";
            this.mnsQLKH.Click += new System.EventHandler(this.mnsQLKH_Click);
            // 
            // mnsQLNV
            // 
            this.mnsQLNV.Name = "mnsQLNV";
            this.mnsQLNV.Size = new System.Drawing.Size(77, 20);
            this.mnsQLNV.Text = "Nhân Viên ";
            this.mnsQLNV.Click += new System.EventHandler(this.mnsQLNV_Click);
            // 
            // mnsQLNCC
            // 
            this.mnsQLNCC.Name = "mnsQLNCC";
            this.mnsQLNCC.Size = new System.Drawing.Size(93, 20);
            this.mnsQLNCC.Text = "Nhà cung cấp";
            this.mnsQLNCC.Click += new System.EventHandler(this.mnsQLNCC_Click);
            // 
            // mnsQLKho
            // 
            this.mnsQLKho.Name = "mnsQLKho";
            this.mnsQLKho.Size = new System.Drawing.Size(40, 20);
            this.mnsQLKho.Text = "Kho";
            this.mnsQLKho.Click += new System.EventHandler(this.mnsQLKho_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QLCamera.Properties.Resources.logo1_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1018, 458);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
    }
}