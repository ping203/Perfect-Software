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
using QLBH_ProductManagement.GUI.EmployeesAction;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmEmployees : DevExpress.XtraEditors.XtraForm
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
        string TenChucNang = "Nhân Viên";

        public static int statusAction = 0;
        EmployeesBUS employeesBUS = new EmployeesBUS();

        public frmEmployees(VaiTro_ChucNangDTO phanquyennv, string un)
        {
            InitializeComponent();
            user = un;

            // radial menu
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyennv != null)
            {
                if (phanquyennv.Them == 0)
                {
                    btnThem.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyennv.Xoa == 0)
                {
                    btnDelete.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyennv.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyennv.Sua == 0)
                {
                    btnUpdate.Enabled = false;
                    rdmSua.Enabled = false;
                    gvNhanVien.DoubleClick -= BtnSua_Click;
                }
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UpdateEmployees();
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

        private void grcEmployees_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            List<EmployeesDTO> list = employeesBUS.getEmployees();
            grcEmployees.DataSource = list;
        }

        private void UpdateEmployees()
        {
            GridView gridView = grcEmployees.FocusedView as GridView;

            EmployeesDTO employeesDTO = new EmployeesDTO();
            employeesDTO.iMaNV = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaNV");
            employeesDTO.iTenNV = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iTenNV");
            employeesDTO.iDienThoai = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iDienThoai");
            employeesDTO.iDiaChi = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iDiaChi");
            employeesDTO.iDiDong = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iDiDong");
            employeesDTO.iEmail = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iEmail");
            employeesDTO.iBoPhan = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iBoPhan");
            employeesDTO.iNguoiQL = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iNguoiQL");
            employeesDTO.iActive = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iActive");

            frmUpdateEmployees frmUpdate = new frmUpdateEmployees(employeesDTO);
            frmUpdate.ShowDialog();

            if (statusAction == 1)
            {
                LoadEmployees();
                statusAction = 0;
            }
            else
            {
            }
        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addEmployees = new frmAddEmployees();
            addEmployees.ShowDialog();
            AddNhatKy("Thêm");
            LoadEmployees();
        }

        private void btnUpdate_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateEmployees();
            AddNhatKy("Cập Nhật");
        }

        private void btnDelete_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcEmployees.FocusedView as GridView;
            var mabp = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaNV");

            int check = employeesBUS.DeleteDepartment((string)mabp);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Success!!!");
                LoadEmployees();
            }
            else
            {
                XtraMessageBox.Show("Fail!!!");
            }
        }

        private void btnReset_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadEmployees();
            AddNhatKy("Nạp Lại");
        }

        private void btnClose_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void grcEmployees_DoubleClick_1(object sender, EventArgs e)
        {
            UpdateEmployees();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcEmployees);
            AddNhatKy("Xuất");
        }

        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addEmployees = new frmAddEmployees();
            addEmployees.ShowDialog();
            AddNhatKy("Thêm");
            LoadEmployees();
        }

        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateEmployees();
            AddNhatKy("Cập Nhật");
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmNhanVien.HidePopup();
        }

        private void rdmXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcEmployees.FocusedView as GridView;
            var mabp = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaNV");

            int check = employeesBUS.DeleteDepartment((string)mabp);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Success!!!");
                LoadEmployees();
            }
            else
            {
                XtraMessageBox.Show("Fail!!!");
            }
        }

        private void gvNhanVien_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcEmployees);
            AddNhatKy("Xuất");
        }

        private void gvNhanVien_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmNhanVien.ShowPopup(grcEmployees.PointToScreen(e.Point));
            }
        }
    }
}