using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.GUI.SupplierAction;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraTreeList.Nodes;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using DevExpress.XtraGrid.Views.Grid;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        //chỉ số dòng hiện tại
        int CurRowIndex;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Nhà Cung Cấp";

        public frmSupplier(VaiTro_ChucNangDTO phanquyenncc, string un)
        {
            InitializeComponent();

            user = un;

            //radial menu
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenncc != null)
            {
                if (phanquyenncc.Them == 0)
                {
                    barAdd.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyenncc.Xoa == 0)
                {
                    barDel.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyenncc.Nhap == 0)
                {
                    barImport.Enabled = false;
                    rdmNhap.Enabled = false;
                }
                if (phanquyenncc.Xuat == 0)
                {
                    barXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyenncc.Sua == 0)
                {
                    barEdit.Enabled = false;
                    rdmSua.Enabled = false;
                    grcNhaCungCap.DoubleClick -= BtnSua_Click;
                }
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            SupplierDTO supDTO = new SupplierDTO();
            GridView gridView = grcNhaCungCap.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã nhà cung cấp cần sửa");
            }
            else
            {
                supDTO = supplierBUS.getInforSup(mabp);
                var frmUpdateSup = new frmUpdateSupplier(supDTO);
                AddNhatKy("Cập Nhật");
                frmUpdateSup.ShowDialog();
                loadSupplier();
            }

        }

        KhuVucBUS khuVucBus = new KhuVucBUS();
        SupplierBUS supplierBUS = new SupplierBUS();

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

        public void loadSupplier()
        {
            // lấy khu vực
            grcNhaCungCap.DataSource = supplierBUS.getNCCWithNCC();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadSupplier();
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SupplierDTO supDTO = new SupplierDTO();
            GridView gridView = grcNhaCungCap.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã nhà cung cấp cần sửa");
            }
            else
            {
                supDTO = supplierBUS.getInforSup(mabp);
                var frmUpdateSup = new frmUpdateSupplier(supDTO);
                AddNhatKy("Cập Nhật");
                frmUpdateSup.ShowDialog();
                loadSupplier();
            }
        }

        private void barDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SupplierDTO supDTO = new SupplierDTO();
            GridView gridView = grcNhaCungCap.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã nhà cung cấp cần xóa");
            }
            else
            {
                int check = supplierBUS.DeleteSupplierFromNCC(mabp);
                if (check == 1)
                {
                    AddNhatKy("Xóa");
                    XtraMessageBox.Show("Delete thành công");
                    
                    loadSupplier();
                }
                else
                    XtraMessageBox.Show("Delete thất bại");
            }
        }

        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmAdd = new frmAddSupplier();
            frmAdd.ShowDialog();
           
            loadSupplier();
            AddNhatKy("Thêm");
        }

        private void barXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcNhaCungCap);
            AddNhatKy("Xuất");
        }
        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SupplierDTO supDTO = new SupplierDTO();
            GridView gridView = grcNhaCungCap.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã nhà cung cấp cần sửa");
            }
            else
            {
                supDTO = supplierBUS.getInforSup(mabp);
                var frmUpdateSup = new frmUpdateSupplier(supDTO);
                AddNhatKy("Cập Nhật");
                frmUpdateSup.ShowDialog();
                loadSupplier();
            }
        }

        private void rdm_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmAdd = new frmAddSupplier();
            frmAdd.ShowDialog();

            loadSupplier();
            AddNhatKy("Thêm");
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmNhaCC.HidePopup();
        }

        private void rdmXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SupplierDTO supDTO = new SupplierDTO();
            GridView gridView = grcNhaCungCap.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã nhà cung cấp cần xóa");
            }
            else
            {
                int check = supplierBUS.DeleteSupplierFromNCC(mabp);
                if (check == 1)
                {
                    AddNhatKy("Xóa");
                    XtraMessageBox.Show("Delete thành công");

                    loadSupplier();
                }
                else
                    XtraMessageBox.Show("Delete thất bại");
            }
        }

        private void rdmNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcNhaCungCap);
            AddNhatKy("Xuất");
        }

        private void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvNhaCC_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmNhaCC.ShowPopup(grcNhaCungCap.PointToScreen(e.Point));
            }
        }

        private void gvNhaCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }
    }
}