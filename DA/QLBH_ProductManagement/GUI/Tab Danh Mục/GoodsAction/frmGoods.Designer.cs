namespace QLBH_ProductManagement.GUI
{
    partial class frmGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoods));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.rdmThem = new DevExpress.XtraBars.BarButtonItem();
            this.rdmSua = new DevExpress.XtraBars.BarButtonItem();
            this.rdmDong = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXoa = new DevExpress.XtraBars.BarButtonItem();
            this.rdm_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.grcHH_DV = new DevExpress.XtraGrid.GridControl();
            this.grvHangHoaDichVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rdmHangHoa = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.rdmNhap = new DevExpress.XtraBars.BarButtonItem();
            this.rdmXuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHH_DV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHangHoaDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar4});
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
            this.btnNhap,
            this.btnClose,
            this.rdmThem,
            this.rdmSua,
            this.rdmDong,
            this.rdmXoa,
            this.rdm_Xoa,
            this.rdmNhap,
            this.rdmXuat});
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "Tools";
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
            // btnNhap
            // 
            this.btnNhap.Caption = "Nhập";
            this.btnNhap.Id = 5;
            this.btnNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhap.ImageOptions.SvgImage")));
            this.btnNhap.Name = "btnNhap";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 6;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(888, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 402);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(888, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 376);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(888, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 376);
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
            this.rdmSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmSua_ItemClick);
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
            // rdmXoa
            // 
            this.rdmXoa.Caption = "Xóa";
            this.rdmXoa.Id = 10;
            this.rdmXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.Image")));
            this.rdmXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmXoa.ImageOptions.LargeImage")));
            this.rdmXoa.Name = "rdmXoa";
            // 
            // rdm_Xoa
            // 
            this.rdm_Xoa.Caption = "Xóa";
            this.rdm_Xoa.Id = 11;
            this.rdm_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdm_Xoa.ImageOptions.Image")));
            this.rdm_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdm_Xoa.ImageOptions.LargeImage")));
            this.rdm_Xoa.Name = "rdm_Xoa";
            this.rdm_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdm_Xoa_ItemClick);
            // 
            // grcHH_DV
            // 
            this.grcHH_DV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcHH_DV.Location = new System.Drawing.Point(0, 26);
            this.grcHH_DV.MainView = this.grvHangHoaDichVu;
            this.grcHH_DV.MenuManager = this.barManager1;
            this.grcHH_DV.Name = "grcHH_DV";
            this.grcHH_DV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcHH_DV.Size = new System.Drawing.Size(888, 376);
            this.grcHH_DV.TabIndex = 36;
            this.grcHH_DV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHangHoaDichVu});
            // 
            // grvHangHoaDichVu
            // 
            this.grvHangHoaDichVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMah,
            this.colTen,
            this.colDV,
            this.colGM,
            this.colBl,
            this.colBS,
            this.colTT,
            this.colKHo,
            this.colTC,
            this.colNhom,
            this.colAc});
            this.grvHangHoaDichVu.GridControl = this.grcHH_DV;
            this.grvHangHoaDichVu.GroupCount = 1;
            this.grvHangHoaDichVu.Name = "grvHangHoaDichVu";
            this.grvHangHoaDichVu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNhom, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grvHangHoaDichVu.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.grvHangHoaDichVu_PopupMenuShowing);
            this.grvHangHoaDichVu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvHangHoaDichVu_FocusedRowChanged);
            // 
            // colMah
            // 
            this.colMah.Caption = "Mã Hàng";
            this.colMah.FieldName = "MaHang";
            this.colMah.Name = "colMah";
            this.colMah.Visible = true;
            this.colMah.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên Hàng";
            this.colTen.FieldName = "TenHang";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colDV
            // 
            this.colDV.Caption = "Đơn Vị";
            this.colDV.FieldName = "Ten";
            this.colDV.Name = "colDV";
            this.colDV.Visible = true;
            this.colDV.VisibleIndex = 2;
            // 
            // colGM
            // 
            this.colGM.Caption = "Giá Mua";
            this.colGM.FieldName = "GiaMua";
            this.colGM.Name = "colGM";
            this.colGM.Visible = true;
            this.colGM.VisibleIndex = 3;
            // 
            // colBl
            // 
            this.colBl.Caption = "Giá Bán Lẻ";
            this.colBl.FieldName = "GiaBanLe";
            this.colBl.Name = "colBl";
            this.colBl.Visible = true;
            this.colBl.VisibleIndex = 4;
            // 
            // colBS
            // 
            this.colBS.Caption = "Giá Bán Sỉ";
            this.colBS.FieldName = "GiabanSi";
            this.colBS.Name = "colBS";
            this.colBS.Visible = true;
            this.colBS.VisibleIndex = 5;
            // 
            // colTT
            // 
            this.colTT.Caption = "TK Tối Thiểu";
            this.colTT.FieldName = "SoLuongToiThieu";
            this.colTT.Name = "colTT";
            this.colTT.Visible = true;
            this.colTT.VisibleIndex = 6;
            // 
            // colKHo
            // 
            this.colKHo.Caption = "Kho Mặc Định";
            this.colKHo.FieldName = "TenKho";
            this.colKHo.Name = "colKHo";
            this.colKHo.Visible = true;
            this.colKHo.VisibleIndex = 7;
            // 
            // colTC
            // 
            this.colTC.Caption = "Tính Chất";
            this.colTC.FieldName = "TinhChat";
            this.colTC.Name = "colTC";
            this.colTC.Visible = true;
            this.colTC.VisibleIndex = 8;
            // 
            // colNhom
            // 
            this.colNhom.Caption = "Tên Nhóm";
            this.colNhom.FieldName = "TenNhom";
            this.colNhom.Name = "colNhom";
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 9;
            // 
            // colAc
            // 
            this.colAc.Caption = "Active";
            this.colAc.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colAc.FieldName = "Active";
            this.colAc.Name = "colAc";
            this.colAc.Visible = true;
            this.colAc.VisibleIndex = 9;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // rdmHangHoa
            // 
            this.rdmHangHoa.InnerRadius = 0;
            this.rdmHangHoa.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmHangHoa.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdm_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmNhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.rdmXuat)});
            this.rdmHangHoa.Manager = this.barManager1;
            this.rdmHangHoa.MenuRadius = 127;
            this.rdmHangHoa.Name = "rdmHangHoa";
            // 
            // rdmNhap
            // 
            this.rdmNhap.Caption = "Nhập";
            this.rdmNhap.Id = 12;
            this.rdmNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rdmNhap.ImageOptions.Image")));
            this.rdmNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rdmNhap.ImageOptions.LargeImage")));
            this.rdmNhap.Name = "rdmNhap";
            this.rdmNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rdmNhap_ItemClick);
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
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 424);
            this.Controls.Add(this.grcHH_DV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGoods";
            this.Text = "Hàng Hóa & Dịch Vụ";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHH_DV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHangHoaDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnNhap;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.GridControl grcHH_DV;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHangHoaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colMah;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDV;
        private DevExpress.XtraGrid.Columns.GridColumn colGM;
        private DevExpress.XtraGrid.Columns.GridColumn colBl;
        private DevExpress.XtraGrid.Columns.GridColumn colBS;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraGrid.Columns.GridColumn colKHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colAc;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem rdmThem;
        private DevExpress.XtraBars.BarButtonItem rdmSua;
        private DevExpress.XtraBars.BarButtonItem rdmDong;
        private DevExpress.XtraBars.BarButtonItem rdmXoa;
        private DevExpress.XtraBars.BarButtonItem rdm_Xoa;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmHangHoa;
        private DevExpress.XtraBars.BarButtonItem rdmNhap;
        private DevExpress.XtraBars.BarButtonItem rdmXuat;
    }
}