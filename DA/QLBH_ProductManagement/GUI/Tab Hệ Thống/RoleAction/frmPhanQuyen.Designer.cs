namespace QLBH_ProductManagement.GUI.RoleAction
{
    partial class frmPQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPQ));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctmsPhanQuyen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThemND = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDong = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNguoiDung = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemVaiTro = new DevExpress.XtraEditors.SimpleButton();
            this.tvVaiTroNguoiDung = new System.Windows.Forms.TreeView();
            this.tlBPQ = new DevExpress.XtraTreeList.TreeList();
            this.colTenChucNang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTatCa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTruyCap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colThem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInAn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNhap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXuat = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcdsUser = new DevExpress.XtraGrid.GridControl();
            this.gvDsUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVaiTro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.ctmsPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlBPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // separatorControl2
            // 
            this.separatorControl2.AutoSizeMode = true;
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(420, 191);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(20, 35);
            this.separatorControl2.TabIndex = 22;
            // 
            // ctmsPhanQuyen
            // 
            this.ctmsPhanQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThemVT,
            this.tsmiThemND,
            this.toolStripSeparator1,
            this.tsmiSua,
            this.tsmiXoa,
            this.tsmiDong});
            this.ctmsPhanQuyen.Name = "ctmsPhanQuyen";
            this.ctmsPhanQuyen.Size = new System.Drawing.Size(173, 120);
            // 
            // tsmiThemVT
            // 
            this.tsmiThemVT.Image = ((System.Drawing.Image)(resources.GetObject("tsmiThemVT.Image")));
            this.tsmiThemVT.Name = "tsmiThemVT";
            this.tsmiThemVT.Size = new System.Drawing.Size(172, 22);
            this.tsmiThemVT.Text = "Thêm Vai Trò";
            // 
            // tsmiThemND
            // 
            this.tsmiThemND.Image = ((System.Drawing.Image)(resources.GetObject("tsmiThemND.Image")));
            this.tsmiThemND.Name = "tsmiThemND";
            this.tsmiThemND.Size = new System.Drawing.Size(172, 22);
            this.tsmiThemND.Text = "Thêm Người Dùng";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmiSua
            // 
            this.tsmiSua.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSua.Image")));
            this.tsmiSua.Name = "tsmiSua";
            this.tsmiSua.Size = new System.Drawing.Size(172, 22);
            this.tsmiSua.Text = "Sửa";
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmiXoa.Image")));
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(172, 22);
            this.tsmiXoa.Text = "Xóa";
            // 
            // tsmiDong
            // 
            this.tsmiDong.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDong.Image")));
            this.tsmiDong.Name = "tsmiDong";
            this.tsmiDong.Size = new System.Drawing.Size(172, 22);
            this.tsmiDong.Text = "Đóng";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDong);
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Controls.Add(this.btnSua);
            this.layoutControl1.Controls.Add(this.btnThemNguoiDung);
            this.layoutControl1.Controls.Add(this.btnThemVaiTro);
            this.layoutControl1.Controls.Add(this.tvVaiTroNguoiDung);
            this.layoutControl1.Controls.Add(this.tlBPQ);
            this.layoutControl1.Controls.Add(this.gcdsUser);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1001, 463);
            this.layoutControl1.TabIndex = 26;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(394, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDong.Size = new System.Drawing.Size(54, 22);
            this.btnDong.StyleController = this.layoutControl1;
            this.btnDong.TabIndex = 40;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(326, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoa.Size = new System.Drawing.Size(46, 22);
            this.btnXoa.StyleController = this.layoutControl1;
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(257, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSua.Size = new System.Drawing.Size(47, 22);
            this.btnSua.StyleController = this.layoutControl1;
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguoiDung.ImageOptions.Image")));
            this.btnThemNguoiDung.Location = new System.Drawing.Point(122, 7);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemNguoiDung.Size = new System.Drawing.Size(113, 22);
            this.btnThemNguoiDung.StyleController = this.layoutControl1;
            this.btnThemNguoiDung.TabIndex = 34;
            this.btnThemNguoiDung.Text = "Thêm Người Dùng";
            // 
            // btnThemVaiTro
            // 
            this.btnThemVaiTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaiTro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaiTro.ImageOptions.Image")));
            this.btnThemVaiTro.Location = new System.Drawing.Point(12, 7);
            this.btnThemVaiTro.Name = "btnThemVaiTro";
            this.btnThemVaiTro.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemVaiTro.Size = new System.Drawing.Size(90, 22);
            this.btnThemVaiTro.StyleController = this.layoutControl1;
            this.btnThemVaiTro.TabIndex = 33;
            this.btnThemVaiTro.Text = "Thêm Vai Trò";
            // 
            // tvVaiTroNguoiDung
            // 
            this.tvVaiTroNguoiDung.Location = new System.Drawing.Point(4, 36);
            this.tvVaiTroNguoiDung.Name = "tvVaiTroNguoiDung";
            this.tvVaiTroNguoiDung.Size = new System.Drawing.Size(192, 423);
            this.tvVaiTroNguoiDung.TabIndex = 32;
            // 
            // tlBPQ
            // 
            this.tlBPQ.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTenChucNang,
            this.colTatCa,
            this.colTruyCap,
            this.colThem,
            this.colXoa,
            this.colSua,
            this.colInAn,
            this.colNhap,
            this.colXuat});
            this.tlBPQ.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tlBPQ.DataMember = "FillBPQ";
            this.tlBPQ.Location = new System.Drawing.Point(200, 249);
            this.tlBPQ.Name = "tlBPQ";
            this.tlBPQ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.tlBPQ.Size = new System.Drawing.Size(797, 210);
            this.tlBPQ.TabIndex = 31;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.Caption = "Tên Chức Năng";
            this.colTenChucNang.FieldName = "TenChucNang";
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.Visible = true;
            this.colTenChucNang.VisibleIndex = 0;
            this.colTenChucNang.Width = 127;
            // 
            // colTatCa
            // 
            this.colTatCa.Caption = "Tất Cả";
            this.colTatCa.FieldName = "TatCa";
            this.colTatCa.Name = "colTatCa";
            this.colTatCa.Visible = true;
            this.colTatCa.VisibleIndex = 2;
            this.colTatCa.Width = 68;
            // 
            // colTruyCap
            // 
            this.colTruyCap.Caption = "Truy Cập";
            this.colTruyCap.FieldName = "TruyCap";
            this.colTruyCap.Name = "colTruyCap";
            this.colTruyCap.Visible = true;
            this.colTruyCap.VisibleIndex = 4;
            this.colTruyCap.Width = 79;
            // 
            // colThem
            // 
            this.colThem.Caption = "Thêm";
            this.colThem.FieldName = "Them";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 6;
            this.colThem.Width = 67;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.FieldName = "Xoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 8;
            this.colXoa.Width = 67;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.FieldName = "Sua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 7;
            this.colSua.Width = 78;
            // 
            // colInAn
            // 
            this.colInAn.Caption = "In Ấn";
            this.colInAn.FieldName = "InAn";
            this.colInAn.Name = "colInAn";
            this.colInAn.Visible = true;
            this.colInAn.VisibleIndex = 5;
            this.colInAn.Width = 73;
            // 
            // colNhap
            // 
            this.colNhap.Caption = "Nhập";
            this.colNhap.FieldName = "Nhap";
            this.colNhap.Name = "colNhap";
            this.colNhap.Visible = true;
            this.colNhap.VisibleIndex = 3;
            this.colNhap.Width = 76;
            // 
            // colXuat
            // 
            this.colXuat.Caption = "Xuất";
            this.colXuat.FieldName = "Xuat";
            this.colXuat.Name = "colXuat";
            this.colXuat.Visible = true;
            this.colXuat.VisibleIndex = 1;
            this.colXuat.Width = 46;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // gcdsUser
            // 
            this.gcdsUser.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            gridLevelNode1.RelationName = "Level1";
            this.gcdsUser.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcdsUser.Location = new System.Drawing.Point(200, 36);
            this.gcdsUser.MainView = this.gvDsUser;
            this.gcdsUser.Name = "gcdsUser";
            this.gcdsUser.Size = new System.Drawing.Size(797, 209);
            this.gcdsUser.TabIndex = 30;
            this.gcdsUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDsUser});
            // 
            // gvDsUser
            // 
            this.gvDsUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colVaiTro,
            this.colDienGiai,
            this.colConQuanLy});
            this.gvDsUser.GridControl = this.gcdsUser;
            this.gvDsUser.Name = "gvDsUser";
            this.gvDsUser.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDsUser.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDsUser.OptionsDetail.ShowDetailTabs = false;
            this.gvDsUser.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Caption = "Tên đăng nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.OptionsColumn.AllowEdit = false;
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colVaiTro
            // 
            this.colVaiTro.Caption = "Vai Trò";
            this.colVaiTro.FieldName = "TenVaiTro";
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.OptionsColumn.AllowEdit = false;
            this.colVaiTro.Visible = true;
            this.colVaiTro.VisibleIndex = 1;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Diễn Giả";
            this.colDienGiai.FieldName = "DienGiai";
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.OptionsColumn.AllowEdit = false;
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 2;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Kích Hoạt";
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem8,
            this.layoutControlItem4,
            this.simpleSeparator2,
            this.simpleSeparator1,
            this.simpleSeparator3,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1001, 463);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tvVaiTroNguoiDung;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(196, 427);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcdsUser;
            this.layoutControlItem3.Location = new System.Drawing.Point(196, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(801, 213);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnThemNguoiDung;
            this.layoutControlItem10.Location = new System.Drawing.Point(110, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.layoutControlItem10.Size = new System.Drawing.Size(133, 32);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSua;
            this.layoutControlItem9.Location = new System.Drawing.Point(245, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.layoutControlItem9.Size = new System.Drawing.Size(67, 32);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnThemVaiTro;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.layoutControlItem11.Size = new System.Drawing.Size(110, 32);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnXoa;
            this.layoutControlItem8.Location = new System.Drawing.Point(314, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.layoutControlItem8.Size = new System.Drawing.Size(66, 32);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDong;
            this.layoutControlItem4.Location = new System.Drawing.Point(382, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(74, 32);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(243, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 32);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(312, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 32);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(380, 0);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(2, 32);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(456, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(541, 32);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tlBPQ;
            this.layoutControlItem2.Location = new System.Drawing.Point(196, 245);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(801, 214);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmPQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 463);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.separatorControl2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmPQ";
            this.Text = "Phân Quyền";
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ctmsPhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlBPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.ContextMenuStrip ctmsPhanQuyen;
        private System.Windows.Forms.ToolStripMenuItem tsmiThemVT;
        private System.Windows.Forms.ToolStripMenuItem tsmiThemND;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSua;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiDong;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemNguoiDung;
        private DevExpress.XtraEditors.SimpleButton btnThemVaiTro;
        private System.Windows.Forms.TreeView tvVaiTroNguoiDung;
        private DevExpress.XtraTreeList.TreeList tlBPQ;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenChucNang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTatCa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTruyCap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInAn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNhap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gcdsUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDsUser;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colVaiTro;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}