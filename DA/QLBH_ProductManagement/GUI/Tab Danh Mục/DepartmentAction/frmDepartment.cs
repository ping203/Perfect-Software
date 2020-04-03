using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using QLBH_ProductManagement.GUI.DepartmentAction;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmDepartment : DevExpress.XtraEditors.XtraForm
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
        string TenChucNang = "Bộ Phận";

        public static int statusAction = 0;

        public frmDepartment(VaiTro_ChucNangDTO phanquyenbp, string username)
        {
            InitializeComponent();

            user = username;

            //radial menu
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenbp != null)
            {
                if (phanquyenbp.Them == 0)
                {
                    btnThem.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyenbp.Xoa == 0)
                {
                    btnDelete.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyenbp.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyenbp.Sua == 0)
                {
                    btnSua.Enabled = false;
                    rdmSua.Enabled = false;
                    gvBoPhan.DoubleClick -= BtnSua_Click;
                }
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UpdateDepartment();
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
        DepartmentBUS departmentBUS = new DepartmentBUS();
        public void LoadDepartment()
        {
            List<DepartmentDTO> list = departmentBUS.getDepartment();
            grcDepartment.DataSource = list;
        }
        private void grcDepartment_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            LoadDepartment();
        }

        public void UpdateDepartment()
        {
            GridView gridView = grcDepartment.FocusedView as GridView;
            DepartmentDTO departmentDTO = new DepartmentDTO();
            departmentDTO.iMaBP = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaBP");
            departmentDTO.iTenBP = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iTenBP");
            departmentDTO.iGhiChu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iGhiChu");
            departmentDTO.iActive = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iActive");

            frmUpdateDepartmentAction frmUpdate = new frmUpdateDepartmentAction(departmentDTO);
            frmUpdate.ShowDialog();

            if (statusAction == 1)
            {
                LoadDepartment();
                statusAction = 0;
            }
            else
            {
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addDepartment = new frmAddDepartment();
            addDepartment.ShowDialog();
            AddNhatKy("Thêm");
            LoadDepartment();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateDepartment();
            AddNhatKy("Cập Nhật");
        }

        private void btnDelete_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcDepartment.FocusedView as GridView;
            var mabp = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaBP");

            int check = departmentBUS.DeleteDepartment((string)mabp);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Success!!!");
                LoadDepartment();
            }
            else
            {
                XtraMessageBox.Show("Fail!!!");
            }
        }

        private void btnReset_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDepartment();
            AddNhatKy("Nạp Lại");
        }

        private void btnClose_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grcDepartment_DoubleClick_1(object sender, EventArgs e)
        {
            UpdateDepartment();
        }

        private void btnXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcDepartment);
            AddNhatKy("Xuất");
        }

        private void gvBoPhan_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmBoPhan.ShowPopup(grcDepartment.PointToScreen(e.Point));
            }
        }

        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addDepartment = new frmAddDepartment();
            addDepartment.ShowDialog();
            AddNhatKy("Thêm");
            LoadDepartment();
        }

        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateDepartment();
            AddNhatKy("Cập Nhật");
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmBoPhan.HidePopup();
        }

        private void rdmXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcDepartment.FocusedView as GridView;
            var mabp = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaBP");

            int check = departmentBUS.DeleteDepartment((string)mabp);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Success!!!");
                LoadDepartment();
            }
            else
            {
                XtraMessageBox.Show("Fail!!!");
            }
        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcDepartment);
            AddNhatKy("Xuất");
        }

        private void gvBoPhan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }
    }
}