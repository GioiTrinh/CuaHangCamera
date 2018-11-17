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
            this.quảnKýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnToolStripMenuItem,
            this.quảnKýNhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.cấpQuyềnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnKýNhânViênToolStripMenuItem
            // 
            this.quảnKýNhânViênToolStripMenuItem.Name = "quảnKýNhânViênToolStripMenuItem";
            this.quảnKýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.quảnKýNhânViênToolStripMenuItem.Text = "Hóa đơn";
            // 
            // quảnToolStripMenuItem
            // 
            this.quảnToolStripMenuItem.Name = "quảnToolStripMenuItem";
            this.quảnToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.quảnToolStripMenuItem.Text = "Sản phẩm";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên ";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // cấpQuyềnToolStripMenuItem
            // 
            this.cấpQuyềnToolStripMenuItem.Name = "cấpQuyềnToolStripMenuItem";
            this.cấpQuyềnToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cấpQuyềnToolStripMenuItem.Text = "Cấp quyền";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 406);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnKýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấpQuyềnToolStripMenuItem;
    }
}