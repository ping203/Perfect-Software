using System;
using System.Collections.Generic;

using DevExpress.XtraEditors;


using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraTreeList.Nodes;
using QLBH_ProductManagement.GUI.GoodsAction;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmGoods : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        int CurRowIndex;

        // tên chức năng hiện tại
        string TenChucNang = "Hàng hóa và dịch vụ";

        GroupOfGoodsBUS grGoods = new GroupOfGoodsBUS();
        GoodBUS gBUS = new GoodBUS();
        UnitBUS unitBUS = new UnitBUS();
        WarehouseBUS wareBUS = new WarehouseBUS();
        TonKhoBUS tkBus = new TonKhoBUS();
        public static int statusAction = 0;

        public frmGoods(VaiTro_ChucNangDTO phanquyenHH, string un)
        {
            InitializeComponent();

            user = un;

            rdmHangHoa.AutoExpand = true;
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenHH != null)
            {
                if (phanquyenHH.Them == 0)
                {
                    btnAdd.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyenHH.Xoa == 0)
                {
                    btnDelete.Enabled = false;
                    rdm_Xoa.Enabled = false;
                }
                if (phanquyenHH.Nhap == 0)
                {
                    btnNhap.Enabled = false;
                    rdmNhap.Enabled = false;
                }
                if (phanquyenHH.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyenHH.Sua == 0)
                {
                    btnUpdate.Enabled = false;
                    rdmSua.Enabled = false;
                    grvHangHoaDichVu.DoubleClick -= btnSua_click;
                }
            }
        }

        private void btnSua_click(object sender, EventArgs e)
        {
            update();
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
        public void LoadGood()
        {
            DataTable data = new DataTable();
            data = gBUS.getListGoods();
            grcHH_DV.DataSource = data;

        }
        private void frmGoods_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            LoadGood();
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmAdd = new frmAddGoods();
            frmAdd.ShowDialog();
            AddNhatKy("Thêm");
            LoadGood();
        }

        private void update()
        {
            // GoodDTO goodDTO = new GoodDTO();

            GridView gridView = grcHH_DV.FocusedView as GridView;
            string mabp = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaHang"); // lấy được  mã hàng cần update

            frmUpdateGoods fUpdateGoods = new frmUpdateGoods(mabp);
            fUpdateGoods.ShowDialog();


            LoadGood();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            update();
            AddNhatKy("Cập Nhật");
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridView gridView = grcHH_DV.FocusedView as GridView;
            var maHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaHang");  // lấy được mã hàng

            // nếu mã hàng đã có trong tồn kho với số lượng tồn >= 1 thì hông cho xóa

            int checkTonKho = gBUS.checkMaHangTrongTonKho((string)maHang);
            if (checkTonKho != 1)
            {
                int check = gBUS.DeleteGood((string)maHang);
                int checkXoaTrongKho = tkBus.DeleteTonKhoHaveMaHang((string)maHang);
                if (check == 1 && checkXoaTrongKho == 1)
                {
                    AddNhatKy("Xóa");
                    XtraMessageBox.Show("Success!!!");
                    LoadGood();
                }
                else
                {
                    if (check != 1)
                    {
                        XtraMessageBox.Show("Lỗi xóa trong danh sách hàng hóa!");
                    }
                    if (checkXoaTrongKho != 1)
                    {
                        XtraMessageBox.Show("Lỗi xóa trong kho hàng!");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Mặt hàng " + maHang + " đã thực hiện giao dịch. Không thể xóa!");
            }

        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGood();
            AddNhatKy("Nạp Lại");
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcHH_DV);
            AddNhatKy("Xuất");
        }

        private void rdmThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmAdd = new frmAddGoods();
            frmAdd.ShowDialog();
            AddNhatKy("Thêm");
            LoadGood();
        }

        private void rdmSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            update();
            AddNhatKy("Cập Nhật");
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmHangHoa.HidePopup();
        }

        private void rdm_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridView gridView = grcHH_DV.FocusedView as GridView;
            var maHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaHang");  // lấy được mã hàng

            // nếu mã hàng đã có trong tồn kho với số lượng tồn >= 1 thì hông cho xóa

            int checkTonKho = gBUS.checkMaHangTrongTonKho((string)maHang);
            if (checkTonKho != 1)
            {
                int check = gBUS.DeleteGood((string)maHang);
                int checkXoaTrongKho = tkBus.DeleteTonKhoHaveMaHang((string)maHang);
                if (check == 1 && checkXoaTrongKho == 1)
                {
                    AddNhatKy("Xóa");
                    XtraMessageBox.Show("Success!!!");
                    LoadGood();
                }
                else
                {
                    if (check != 1)
                    {
                        XtraMessageBox.Show("Lỗi xóa trong danh sách hàng hóa!");
                    }
                    if (checkXoaTrongKho != 1)
                    {
                        XtraMessageBox.Show("Lỗi xóa trong kho hàng!");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Mặt hàng " + maHang + " đã thực hiện giao dịch. Không thể xóa!");
            }
        }

        private void grvHangHoaDichVu_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmHangHoa.ShowPopup(grcHH_DV.PointToScreen(e.Point));
            }
        }

        private void grvHangHoaDichVu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void rdmNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcHH_DV);
            AddNhatKy("Xuất");
        }
    }
}