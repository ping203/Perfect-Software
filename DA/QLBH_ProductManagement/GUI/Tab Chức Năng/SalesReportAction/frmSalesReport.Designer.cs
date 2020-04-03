namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    partial class frmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnChiPhiMuaHangTheoNgay = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheoNhaCungCap = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDoanhSoTheoNgay = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDoanhSoTheoKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDoanhSoTheoNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDoanhSoTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
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
            this.dockPanel1.ID = new System.Guid("6c1efb32-0045-47d5-adad-b6e318ba6a5f");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(190, 200);
            this.dockPanel1.Size = new System.Drawing.Size(190, 453);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(183, 421);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnChiPhiMuaHangTheoNgay,
            this.nbiTheoNhaCungCap,
            this.nbiDoanhSoTheoNgay,
            this.nbiDoanhSoTheoKhachHang,
            this.nbiTheoChungTu,
            this.nbiTheoHangHoa,
            this.nbiDoanhSoTheoNhanVien,
            this.nbiDoanhSoTheoHangHoa});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 183;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(183, 421);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Chi Phí Mua Hàng";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnChiPhiMuaHangTheoNgay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoNhaCungCap)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnChiPhiMuaHangTheoNgay
            // 
            this.btnChiPhiMuaHangTheoNgay.Caption = "Theo Ngày";
            this.btnChiPhiMuaHangTheoNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChiPhiMuaHangTheoNgay.ImageOptions.LargeImage")));
            this.btnChiPhiMuaHangTheoNgay.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnChiPhiMuaHangTheoNgay.ImageOptions.SmallImage")));
            this.btnChiPhiMuaHangTheoNgay.Name = "btnChiPhiMuaHangTheoNgay";
            this.btnChiPhiMuaHangTheoNgay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiChiPhiMuaHangTheoNgay_LinkClicked);
            // 
            // nbiTheoNhaCungCap
            // 
            this.nbiTheoNhaCungCap.Caption = "Theo Nhà Cung Cấp";
            this.nbiTheoNhaCungCap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoNhaCungCap.ImageOptions.LargeImage")));
            this.nbiTheoNhaCungCap.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoNhaCungCap.ImageOptions.SmallImage")));
            this.nbiTheoNhaCungCap.Name = "nbiTheoNhaCungCap";
            this.nbiTheoNhaCungCap.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTheoNhaCungCap_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Doanh Số Bán Hàng";
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDoanhSoTheoNgay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDoanhSoTheoKhachHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDoanhSoTheoNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDoanhSoTheoHangHoa)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // nbiDoanhSoTheoNgay
            // 
            this.nbiDoanhSoTheoNgay.Caption = "Theo Ngày";
            this.nbiDoanhSoTheoNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoNgay.ImageOptions.LargeImage")));
            this.nbiDoanhSoTheoNgay.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoNgay.ImageOptions.SmallImage")));
            this.nbiDoanhSoTheoNgay.Name = "nbiDoanhSoTheoNgay";
            this.nbiDoanhSoTheoNgay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDoanhSoTheoNgay_LinkClicked);
            // 
            // nbiDoanhSoTheoKhachHang
            // 
            this.nbiDoanhSoTheoKhachHang.Caption = "Theo Khách Hàng";
            this.nbiDoanhSoTheoKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoKhachHang.ImageOptions.LargeImage")));
            this.nbiDoanhSoTheoKhachHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoKhachHang.ImageOptions.SmallImage")));
            this.nbiDoanhSoTheoKhachHang.Name = "nbiDoanhSoTheoKhachHang";
            this.nbiDoanhSoTheoKhachHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDoanhSoTheoKhachHang_LinkClicked);
            // 
            // nbiDoanhSoTheoNhanVien
            // 
            this.nbiDoanhSoTheoNhanVien.Caption = "Theo Nhân Viên";
            this.nbiDoanhSoTheoNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoNhanVien.ImageOptions.LargeImage")));
            this.nbiDoanhSoTheoNhanVien.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoNhanVien.ImageOptions.SmallImage")));
            this.nbiDoanhSoTheoNhanVien.Name = "nbiDoanhSoTheoNhanVien";
            this.nbiDoanhSoTheoNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDoanhSoTheoNhanVien_LinkClicked);
            // 
            // nbiDoanhSoTheoHangHoa
            // 
            this.nbiDoanhSoTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.nbiDoanhSoTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoHangHoa.ImageOptions.LargeImage")));
            this.nbiDoanhSoTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDoanhSoTheoHangHoa.ImageOptions.SmallImage")));
            this.nbiDoanhSoTheoHangHoa.Name = "nbiDoanhSoTheoHangHoa";
            this.nbiDoanhSoTheoHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDoanhSoTheoHangHoa_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Lợi Nhuận";
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoChungTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoHangHoa)});
            this.navBarGroup4.Name = "navBarGroup4";
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
            // userControl
            // 
            this.userControl.Location = new System.Drawing.Point(372, 111);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(278, 245);
            this.userControl.TabIndex = 3;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 453);
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmSalesReport";
            this.Text = "Báo Cáo Bán Hàng";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
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
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem btnChiPhiMuaHangTheoNgay;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoNhaCungCap;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem nbiDoanhSoTheoNgay;
        private DevExpress.XtraNavBar.NavBarItem nbiDoanhSoTheoKhachHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoChungTu;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarItem nbiDoanhSoTheoNhanVien;
        private DevExpress.XtraNavBar.NavBarItem nbiDoanhSoTheoHangHoa;
        private DevExpress.XtraEditors.XtraUserControl userControl;
    }
}