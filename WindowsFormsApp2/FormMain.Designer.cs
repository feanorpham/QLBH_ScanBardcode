namespace WindowsFormsApp2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.HT_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.dmHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.hhNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.hhXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.hhInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.hdThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.bcDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHT,
            this.menuDM,
            this.menuHoaDon,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHT
            // 
            this.menuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HT_thoat});
            this.menuHT.Image = ((System.Drawing.Image)(resources.GetObject("menuHT.Image")));
            this.menuHT.Name = "menuHT";
            this.menuHT.Size = new System.Drawing.Size(87, 20);
            this.menuHT.Text = "Hệ Thống";
            // 
            // HT_thoat
            // 
            this.HT_thoat.Name = "HT_thoat";
            this.HT_thoat.Size = new System.Drawing.Size(104, 22);
            this.HT_thoat.Text = "Thoát";
            this.HT_thoat.Click += new System.EventHandler(this.HT_thoat_Click);
            // 
            // menuDM
            // 
            this.menuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmHangHoa});
            this.menuDM.Image = ((System.Drawing.Image)(resources.GetObject("menuDM.Image")));
            this.menuDM.Name = "menuDM";
            this.menuDM.Size = new System.Drawing.Size(90, 20);
            this.menuDM.Text = "Danh Mục";
            // 
            // dmHangHoa
            // 
            this.dmHangHoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hhNhap,
            this.hhXuat,
            this.hhInfo});
            this.dmHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("dmHangHoa.Image")));
            this.dmHangHoa.Name = "dmHangHoa";
            this.dmHangHoa.Size = new System.Drawing.Size(126, 22);
            this.dmHangHoa.Text = "Hàng hóa";
            // 
            // hhNhap
            // 
            this.hhNhap.Image = ((System.Drawing.Image)(resources.GetObject("hhNhap.Image")));
            this.hhNhap.Name = "hhNhap";
            this.hhNhap.Size = new System.Drawing.Size(156, 22);
            this.hhNhap.Text = "Nhập hàng hóa";
            this.hhNhap.Click += new System.EventHandler(this.hhNhap_Click);
            // 
            // hhXuat
            // 
            this.hhXuat.Image = ((System.Drawing.Image)(resources.GetObject("hhXuat.Image")));
            this.hhXuat.Name = "hhXuat";
            this.hhXuat.Size = new System.Drawing.Size(156, 22);
            this.hhXuat.Text = "Xuất hàng hóa";
            // 
            // hhInfo
            // 
            this.hhInfo.Image = ((System.Drawing.Image)(resources.GetObject("hhInfo.Image")));
            this.hhInfo.Name = "hhInfo";
            this.hhInfo.Size = new System.Drawing.Size(156, 22);
            this.hhInfo.Text = "Thông tin";
            this.hhInfo.Click += new System.EventHandler(this.hhInfo_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hdThanhToan});
            this.menuHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("menuHoaDon.Image")));
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(82, 20);
            this.menuHoaDon.Text = "Hóa Đơn";
            // 
            // hdThanhToan
            // 
            this.hdThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("hdThanhToan.Image")));
            this.hdThanhToan.Name = "hdThanhToan";
            this.hdThanhToan.Size = new System.Drawing.Size(143, 22);
            this.hdThanhToan.Text = "Hóa đơn bán";
            this.hdThanhToan.Click += new System.EventHandler(this.hdThanhToan_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bcDoanhThu});
            this.menuBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("menuBaoCao.Image")));
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(84, 20);
            this.menuBaoCao.Text = "Thống kê";
            // 
            // bcDoanhThu
            // 
            this.bcDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("bcDoanhThu.Image")));
            this.bcDoanhThu.Name = "bcDoanhThu";
            this.bcDoanhThu.Size = new System.Drawing.Size(130, 22);
            this.bcDoanhThu.Text = "Doanh thu";
            this.bcDoanhThu.Click += new System.EventHandler(this.bcDoanhThu_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 581);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHT;
        private System.Windows.Forms.ToolStripMenuItem menuDM;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem dmHangHoa;
        private System.Windows.Forms.ToolStripMenuItem hhNhap;
        private System.Windows.Forms.ToolStripMenuItem hhXuat;
        private System.Windows.Forms.ToolStripMenuItem hhInfo;
        private System.Windows.Forms.ToolStripMenuItem hdThanhToan;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem bcDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem HT_thoat;
    }
}