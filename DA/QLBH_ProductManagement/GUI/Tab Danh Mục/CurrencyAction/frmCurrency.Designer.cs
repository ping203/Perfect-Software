namespace QLBH_ProductManagement.GUI
{
    partial class frmCurency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurency));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.rdmThem = new DevExpress.XtraBars.BarButtonItem();
            this.rdmSua = new DevExpress.XtraBars.BarButtonItem();
            this.rdmDong = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXoa = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXuat = new DevExpress.XtraBars.BarButtonItem();
            this.grcTienTe = new DevExpress.XtraGrid.GridControl();
            this.gvTyGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TGQD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdmTyGia = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTienTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTyGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmTyGia)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnNapLai,
            this.btnXuat,
            this.btnDong,
            this.rdmThem,
            this.rdmSua,
            this.rdmDong,
            this.rdmXoa,
            this.rdmXuat});
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa Chữa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "Nạp Lại";
            this.btnNapLai.Id = 3;
            this.btnNapLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapLai_ItemClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất";
            this.btnXuat.Id = 4;
            this.btnXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuat.ImageOptions.SvgImage")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(823, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(823, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 381);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(823, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 381);
            // 
            // rdmThem
            // 
            this.rdmThem.Caption = "Thêm";
            this.rdmThem.Id = 6;
            this.rdmThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.Image")));
            this.rdmThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.LargeImage")));
            this.rdmThem.Name = "rdmThem";
            // 
            // rdmSua
            // 
            this.rdmSua.Caption = "Sửa";
            this.rdmSua.Id = 7;
            this.rdmSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.Image")));
            this.rdmSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.LargeImage")));
            this.rdmSua.Name = "rdmSua";
            // 
            // rdmDong
            // 
            this.rdmDong.Caption = "Đóng";
            this.rdmDong.Id = 8;
            this.rdmDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmDong.ImageOptions.Image")));
            this.rdmDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmDong.ImageOptions.LargeImage")));
            this.rdmDong.Name = "rdmDong";
            this.rdmDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmDong_ItemClick);
            // 
            // rdmXoa
            // 
            this.rdmXoa.Caption = "Xóa";
            this.rdmXoa.Id = 9;
            this.rdmXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.Image")));
            this.rdmXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.LargeImage")));
            this.rdmXoa.Name = "rdmXoa";
            // 
            // rdmXuat
            // 
            this.rdmXuat.Caption = "Xuất";
            this.rdmXuat.Id = 10;
            this.rdmXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXuat.ImageOptions.Image")));
            this.rdmXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXuat.ImageOptions.LargeImage")));
            this.rdmXuat.Name = "rdmXuat";
            this.rdmXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmXuat_ItemClick);
            // 
            // grcTienTe
            // 
            this.grcTienTe.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.grcTienTe.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grcTienTe.Location = new System.Drawing.Point(0, 26);
            this.grcTienTe.MainView = this.gvTyGia;
            this.grcTienTe.Name = "grcTienTe";
            this.grcTienTe.Size = new System.Drawing.Size(823, 381);
            this.grcTienTe.TabIndex = 27;
            this.grcTienTe.UseEmbeddedNavigator = true;
            this.grcTienTe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTyGia});
            this.grcTienTe.Load += new System.EventHandler(this.grcRates_Load);
            // 
            // gvTyGia
            // 
            this.gvTyGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTT,
            this.TenTT,
            this.TGQD,
            this.Active,
            this.gridColumn1});
            this.gvTyGia.GridControl = this.grcTienTe;
            this.gvTyGia.Name = "gvTyGia";
            this.gvTyGia.OptionsView.ShowGroupPanel = false;
            // 
            // MaTT
            // 
            this.MaTT.Caption = "Mã";
            this.MaTT.FieldName = "iMaTT";
            this.MaTT.Name = "MaTT";
            this.MaTT.Visible = true;
            this.MaTT.VisibleIndex = 0;
            this.MaTT.Width = 219;
            // 
            // TenTT
            // 
            this.TenTT.Caption = "Tên";
            this.TenTT.FieldName = "iTenTT";
            this.TenTT.Name = "TenTT";
            this.TenTT.Visible = true;
            this.TenTT.VisibleIndex = 1;
            this.TenTT.Width = 205;
            // 
            // TGQD
            // 
            this.TGQD.Caption = "Tỷ Giá Quy Đổi";
            this.TGQD.FieldName = "iTGQD";
            this.TGQD.Name = "TGQD";
            this.TGQD.Visible = true;
            this.TGQD.VisibleIndex = 2;
            this.TGQD.Width = 205;
            // 
            // Active
            // 
            this.Active.Caption = "Còn Quản Lý";
            this.Active.FieldName = "iActive";
            this.Active.Name = "Active";
            this.Active.Visible = true;
            this.Active.VisibleIndex = 3;
            this.Active.Width = 213;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 86;
            // 
            // rdmTyGia
            // 
            this.rdmTyGia.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXuat)});
            this.rdmTyGia.Manager = this.barManager1;
            this.rdmTyGia.Name = "rdmTyGia";
            // 
            // frmCurency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 407);
            this.Controls.Add(this.grcTienTe);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCurency";
            this.Text = "Tiền Tệ";
            this.Load += new System.EventHandler(this.frmCurency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTienTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTyGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmTyGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraGrid.GridControl grcTienTe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn MaTT;
        private DevExpress.XtraGrid.Columns.GridColumn TenTT;
        private DevExpress.XtraGrid.Columns.GridColumn TGQD;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarButtonItem rdmThem;
        private DevExpress.XtraBars.BarButtonItem rdmSua;
        private DevExpress.XtraBars.BarButtonItem rdmDong;
        private DevExpress.XtraBars.BarButtonItem rdmXoa;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmTyGia;
        private DevExpress.XtraBars.BarButtonItem rdmXuat;
    }
}