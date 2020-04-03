namespace QLBH_ProductManagement.GUI
{
    partial class frmWarehouseReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseReport));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiTonKhoTongHop = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiNhapXuatTon = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheKho = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheChiTietHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiLichSuHangHoa = new DevExpress.XtraNavBar.NavBarItem();
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
            this.dockPanel1.ID = new System.Guid("22923d41-b03d-42a9-81c4-6089f66aef4e");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 464);
            this.dockPanel1.Text = "Danh Sách Báo Cáo";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 432);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiTonKhoTongHop,
            this.nbiNhapXuatTon,
            this.nbiTheKho,
            this.nbiTheChiTietHangHoa,
            this.nbiLichSuHangHoa});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 432);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Tồn Kho";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTonKhoTongHop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiNhapXuatTon),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheChiTietHangHoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiLichSuHangHoa)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiTonKhoTongHop
            // 
            this.nbiTonKhoTongHop.Caption = "Tồn Kho Tổng Hợp";
            this.nbiTonKhoTongHop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTonKhoTongHop.ImageOptions.LargeImage")));
            this.nbiTonKhoTongHop.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTonKhoTongHop.ImageOptions.SmallImage")));
            this.nbiTonKhoTongHop.Name = "nbiTonKhoTongHop";
            this.nbiTonKhoTongHop.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTonKhoTongHop_LinkClicked);
            // 
            // nbiNhapXuatTon
            // 
            this.nbiNhapXuatTon.Caption = "Nhập-Xuất-Tồn";
            this.nbiNhapXuatTon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.nbiNhapXuatTon.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.nbiNhapXuatTon.Name = "nbiNhapXuatTon";
            this.nbiNhapXuatTon.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiNhapXuatTon_LinkClicked);
            // 
            // nbiTheKho
            // 
            this.nbiTheKho.Caption = "Thẻ Kho";
            this.nbiTheKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.LargeImage")));
            this.nbiTheKho.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.nbiTheKho.Name = "nbiTheKho";
            this.nbiTheKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTheKho_LinkClicked);
            // 
            // nbiTheChiTietHangHoa
            // 
            this.nbiTheChiTietHangHoa.Caption = "Thẻ Chi Tiết Hàng Hóa";
            this.nbiTheChiTietHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.LargeImage")));
            this.nbiTheChiTietHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.nbiTheChiTietHangHoa.Name = "nbiTheChiTietHangHoa";
            this.nbiTheChiTietHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTheChiTietHangHoa_LinkClicked);
            // 
            // nbiLichSuHangHoa
            // 
            this.nbiLichSuHangHoa.Caption = "Lịch Sử Hàng Hóa";
            this.nbiLichSuHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.LargeImage")));
            this.nbiLichSuHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.SmallImage")));
            this.nbiLichSuHangHoa.Name = "nbiLichSuHangHoa";
            this.nbiLichSuHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiLichSuHangHoa_LinkClicked);
            // 
            // userControl
            // 
            this.userControl.Location = new System.Drawing.Point(339, 58);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(419, 312);
            this.userControl.TabIndex = 1;
            // 
            // frmWarehouseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 464);
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmWarehouseReport";
            this.Text = "Báo Cáo Tổng Hợp Kho";
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
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiTonKhoTongHop;
        private DevExpress.XtraNavBar.NavBarItem nbiNhapXuatTon;
        private DevExpress.XtraNavBar.NavBarItem nbiTheKho;
        private DevExpress.XtraNavBar.NavBarItem nbiTheChiTietHangHoa;
        private DevExpress.XtraNavBar.NavBarItem nbiLichSuHangHoa;
        private DevExpress.XtraEditors.XtraUserControl userControl;
    }
}