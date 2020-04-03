namespace QLBH_ProductManagement.GUI
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barImport = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.rdmThem = new DevExpress.XtraBars.BarButtonItem();
            this.rdmSua = new DevExpress.XtraBars.BarButtonItem();
            this.rdmDong = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXoa = new DevExpress.XtraBars.BarButtonItem();
            this.rdm_Dong = new DevExpress.XtraBars.BarButtonItem();
            this.rdm_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.grcWarehouse = new DevExpress.XtraGrid.GridControl();
            this.gvKhoHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdmKhoHang = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmKhoHang)).BeginInit();
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
            this.barImport,
            this.btnClose,
            this.rdmThem,
            this.rdmSua,
            this.rdmDong,
            this.rdmXoa,
            this.rdm_Dong,
            this.rdm_Sua});
            this.barManager1.MaxItemId = 13;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(282, 129);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barImport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick_1);
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
            // barImport
            // 
            this.barImport.Caption = "Nhập";
            this.barImport.Id = 5;
            this.barImport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barImport.ImageOptions.SvgImage")));
            this.barImport.Name = "barImport";
            this.barImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barImport_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(807, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 382);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(807, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 356);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(807, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 356);
            // 
            // rdmThem
            // 
            this.rdmThem.Caption = "Thêm";
            this.rdmThem.Id = 7;
            this.rdmThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.Image")));
            this.rdmThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.LargeImage")));
            this.rdmThem.Name = "rdmThem";
            this.rdmThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmThem_ItemClick);
            // 
            // rdmSua
            // 
            this.rdmSua.Caption = "Sửa";
            this.rdmSua.Id = 8;
            this.rdmSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.Image")));
            this.rdmSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.LargeImage")));
            this.rdmSua.Name = "rdmSua";
            // 
            // rdmDong
            // 
            this.rdmDong.Caption = "Đóng";
            this.rdmDong.Id = 9;
            this.rdmDong.Name = "rdmDong";
            // 
            // rdmXoa
            // 
            this.rdmXoa.Caption = "Xóa";
            this.rdmXoa.Id = 10;
            this.rdmXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.Image")));
            this.rdmXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.LargeImage")));
            this.rdmXoa.Name = "rdmXoa";
            this.rdmXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmXoa_ItemClick);
            // 
            // rdm_Dong
            // 
            this.rdm_Dong.Caption = "Đóng";
            this.rdm_Dong.Id = 11;
            this.rdm_Dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdm_Dong.ImageOptions.Image")));
            this.rdm_Dong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdm_Dong.ImageOptions.LargeImage")));
            this.rdm_Dong.Name = "rdm_Dong";
            this.rdm_Dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdm_Dong_ItemClick);
            // 
            // rdm_Sua
            // 
            this.rdm_Sua.Caption = "Sửa";
            this.rdm_Sua.Id = 12;
            this.rdm_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdm_Sua.ImageOptions.Image")));
            this.rdm_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdm_Sua.ImageOptions.LargeImage")));
            this.rdm_Sua.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.rdm_Sua.Name = "rdm_Sua";
            this.rdm_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdm_Sua_ItemClick);
            // 
            // grcWarehouse
            // 
            this.grcWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grcWarehouse.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grcWarehouse.Location = new System.Drawing.Point(0, 26);
            this.grcWarehouse.MainView = this.gvKhoHang;
            this.grcWarehouse.Name = "grcWarehouse";
            this.grcWarehouse.Size = new System.Drawing.Size(807, 356);
            this.grcWarehouse.TabIndex = 26;
            this.grcWarehouse.UseEmbeddedNavigator = true;
            this.grcWarehouse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoHang});
            this.grcWarehouse.Load += new System.EventHandler(this.grcWarehouse_Load);
            this.grcWarehouse.DoubleClick += new System.EventHandler(this.grcWarehouse_DoubleClick);
            // 
            // gvKhoHang
            // 
            this.gvKhoHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKho,
            this.TenKho,
            this.GhiChu,
            this.Active,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvKhoHang.GridControl = this.grcWarehouse;
            this.gvKhoHang.Name = "gvKhoHang";
            this.gvKhoHang.OptionsView.ShowGroupPanel = false;
            this.gvKhoHang.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvKhoHang_PopupMenuShowing);
            this.gvKhoHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhoHang_FocusedRowChanged);
            // 
            // MaKho
            // 
            this.MaKho.Caption = "Mã";
            this.MaKho.FieldName = "iMaKho";
            this.MaKho.Name = "MaKho";
            this.MaKho.OptionsColumn.AllowEdit = false;
            this.MaKho.Visible = true;
            this.MaKho.VisibleIndex = 0;
            this.MaKho.Width = 98;
            // 
            // TenKho
            // 
            this.TenKho.Caption = "Tên";
            this.TenKho.FieldName = "iTenKho";
            this.TenKho.Name = "TenKho";
            this.TenKho.OptionsColumn.AllowEdit = false;
            this.TenKho.Visible = true;
            this.TenKho.VisibleIndex = 1;
            this.TenKho.Width = 96;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Điện Thoại";
            this.GhiChu.FieldName = "iDienThoai";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.OptionsColumn.AllowEdit = false;
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 4;
            this.GhiChu.Width = 125;
            // 
            // Active
            // 
            this.Active.Caption = "Còn Quản Lý";
            this.Active.FieldName = "iActive";
            this.Active.Name = "Active";
            this.Active.OptionsColumn.AllowEdit = false;
            this.Active.Visible = true;
            this.Active.VisibleIndex = 7;
            this.Active.Width = 99;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ký Hiệu";
            this.gridColumn2.FieldName = "iKyHieu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 99;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa Chỉ";
            this.gridColumn3.FieldName = "iDiaChi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 89;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ghi Chú";
            this.gridColumn4.FieldName = "iGhiChu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Liên Hệ";
            this.gridColumn5.FieldName = "iLienHe";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 88;
            // 
            // rdmKhoHang
            // 
            this.rdmKhoHang.AutoExpand = true;
            this.rdmKhoHang.InnerRadius = 0;
            this.rdmKhoHang.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmKhoHang.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdm_Dong),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdm_Sua)});
            this.rdmKhoHang.Manager = this.barManager1;
            this.rdmKhoHang.MenuRadius = 127;
            this.rdmKhoHang.Name = "rdmKhoHang";
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 382);
            this.Controls.Add(this.grcWarehouse);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmWarehouse";
            this.Text = "Kho Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmKhoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem barImport;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.GridControl grcWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaKho;
        private DevExpress.XtraGrid.Columns.GridColumn TenKho;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraBars.BarButtonItem rdmThem;
        private DevExpress.XtraBars.BarButtonItem rdmSua;
        private DevExpress.XtraBars.BarButtonItem rdmDong;
        private DevExpress.XtraBars.BarButtonItem rdmXoa;
        private DevExpress.XtraBars.BarButtonItem rdm_Dong;
        private DevExpress.XtraBars.BarButtonItem rdm_Sua;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmKhoHang;
    }
}