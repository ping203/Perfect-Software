using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.GUI.GroupOfGoodsAction;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmGroupOfGoods : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        //chỉ số dòng hiện tại
        int CurRowIndex;

        // tên chức năng hiện tại
        string TenChucNang = "Nhóm Hàng";

        public static int statusAction = 0;
        NhomHangBUS nhBUS = new NhomHangBUS();

        public frmGroupOfGoods(VaiTro_ChucNangDTO phanquyennh, string un)
        {
            InitializeComponent();

            user = un;

            //radial menu
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdm_Xoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyennh != null)
            {
                if (phanquyennh.Them == 0)
                {
                    btnAdd.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyennh.Xoa == 0)
                {
                    btnDelete.Enabled = false;
                    rdm_Xoa.Enabled = false;
                }
                if (phanquyennh.Nhap == 0)
                {
                    btnNhap.Enabled = false;
                    rdmNhap.Enabled = false;
                }
                if (phanquyennh.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyennh.Sua == 0)
                {
                    btnUpdate.Enabled = false;
                    rdmSua.Enabled = false;
                    gvNhomHang.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UpdateNhomHang();
            AddNhatKy("Cập Nhật");
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
        public void reFeshListNhomHang()
        {
            List<NhomHang> list = nhBUS.getListNhomHang();
            grcNhomHang.DataSource = list;
        }

        private void frmGroupOfGoods_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            reFeshListNhomHang();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gv = grcNhomHang.MainView as GridView;
            var index = gv.FocusedRowHandle;
            var cellValue = gv.GetRowCellValue(index, "maNhomHang");
            int check = nhBUS.DeleteNhomHang((string)cellValue);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Xóa thành công");
                reFeshListNhomHang();
            }
            else
                XtraMessageBox.Show("Xóa thất bại");
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addDepartment = new frmAddGroupOfGoods();
            addDepartment.ShowDialog();
            LoadGroupOfGoods();
            AddNhatKy("Thêm");
        }

        private void LoadGroupOfGoods()
        {
            List<NhomHang> list = nhBUS.getListNhomHang();
            grcNhomHang.DataSource = list;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateNhomHang();
            AddNhatKy("Cập Nhật");
        }

        private void UpdateNhomHang()
        {
            GridView gridView = grcNhomHang.FocusedView as GridView;
            NhomHang nhomHang = new NhomHang();
            nhomHang.maNhomHang = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "maNhomHang");
            nhomHang.tenNhomHang = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "tenNhomHang");
            nhomHang.ghiChu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "ghiChu");
            nhomHang.kichHoat = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "kichHoat");

            frmUpdateGroupOfGoods frmUpdate = new frmUpdateGroupOfGoods(nhomHang);
            frmUpdate.ShowDialog();

            if (statusAction == 1)
            {
                LoadGroupOfGoods();
                statusAction = 0;
            }
            else
            {
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reFeshListNhomHang();
            AddNhatKy("Nạp Lại");
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcNhomHang);
            AddNhatKy("Xuất");
        }

        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addDepartment = new frmAddGroupOfGoods();
            addDepartment.ShowDialog();
            LoadGroupOfGoods();
            AddNhatKy("Thêm");
        }

        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateNhomHang();
            AddNhatKy("Cập Nhật");
        }

        private void rdm_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gv = grcNhomHang.MainView as GridView;
            var index = gv.FocusedRowHandle;
            var cellValue = gv.GetRowCellValue(index, "maNhomHang");
            int check = nhBUS.DeleteNhomHang((string)cellValue);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Xóa thành công");
                reFeshListNhomHang();
            }
            else
                XtraMessageBox.Show("Xóa thất bại");
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmNhomHang.HidePopup();
        }

        private void rdmNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcNhomHang);
            AddNhatKy("Xuất");
        }

        private void gvNhomHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void gvNhomHang_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmNhomHang.ShowPopup(grcNhomHang.PointToScreen(e.Point));
            }
        }

        private void gvNhomHang_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}