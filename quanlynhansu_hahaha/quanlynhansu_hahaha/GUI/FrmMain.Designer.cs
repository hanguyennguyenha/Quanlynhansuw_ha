namespace quanlynhansu_hahaha.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bartaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.bardangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barnhanvientn = new DevExpress.XtraBars.BarButtonItem();
            this.barthongke = new DevExpress.XtraBars.BarButtonItem();
            this.bardantoc = new DevExpress.XtraBars.BarButtonItem();
            this.bartongiao = new DevExpress.XtraBars.BarButtonItem();
            this.bartrinhdohocvan = new DevExpress.XtraBars.BarButtonItem();
            this.bartrinhdotienganh = new DevExpress.XtraBars.BarButtonItem();
            this.barphongban = new DevExpress.XtraBars.BarButtonItem();
            this.barchucvu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 673);
            this.panel1.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bartaikhoan,
            this.bardangxuat,
            this.barButtonItem4,
            this.barnhanvientn,
            this.barthongke,
            this.bardantoc,
            this.bartongiao,
            this.bartrinhdohocvan,
            this.bartrinhdotienganh,
            this.barphongban,
            this.barchucvu});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1363, 217);
            // 
            // bartaikhoan
            // 
            this.bartaikhoan.Caption = "Thông tin tài khoản";
            this.bartaikhoan.Glyph = ((System.Drawing.Image)(resources.GetObject("bartaikhoan.Glyph")));
            this.bartaikhoan.Id = 2;
            this.bartaikhoan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bartaikhoan.LargeGlyph")));
            this.bartaikhoan.Name = "bartaikhoan";
            this.bartaikhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bartaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bartaikhoan_ItemClick);
            // 
            // bardangxuat
            // 
            this.bardangxuat.Caption = "Đăng xuất";
            this.bardangxuat.Glyph = ((System.Drawing.Image)(resources.GetObject("bardangxuat.Glyph")));
            this.bardangxuat.Id = 3;
            this.bardangxuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bardangxuat.LargeGlyph")));
            this.bardangxuat.Name = "bardangxuat";
            this.bardangxuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bardangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bardangxuat_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thống kê";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barnhanvientn
            // 
            this.barnhanvientn.Caption = "Thân nhân và nhân viên";
            this.barnhanvientn.Glyph = ((System.Drawing.Image)(resources.GetObject("barnhanvientn.Glyph")));
            this.barnhanvientn.Id = 5;
            this.barnhanvientn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barnhanvientn.LargeGlyph")));
            this.barnhanvientn.Name = "barnhanvientn";
            this.barnhanvientn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barnhanvientn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barnhanvientn_ItemClick);
            // 
            // barthongke
            // 
            this.barthongke.Caption = "Thống kê";
            this.barthongke.Glyph = ((System.Drawing.Image)(resources.GetObject("barthongke.Glyph")));
            this.barthongke.Id = 6;
            this.barthongke.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barthongke.LargeGlyph")));
            this.barthongke.Name = "barthongke";
            this.barthongke.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barthongke.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barthongke_ItemClick);
            // 
            // bardantoc
            // 
            this.bardantoc.Caption = "Dân tộc";
            this.bardantoc.Glyph = ((System.Drawing.Image)(resources.GetObject("bardantoc.Glyph")));
            this.bardantoc.Id = 7;
            this.bardantoc.Name = "bardantoc";
            this.bardantoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bardantoc_ItemClick);
            // 
            // bartongiao
            // 
            this.bartongiao.Caption = "Tôn giáo";
            this.bartongiao.Glyph = ((System.Drawing.Image)(resources.GetObject("bartongiao.Glyph")));
            this.bartongiao.Id = 8;
            this.bartongiao.Name = "bartongiao";
            this.bartongiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bartongiao_ItemClick);
            // 
            // bartrinhdohocvan
            // 
            this.bartrinhdohocvan.Caption = "Trình độ học vấn";
            this.bartrinhdohocvan.Glyph = ((System.Drawing.Image)(resources.GetObject("bartrinhdohocvan.Glyph")));
            this.bartrinhdohocvan.Id = 9;
            this.bartrinhdohocvan.Name = "bartrinhdohocvan";
            this.bartrinhdohocvan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bartrinhdohocvan_ItemClick);
            // 
            // bartrinhdotienganh
            // 
            this.bartrinhdotienganh.Caption = "Trình độ tiếng anh";
            this.bartrinhdotienganh.Glyph = ((System.Drawing.Image)(resources.GetObject("bartrinhdotienganh.Glyph")));
            this.bartrinhdotienganh.Id = 10;
            this.bartrinhdotienganh.Name = "bartrinhdotienganh";
            this.bartrinhdotienganh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bartrinhdotienganh_ItemClick);
            // 
            // barphongban
            // 
            this.barphongban.Caption = "Phòng ban";
            this.barphongban.Glyph = ((System.Drawing.Image)(resources.GetObject("barphongban.Glyph")));
            this.barphongban.Id = 11;
            this.barphongban.Name = "barphongban";
            this.barphongban.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barphongban_ItemClick);
            // 
            // barchucvu
            // 
            this.barchucvu.Caption = "Chức vụ";
            this.barchucvu.Glyph = ((System.Drawing.Image)(resources.GetObject("barchucvu.Glyph")));
            this.barchucvu.Id = 12;
            this.barchucvu.Name = "barchucvu";
            this.barchucvu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barchucvu_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bartaikhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.bardangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barnhanvientn);
            this.ribbonPageGroup2.ItemLinks.Add(this.barthongke);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bardantoc);
            this.ribbonPageGroup3.ItemLinks.Add(this.bartongiao);
            this.ribbonPageGroup3.ItemLinks.Add(this.bartrinhdohocvan);
            this.ribbonPageGroup3.ItemLinks.Add(this.bartrinhdotienganh);
            this.ribbonPageGroup3.ItemLinks.Add(this.barphongban);
            this.ribbonPageGroup3.ItemLinks.Add(this.barchucvu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Danh mục";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhân viên,thân nhân";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Nhân viên,thân nhân";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 1;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 673);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bartaikhoan;
        private DevExpress.XtraBars.BarButtonItem bardangxuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barnhanvientn;
        private DevExpress.XtraBars.BarButtonItem barthongke;
        private DevExpress.XtraBars.BarButtonItem bardantoc;
        private DevExpress.XtraBars.BarButtonItem bartongiao;
        private DevExpress.XtraBars.BarButtonItem bartrinhdohocvan;
        private DevExpress.XtraBars.BarButtonItem bartrinhdotienganh;
        private DevExpress.XtraBars.BarButtonItem barphongban;
        private DevExpress.XtraBars.BarButtonItem barchucvu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}