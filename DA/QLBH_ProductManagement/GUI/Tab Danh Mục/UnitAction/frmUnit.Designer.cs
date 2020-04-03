namespace QLBH_ProductManagement.GUI
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.rdmThem = new DevExpress.XtraBars.BarButtonItem();
            this.rdmSua = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXoa = new DevExpress.XtraBars.BarButtonItem();
            this.rdmDong = new DevExpress.XtraBars.BarButtonItem();
            this.grcUnit = new DevExpress.XtraGrid.GridControl();
            this.gvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.rdmDonViTinh = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.rdmXuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdmDonViTinh)).BeginInit();
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
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete,
            this.btnNapLai,
            this.btnXuat,
            this.btnClose,
            this.rdmThem,
            this.rdmSua,
            this.rdmXoa,
            this.rdmDong,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa Chữa";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "Nạp Lại";
            this.btnNapLai.Id = 3;
            this.btnNapLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNapLai.ImageOptions.SvgImage")));
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
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 5;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(845, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 417);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(845, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 391);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(845, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 391);
            // 
            // rdmThem
            // 
            this.rdmThem.Caption = "Thêm";
            this.rdmThem.Id = 6;
            this.rdmThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.Image")));
            this.rdmThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.LargeImage")));
            this.rdmThem.Name = "rdmThem";
            this.rdmThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmThem_ItemClick);
            // 
            // rdmSua
            // 
            this.rdmSua.Caption = "Sửa";
            this.rdmSua.Id = 7;
            this.rdmSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.Image")));
            this.rdmSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.LargeImage")));
            this.rdmSua.Name = "rdmSua";
            this.rdmSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmSua_ItemClick);
            // 
            // rdmXoa
            // 
            this.rdmXoa.Caption = "Xóa";
            this.rdmXoa.Id = 8;
            this.rdmXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.Image")));
            this.rdmXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.LargeImage")));
            this.rdmXoa.Name = "rdmXoa";
            this.rdmXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmXoa_ItemClick);
            // 
            // rdmDong
            // 
            this.rdmDong.Caption = "Đóng";
            this.rdmDong.Id = 9;
            this.rdmDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmDong.ImageOptions.Image")));
            this.rdmDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmDong.ImageOptions.LargeImage")));
            this.rdmDong.Name = "rdmDong";
            this.rdmDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmDong_ItemClick);
            // 
            // grcUnit
            // 
            this.grcUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.grcUnit.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grcUnit.Location = new System.Drawing.Point(0, 0);
            this.grcUnit.MainView = this.gvDonViTinh;
            this.grcUnit.Name = "grcUnit";
            this.grcUnit.Size = new System.Drawing.Size(845, 391);
            this.grcUnit.TabIndex = 27;
            this.grcUnit.UseEmbeddedNavigator = true;
            this.grcUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonViTinh});
            this.grcUnit.Load += new System.EventHandler(this.grcUnit_Load);
            this.grcUnit.DoubleClick += new System.EventHandler(this.grcUnit_DoubleClick);
            // 
            // gvDonViTinh
            // 
            this.gvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDVT,
            this.Ten,
            this.GhiChu,
            this.Active});
            this.gvDonViTinh.GridControl = this.grcUnit;
            this.gvDonViTinh.Name = "gvDonViTinh";
            this.gvDonViTinh.OptionsView.ShowGroupPanel = false;
            this.gvDonViTinh.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvDonViTinh_PopupMenuShowing);
            this.gvDonViTinh.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDonViTinh_FocusedRowChanged);
            // 
            // MaDVT
            // 
            this.MaDVT.Caption = "Mã";
            this.MaDVT.FieldName = "iMaDVT";
            this.MaDVT.Name = "MaDVT";
            this.MaDVT.OptionsColumn.AllowEdit = false;
            this.MaDVT.Visible = true;
            this.MaDVT.VisibleIndex = 0;
            this.MaDVT.Width = 219;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "iTen";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.AllowEdit = false;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 205;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "iGhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowEdit = false;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 2;
            this.GhiChu.Width = 205;
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
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.grcUnit;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 26);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.grcUnit);
            this.gridSplitContainer1.Size = new System.Drawing.Size(845, 391);
            this.gridSplitContainer1.TabIndex = 32;
            // 
            // rdmDonViTinh
            // 
            this.rdmDonViTinh.AutoExpand = true;
            this.rdmDonViTinh.InnerRadius = 0;
            this.rdmDonViTinh.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmDonViTinh.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXuat)});
            this.rdmDonViTinh.Manager = this.barManager1;
            this.rdmDonViTinh.MenuRadius = 127;
            this.rdmDonViTinh.Name = "rdmDonViTinh";
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
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 417);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmUnit";
            this.Text = "Đơn Vị Tính";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdmDonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grcUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn MaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmDonViTinh;
        private DevExpress.XtraBars.BarButtonItem rdmThem;
        private DevExpress.XtraBars.BarButtonItem rdmSua;
        private DevExpress.XtraBars.BarButtonItem rdmXoa;
        private DevExpress.XtraBars.BarButtonItem rdmDong;
        private DevExpress.XtraBars.BarButtonItem rdmXuat;
    }
}