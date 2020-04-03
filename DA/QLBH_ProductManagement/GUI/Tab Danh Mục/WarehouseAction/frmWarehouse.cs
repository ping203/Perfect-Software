using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.WarehouseAction;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;


namespace QLBH_ProductManagement.GUI
{
    public partial class frmWarehouse : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        //chỉ số dòng hiện tại
        int CurRowIndex;

        // tên chức năng hiện tại

        string TenChucNang = "Kho Hàng";
        List<WarehouseDTO> list = new List<WarehouseDTO>();
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        public static int statusAction = 0;

        public frmWarehouse(VaiTro_ChucNangDTO pqkh, string un)
        {
            InitializeComponent();

            user = un;

            //radial menu
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdm_Sua.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqkh != null)
            {
                if (pqkh.Them == 0)
                {
                    btnAdd.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (pqkh.Xoa == 0)
                {
                    btnDelete.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (pqkh.Sua == 0)
                {
                    btnUpdate.Enabled = false;
                    rdm_Sua.Enabled = false;
                    gvKhoHang.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            updateWarehouse();
            AddNhatKy("Cập Nhật");
        }

        private void grcWarehouse_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadWarehouse();
        }
        private void AddNhatKy(string hanhDong)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }
        public void loadWarehouse()
        {
            list = warehouseBUS.getWarehouse();
            grcWarehouse.DataSource = list;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddWarehouse fAddWarehouse = new frmAddWarehouse();
            fAddWarehouse.ShowDialog();

            if (statusAction == 1)
            {
                AddNhatKy("Thêm");
                loadWarehouse();
                statusAction = 0;
            }
            else
            {

            }
        }

        private void updateWarehouse()
        {
            GridView gridView = grcWarehouse.FocusedView as GridView; // 

            WarehouseDTO warehouse = new WarehouseDTO();
            warehouse.iMaKho = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKho");
            warehouse.iTenKho = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iTenKho");
            warehouse.iLienHe = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iGhiChu");
            warehouse.iDiaChi = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iDiaChi");
            warehouse.iDienThoai = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iDienThoai");
            warehouse.iKyHieu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iKyHieu");
            warehouse.iGhiChu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iGhiChu");
            warehouse.iActive = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iActive");

            frmUpdateWarehouse fUpdateWarehouse = new frmUpdateWarehouse(warehouse);
            fUpdateWarehouse.ShowDialog();
            if (statusAction == 1)
            {
                loadWarehouse();
                statusAction = 0;
            }
            else
            {

            }
        }

        private void grcWarehouse_DoubleClick(object sender, EventArgs e)
        {
            updateWarehouse();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcWarehouse.FocusedView as GridView; // 

            string makho;
            makho = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKho");

            int check = warehouseBUS.deleteWarehouse(makho);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Xóa kho hàng thành công!!!");
                loadWarehouse();
            }
            else
            {
                XtraMessageBox.Show("Xóa kho hàng thất bại!!!");
            }
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadWarehouse();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcWarehouse);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog();
            saveFileDialog.ShowDialog();
        }

        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddWarehouse fAddWarehouse = new frmAddWarehouse();
            fAddWarehouse.ShowDialog();

            if (statusAction == 1)
            {
                AddNhatKy("Thêm");
                loadWarehouse();
                statusAction = 0;
            }
            else
            {

            }
        }

        private void rdmXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcWarehouse.FocusedView as GridView; // 

            string makho;
            makho = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKho");

            int check = warehouseBUS.deleteWarehouse(makho);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Xóa thành công!!!");
                loadWarehouse();
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void rdm_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void rdm_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateWarehouse();
            AddNhatKy("Cập Nhật");
        }

        private void gvKhoHang_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmKhoHang.ShowPopup(grcWarehouse.PointToScreen(e.Point));
            }
        }

        private void btnUpdate_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateWarehouse();
            AddNhatKy("Cập Nhật");
        }

        private void gvKhoHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }
    }
}