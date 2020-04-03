using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraTreeList.Nodes;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraTreeList;
using System.Windows.Forms;
using QLBH_ProductManagement.GUI.CustomerAction;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using DevExpress.XtraGrid.Views.Grid;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Khách Hàng";

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public frmCustomer(VaiTro_ChucNangDTO phanquyenKH, string un)
        {
            InitializeComponent();

            user = un;

            //radial menu
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            if (phanquyenKH != null)
            {
                if (phanquyenKH.Them == 0)
                {
                    barAdd.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyenKH.Xoa == 0)
                {
                    barDel.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyenKH.Nhap == 0)
                {
                    barImport.Enabled = false;
                    rdmNhap.Enabled = false;
                }
                if (phanquyenKH.Xuat == 0)
                {
                    btnExport.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyenKH.Sua == 0)
                {
                    barEdit.Enabled = false;
                    rdmSua.Enabled = false;
                   // treeListKH.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            // lấy ra dòng được chọn:

            //var nodes = treeListKH.Selection;
            //string id;
            //foreach (TreeListNode node in nodes)
            //{
            //    id = (string)node.GetValue("MaKH"); // lấy được mã khách hàng
            //    cusDTO = cusBUS.getInforCustomer(id);

            //}
            //var frmUpdateCus = new frmUpdateCustomer(cusDTO);
            //frmUpdateCus.ShowDialog();
            //treeListKH.ClearNodes();
            //AddNhatKy("Cập Nhật");
            //LoadKhachHang();
        }

        KhuVucBUS khuVucBus = new KhuVucBUS();
        CustomerBUS cusBUS = new CustomerBUS();

        CustomerDTO cusDTO = new CustomerDTO();
        public void LoadKhachHang()
        {

            grcKhachHang.DataSource = cusBUS.getCusDatatableWithKV();

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
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            LoadKhachHang();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridView gridView = grcKhachHang.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaKH"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã khách hàng cần xóa");
            }
            else
            {
                int check = cusBUS.DeleteKhachHang(mabp);
                if (check == 1)
                {
                    AddNhatKy("Xóa");
                    XtraMessageBox.Show("Delete thành công");
                    LoadKhachHang();
                }
                else
                    XtraMessageBox.Show("Delete thất bại");
            }

        }

        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addCus = new frmAddCustomer();
            addCus.ShowDialog();
            AddNhatKy("Thêm");
            LoadKhachHang();
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // lấy ra dòng được chọn:

            GridView gridView = grcKhachHang.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaKH"); // lấy được  mã hàng cần update
            if(mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã khách hàng cần sửa");
            }
            else
            {
                cusDTO = cusBUS.getInforCustomer(mabp);
                var frmUpdateCus = new frmUpdateCustomer(cusDTO);
                frmUpdateCus.ShowDialog();
               
                AddNhatKy("Cập Nhật");
                LoadKhachHang();
            }

        }

        private void barReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            AddNhatKy("Nạp lại");
            LoadKhachHang();
        }

        private void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addCus = new frmAddCustomer();
            addCus.ShowDialog();
            AddNhatKy("Thêm");
            LoadKhachHang();
        }

        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcKhachHang.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaKH"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã khách hàng cần sửa");
            }
            else
            {
                cusDTO = cusBUS.getInforCustomer(mabp);
                var frmUpdateCus = new frmUpdateCustomer(cusDTO);
                frmUpdateCus.ShowDialog();

                AddNhatKy("Cập Nhật");
                LoadKhachHang();
            }
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmKhachHang.HidePopup();
        }
        
        private void rdmXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcKhachHang.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaKH"); // lấy được  mã hàng cần update
            if (mabp == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã khách hàng cần xóa");
            }
            else
            {
                int check = cusBUS.DeleteKhachHang(mabp);
                if (check == 1)
                {
                    AddNhatKy("Xóa");
                    XtraMessageBox.Show("Delete thành công");
                    LoadKhachHang();
                }
                else
                    XtraMessageBox.Show("Delete thất bại");
            }
        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcKhachHang);
            AddNhatKy("Xuất");
        }

        private void rdmNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcKhachHang);
            AddNhatKy("Xuất");
        }

        private void grcKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void gvKhachHang_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmKhachHang.ShowPopup(grcKhachHang.PointToScreen(e.Point));
            }
        }

        private void gvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }
    }
}