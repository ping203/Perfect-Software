namespace QLBH_ProductManagement.GUI
{
    partial class frmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.rdmThem = new DevExpress.XtraBars.BarButtonItem();
            this.rdmSua = new DevExpress.XtraBars.BarButtonItem();
            this.rdmDong = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXoa = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcArea = new DevExpress.XtraGrid.GridControl();
            this.gvKhuVuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdmKhuVuc = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.rdmXuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmKhuVuc)).BeginInit();
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
            this.barUpdate,
            this.barXoa,
            this.barReset,
            this.btnXuat,
            this.barClose,
            this.barButtonItem7,
            this.btnXoa,
            this.bbiThem,
            this.rdmThem,
            this.rdmSua,
            this.rdmDong,
            this.rdmXoa,
            this.rdmXuat});
            this.barManager1.MaxItemId = 14;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            // 
            // barUpdate
            // 
            this.barUpdate.Caption = "Sửa Chữa";
            this.barUpdate.Id = 1;
            this.barUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUpdate.ImageOptions.Image")));
            this.barUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUpdate.ImageOptions.LargeImage")));
            this.barUpdate.Name = "barUpdate";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 7;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // barReset
            // 
            this.barReset.Caption = "Nạp Lại";
            this.barReset.Id = 3;
            this.barReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barReset.ImageOptions.Image")));
            this.barReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barReset.ImageOptions.LargeImage")));
            this.barReset.Name = "barReset";
            this.barReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barReset_ItemClick_1);
            // 
            // btnXuat
            // 
            this.btnXuat.ActAsDropDown = true;
            this.btnXuat.Caption = "Xuất";
            this.btnXuat.CloseRadialMenuOnItemClick = true;
            this.btnXuat.Id = 4;
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.LargeImage")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick_1);
            // 
            // barClose
            // 
            this.barClose.Caption = "Đóng";
            this.barClose.Id = 5;
            this.barClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barClose.ImageOptions.Image")));
            this.barClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barClose.ImageOptions.LargeImage")));
            this.barClose.Name = "barClose";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseBorderColor = true;
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(947, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 410);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(947, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(947, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
            // 
            // barXoa
            // 
            this.barXoa.Caption = "Xóa";
            this.barXoa.Id = 2;
            this.barXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barXoa.ImageOptions.Image")));
            this.barXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barXoa.ImageOptions.LargeImage")));
            this.barXoa.Name = "barXoa";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // bbiThem
            // 
            this.bbiThem.Caption = "bbiThem";
            this.bbiThem.Id = 8;
            this.bbiThem.ImageOptions.DisabledImage = ((System.Drawing.Image)(resources.GetObject("bbiThem.ImageOptions.DisabledImage")));
            this.bbiThem.Name = "bbiThem";
            // 
            // rdmThem
            // 
            this.rdmThem.Caption = "Thêm";
            this.rdmThem.Id = 9;
            this.rdmThem.ImageOptions.DisabledImage = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.DisabledImage")));
            this.rdmThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.Image")));
            this.rdmThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmThem.ImageOptions.LargeImage")));
            this.rdmThem.Name = "rdmThem";
            // 
            // rdmSua
            // 
            this.rdmSua.Caption = "Sửa";
            this.rdmSua.Id = 10;
            this.rdmSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.Image")));
            this.rdmSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmSua.ImageOptions.LargeImage")));
            this.rdmSua.Name = "rdmSua";
            // 
            // rdmDong
            // 
            this.rdmDong.Caption = "Đóng";
            this.rdmDong.Id = 11;
            this.rdmDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmDong.ImageOptions.Image")));
            this.rdmDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmDong.ImageOptions.LargeImage")));
            this.rdmDong.Name = "rdmDong";
            // 
            // rdmXoa
            // 
            this.rdmXoa.Caption = "Xóa";
            this.rdmXoa.Id = 12;
            this.rdmXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.Image")));
            this.rdmXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.LargeImage")));
            this.rdmXoa.Name = "rdmXoa";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(947, 384);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grcArea
            // 
            this.grcArea.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.grcArea.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grcArea.Location = new System.Drawing.Point(0, 26);
            this.grcArea.MainView = this.gvKhuVuc;
            this.grcArea.Name = "grcArea";
            this.grcArea.Size = new System.Drawing.Size(947, 384);
            this.grcArea.TabIndex = 27;
            this.grcArea.UseEmbeddedNavigator = true;
            this.grcArea.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhuVuc});
            // 
            // gvKhuVuc
            // 
            this.gvKhuVuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvKhuVuc.GridControl = this.grcArea;
            this.gvKhuVuc.Name = "gvKhuVuc";
            this.gvKhuVuc.OptionsView.ShowGroupPanel = false;
            this.gvKhuVuc.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvKhuVuc_PopupMenuShowing);
            this.gvKhuVuc.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvKhuVuc_ShowingEditor);
            this.gvKhuVuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhuVuc_FocusedRowChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã";
            this.gridColumn2.FieldName = "iMaKV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên";
            this.gridColumn3.FieldName = "iTenKV";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ghi Chú";
            this.gridColumn4.FieldName = "iGhiChu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Còn Quản Lý";
            this.gridColumn5.FieldName = "iActive";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // rdmKhuVuc
            // 
            this.rdmKhuVuc.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXuat)});
            this.rdmKhuVuc.Manager = this.barManager1;
            this.rdmKhuVuc.Name = "rdmKhuVuc";
            // 
            // rdmXuat
            // 
            this.rdmXuat.Caption = "Xuất";
            this.rdmXuat.Id = 13;
            this.rdmXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXuat.ImageOptions.Image")));
            this.rdmXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXuat.ImageOptions.LargeImage")));
            this.rdmXuat.Name = "rdmXuat";
            this.rdmXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmXuat_ItemClick);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 410);
            this.Controls.Add(this.grcArea);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmArea";
            this.Text = "Khu Vực";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmKhuVuc)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem barUpdate;
        private DevExpress.XtraBars.BarButtonItem barXoa;
        private DevExpress.XtraBars.BarButtonItem barReset;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem barClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraGrid.GridControl grcArea;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private DevExpress.XtraBars.BarButtonItem rdmThem;
        private DevExpress.XtraBars.BarButtonItem rdmSua;
        private DevExpress.XtraBars.BarButtonItem rdmDong;
        private DevExpress.XtraBars.BarButtonItem rdmXoa;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmKhuVuc;
        private DevExpress.XtraBars.BarButtonItem rdmXuat;
    }
}