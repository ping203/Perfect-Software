namespace QLBH_ProductManagement.GUI
{
    partial class frmCollectMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectMoney));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDanhSachPhieuThu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDanhSachPhieuCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDanhSachPhieuTraNgay = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheoDoiCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTongHopCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.userControl = new DevExpress.XtraEditors.XtraUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("754f2fe3-a1e5-4413-b0d0-a3a9f6713308");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(172, 200);
            this.dockPanel1.Size = new System.Drawing.Size(172, 537);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(165, 505);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiDanhSachPhieuThu,
            this.nbiDanhSachPhieuCongNo,
            this.nbiDanhSachPhieuTraNgay,
            this.nbiTheoDoiCongNo,
            this.nbiTongHopCongNo});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl1.Size = new System.Drawing.Size(165, 505);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Phiếu Thu";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDanhSachPhieuThu)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiDanhSachPhieuThu
            // 
            this.nbiDanhSachPhieuThu.Caption = "Danh Sách Phiếu Thu";
            this.nbiDanhSachPhieuThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDanhSachPhieuThu.ImageOptions.LargeImage")));
            this.nbiDanhSachPhieuThu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDanhSachPhieuThu.ImageOptions.SmallImage")));
            this.nbiDanhSachPhieuThu.Name = "nbiDanhSachPhieuThu";
            this.nbiDanhSachPhieuThu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDanhSachPhieuThu_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDanhSachPhieuCongNo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDanhSachPhieuTraNgay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoDoiCongNo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTongHopCongNo)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiDanhSachPhieuCongNo
            // 
            this.nbiDanhSachPhieuCongNo.Caption = "Danh Sách Phiếu Công Nợ";
            this.nbiDanhSachPhieuCongNo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDanhSachPhieuCongNo.ImageOptions.LargeImage")));
            this.nbiDanhSachPhieuCongNo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDanhSachPhieuCongNo.ImageOptions.SmallImage")));
            this.nbiDanhSachPhieuCongNo.Name = "nbiDanhSachPhieuCongNo";
            this.nbiDanhSachPhieuCongNo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDanhSachPhieuCongNo_LinkClicked);
            // 
            // nbiDanhSachPhieuTraNgay
            // 
            this.nbiDanhSachPhieuTraNgay.Caption = "Danh Sách Phiếu Trả Ngay";
            this.nbiDanhSachPhieuTraNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDanhSachPhieuTraNgay.ImageOptions.LargeImage")));
            this.nbiDanhSachPhieuTraNgay.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDanhSachPhieuTraNgay.ImageOptions.SmallImage")));
            this.nbiDanhSachPhieuTraNgay.Name = "nbiDanhSachPhieuTraNgay";
            this.nbiDanhSachPhieuTraNgay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDanhSachPhieuTraNgay_LinkClicked);
            // 
            // nbiTheoDoiCongNo
            // 
            this.nbiTheoDoiCongNo.Caption = "Theo Dõi Công Nợ";
            this.nbiTheoDoiCongNo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoDoiCongNo.ImageOptions.LargeImage")));
            this.nbiTheoDoiCongNo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoDoiCongNo.ImageOptions.SmallImage")));
            this.nbiTheoDoiCongNo.Name = "nbiTheoDoiCongNo";
            this.nbiTheoDoiCongNo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTheoDoiCongNo_LinkClicked);
            // 
            // nbiTongHopCongNo
            // 
            this.nbiTongHopCongNo.Caption = "Tổng Hợp Công Nợ";
            this.nbiTongHopCongNo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTongHopCongNo.ImageOptions.LargeImage")));
            this.nbiTongHopCongNo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTongHopCongNo.ImageOptions.SmallImage")));
            this.nbiTongHopCongNo.Name = "nbiTongHopCongNo";
            this.nbiTongHopCongNo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTongHopCongNo_LinkClicked);
            // 
            // userControl
            // 
            this.userControl.Location = new System.Drawing.Point(252, 42);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(701, 354);
            this.userControl.TabIndex = 1;
            // 
            // frmCollectMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 537);
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmCollectMoney";
            this.Text = "Thu Tiền";
            this.Load += new System.EventHandler(this.frmCollectMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.XtraUserControl userControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiDanhSachPhieuThu;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbiDanhSachPhieuCongNo;
        private DevExpress.XtraNavBar.NavBarItem nbiDanhSachPhieuTraNgay;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoDoiCongNo;
        private DevExpress.XtraNavBar.NavBarItem nbiTongHopCongNo;
    }
}