using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.GUI.AreaAction;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using DevExpress.XtraBars;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmArea : DevExpress.XtraEditors.XtraForm
    {
        AreaBUS areaBUS = new AreaBUS();
        BienToanCuc bienToanCuc = new BienToanCuc();

        string user;
        
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog nk);
        public event NhatKyHeThong ThemNhatKyHeThong;

        //chỉ số dòng hiện tại
        int CurRowIndex;

        //Tên chức năng
        string chucnang = "Khu Vực";

        public frmArea(VaiTro_ChucNangDTO phanquyenkv, string username)
        {
            InitializeComponent();

            Load += new EventHandler(FrmArea_Load);

            user = username;

            //sự kiện button
            btnThem.ItemClick += BtnThem_Click;
            barUpdate.ItemClick += BtnSua_Click;
            btnXoa.ItemClick += BtnXoa_Click;

            //button radial menu
            rdmDong.ItemClick += RdmDong_ItemClick;
            rdmThem.ItemClick += BtnThem_Click;
            rdmSua.ItemClick += BtnSua_Click;
            rdmXoa.ItemClick += BtnXoa_Click;

            //radial menu
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            gvKhuVuc.DoubleClick += BtnSua_Click;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenkv != null)
            {
                if (phanquyenkv.Them == 0)
                {
                    btnThem.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyenkv.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyenkv.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyenkv.Sua == 0)
                {
                    barUpdate.Enabled = false;
                    rdmSua.Enabled = false;
                    gvKhuVuc.DoubleClick -= BtnSua_Click;
                }
            }

        }
        private void FrmArea_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadArea();
        }

        private void BtnXoa_Click(object sender, ItemClickEventArgs e)
        {
            GridView gridView = grcArea.FocusedView as GridView;  // ép Gridcontrol về GridView

            var maKV = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKV"); // lấy dữ liêuj

            int check = areaBUS.DeleteArea((string)maKV);
            AddNhatKy("Xóa");
            if (check == 1)
            {
                XtraMessageBox.Show("Xóa thành công");
                loadArea();
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại");
            }
        }
        private void RdmDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmKhuVuc.HidePopup();
        }
        private void BtnThem_Click(object sender, ItemClickEventArgs e)
        {
            var addKhuVuc = new frmAddArea();
            addKhuVuc.ShowDialog();
            AddNhatKy("Thêm");
            loadArea();
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            GridView gridView = grcArea.FocusedView as GridView;  // ép Gridcontrol về GridView
            AreaDTO area = new AreaDTO();
            area.iMaKV = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKV"); // lấy dữ liêuj
            area.iTenKV = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iTenKV");
            area.iGhiChu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iGhiChu");
            area.iActive = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iActive");
            var frmUpdate = new frmUpdateArea(area);
            frmUpdate.ShowDialog();
            AddNhatKy("Cập nhật");
            loadArea();
        }
        public void loadArea()
        {
            List<AreaDTO> list = areaBUS.getArea();
            grcArea.DataSource = list;
        }  
        public void AddNhatKy(string hanhDong)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = chucnang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }
        private void gvKhuVuc_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void gvKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }
        private void gvKhuVuc_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmKhuVuc.ShowPopup(grcArea.PointToScreen(e.Point));
            }
        }
        private void barReset_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            loadArea();
            AddNhatKy("Nạp lại");
        }
        private void btnXuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcArea);
            AddNhatKy("Xuất");
        }

        private void rdmXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcArea);
            AddNhatKy("Xuất");
        }
    }
}