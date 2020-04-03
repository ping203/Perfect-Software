using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.GUI.CurrencyAction;
using DevExpress.XtraGrid.Views.Grid;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmCurency : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Tỷ Giá";

        public frmCurency(VaiTro_ChucNangDTO phanquyentg, string un)
        {
            InitializeComponent();

            user = un;

            //radial menu
            rdmSua.CloseRadialMenuOnItemClick = true;
            rdmThem.CloseRadialMenuOnItemClick = true;
            rdmXoa.CloseRadialMenuOnItemClick = true;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyentg != null)
            {
                if (phanquyentg.Them == 0)
                {
                    btnThem.Enabled = false;
                    rdmThem.Enabled = false;
                }
                if (phanquyentg.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    rdmXoa.Enabled = false;
                }
                if (phanquyentg.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                    rdmXuat.Enabled = false;
                }
                if (phanquyentg.Sua == 0)
                {
                    btnSua.Enabled = false;
                    rdmSua.Enabled = false;
                    gvTyGia.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        CurrencyBUS ratesBUS = new CurrencyBUS();

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

        private void grcRates_Load(object sender, EventArgs e)
        {            
            List<CurrencyDTO> list = ratesBUS.getRates();
            grcTienTe.DataSource = list;
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcTienTe);
            AddNhatKy("Xuất");
        }

        private void rdmDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmTyGia.HidePopup();
        }

        private void frmCurency_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
        }

        private void rdmXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcTienTe);
            AddNhatKy("Xuất");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmAadd = new frmAddCurrent();
            frmAadd.ShowDialog();
            grcTienTe.DataSource = ratesBUS.getRates();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcTienTe.FocusedView as GridView;
            string maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaTT").ToString();

            var frmUpdateCurentcy = new frmUpdateCurrent(maPhieu);
            frmUpdateCurentcy.ShowDialog();

            grcTienTe.DataSource = ratesBUS.getRates();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcTienTe.FocusedView as GridView;
            string maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaTT").ToString();

            int check = ratesBUS.Delete(maPhieu);
            if (check == 1)
            {
                XtraMessageBox.Show("Xóa thành công");

                grcTienTe.DataSource = ratesBUS.getRates();
            }
            else
            {
                XtraMessageBox.Show("Xóa Thất Bại");
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void btnNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<CurrencyDTO> list = ratesBUS.getRates();
            grcTienTe.DataSource = list;
        }
    }
}