namespace QLBH_ProductManagement.GUI
{
    partial class frmWarehouseTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseTransfer));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiPhieuChuyenKho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiKhoHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiNhanVien = new DevExpress.XtraNavBar.NavBarItem();
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
            this.dockPanel1.ID = new System.Guid("88e26262-1300-4f7c-bfbe-00d731750a46");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(176, 200);
            this.dockPanel1.Size = new System.Drawing.Size(176, 529);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(169, 497);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiPhieuChuyenKho,
            this.nbiTheoChungTu,
            this.nbiTheoHangHoa,
            this.nbiHangHoa,
            this.nbiKhoHang,
            this.nbiNhanVien});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 169;
            this.navBarControl1.Size = new System.Drawing.Size(169, 497);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Chuyển Kho";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPhieuChuyenKho)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiPhieuChuyenKho
            // 
            this.nbiPhieuChuyenKho.Caption = "Phiếu Chuyển Kho";
            this.nbiPhieuChuyenKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiPhieuChuyenKho.ImageOptions.LargeImage")));
            this.nbiPhieuChuyenKho.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiPhieuChuyenKho.ImageOptions.SmallImage")));
            this.nbiPhieuChuyenKho.Name = "nbiPhieuChuyenKho";
            this.nbiPhieuChuyenKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPhieuChuyenKho_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoChungTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoHangHoa)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiTheoChungTu
            // 
            this.nbiTheoChungTu.Caption = "Theo Chứng Từ";
            this.nbiTheoChungTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoChungTu.ImageOptions.LargeImage")));
            this.nbiTheoChungTu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoChungTu.ImageOptions.SmallImage")));
            this.nbiTheoChungTu.Name = "nbiTheoChungTu";
            this.nbiTheoChungTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTheoChungTu_LinkClicked);
            // 
            // nbiTheoHangHoa
            // 
            this.nbiTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.nbiTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoHangHoa.ImageOptions.LargeImage")));
            this.nbiTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoHangHoa.ImageOptions.SmallImage")));
            this.nbiTheoHangHoa.Name = "nbiTheoHangHoa";
            this.nbiTheoHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTheoHangHoa_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Thêm Danh Mục";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiHangHoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiKhoHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiNhanVien)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // nbiHangHoa
            // 
            this.nbiHangHoa.Caption = "Hàng Hóa";
            this.nbiHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiHangHoa.ImageOptions.LargeImage")));
            this.nbiHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiHangHoa.ImageOptions.SmallImage")));
            this.nbiHangHoa.Name = "nbiHangHoa";
            this.nbiHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiHangHoa_LinkClicked);
            // 
            // nbiKhoHang
            // 
            this.nbiKhoHang.Caption = "Kho Hàng";
            this.nbiKhoHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiKhoHang.ImageOptions.LargeImage")));
            this.nbiKhoHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiKhoHang.ImageOptions.SmallImage")));
            this.nbiKhoHang.Name = "nbiKhoHang";
            this.nbiKhoHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiKhoHang_LinkClicked);
            // 
            // nbiNhanVien
            // 
            this.nbiNhanVien.Caption = "Nhân Viên";
            this.nbiNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiNhanVien.ImageOptions.LargeImage")));
            this.nbiNhanVien.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiNhanVien.ImageOptions.SmallImage")));
            this.nbiNhanVien.Name = "nbiNhanVien";
            this.nbiNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiNhanVien_LinkClicked);
            // 
            // userControl
            // 
            this.userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl.Location = new System.Drawing.Point(176, 0);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(1143, 529);
            this.userControl.TabIndex = 4;
            // 
            // frmWarehouseTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 529);
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmWarehouseTransfer";
            this.Text = "Chuyển Kho";
            this.Load += new System.EventHandler(this.frmWarehouseTransfer_Load);
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
        private DevExpress.XtraNavBar.NavBarItem nbiPhieuChuyenKho;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoChungTu;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem nbiHangHoa;
        private DevExpress.XtraNavBar.NavBarItem nbiKhoHang;
        private DevExpress.XtraNavBar.NavBarItem nbiNhanVien;
        private DevExpress.XtraEditors.XtraUserControl userControl;
    }
}