using System;
using System.Collections.Generic;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.UnitAction;
using System.Web.UI.WebControls;
using DevExpress.XtraGrid.Views.Grid;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmUnit : DevExpress.XtraEditors.XtraForm
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
        string TenChucNang = "Đơn Vị Tính";

        public static int statusAction = 0;
        UnitBUS b_unit = new UnitBUS();
        List<UnitDTO> list = new List<UnitDTO>();

        public frmUnit(VaiTro_ChucNangDTO phanquyendvt, string un)
        {
            InitializeComponent();

            user = un;

            //radial menu
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyendvt != null)
            {
                if (phanquyendvt.Them == 0)
                {
                    btnAdd.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyendvt.Xoa == 0)
                {
                    btnDelete.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyendvt.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }

                if (phanquyendvt.Sua == 0)
                {
                    btnUpdate.Enabled = false;
                    rdmSua.Enabled = false;
                    gvDonViTinh.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            updateUnit();
            AddNhatKy("Cập Nhật");
        }

        private void grcUnit_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadUnit();
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
        public void loadUnit()
        {
            list = b_unit.getUnit();
            grcUnit.DataSource = list;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddUnit fUnit = new frmAddUnit();
            fUnit.Owner = this;
            fUnit.ShowDialog();
            if (statusAction == 1)
            {
                AddNhatKy("Thêm");
                loadUnit();
                statusAction = 0;
            }
            else
            {

            }
        }

        public void updateUnit()
        {
            GridView gridView = grcUnit.FocusedView as GridView; // 

            UnitDTO unitDTO = new UnitDTO();
            unitDTO.iMaDVT = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaDVT");
            unitDTO.iTen = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iTen");
            unitDTO.iGhiChu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iGhiChu");
            unitDTO.iActive = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iActive");

            frmUpdateUnit fUnit = new frmUpdateUnit(unitDTO);
            fUnit.ShowDialog();

            if (statusAction == 1)
            {
                loadUnit();
                statusAction = 0;
            }
            else
            {

            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateUnit();
            AddNhatKy("Cập Nhật");
        }


        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcUnit.FocusedView as GridView; // 

            string madvt;
            madvt = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaDVT");

            int check = b_unit.deleteUnit(madvt);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Xóa thành công!!!");
                loadUnit();
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void grcUnit_DoubleClick(object sender, EventArgs e)
        {
            updateUnit();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadUnit();
            AddNhatKy("Nạp Lại");
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcUnit);
            AddNhatKy("Xuất");
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDonViTinh_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmDonViTinh.ShowPopup(grcUnit.PointToScreen(e.Point));
            }
        }

        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddUnit fUnit = new frmAddUnit();
            fUnit.Owner = this;
            fUnit.ShowDialog();
            if (statusAction == 1)
            {
                AddNhatKy("Thêm");
                loadUnit();
                statusAction = 0;
            }
            else
            {

            }
        }

        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateUnit();
            AddNhatKy("Cập Nhật");
        }

        private void rdmXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcUnit.FocusedView as GridView; // 

            string madvt;
            madvt = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaDVT");

            int check = b_unit.deleteUnit(madvt);
            if (check == 1)
            {
                AddNhatKy("Xóa");
                XtraMessageBox.Show("Xóa thành công!!!");
                loadUnit();
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmDonViTinh.HidePopup();
        }

        private void gvDonViTinh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcUnit);
            AddNhatKy("Xuất");
        }
    }
}