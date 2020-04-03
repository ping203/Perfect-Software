using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class ucPay_DanhSachPhieuCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucPay_DanhSachPhieuCongNo()
        {
            InitializeComponent();
        }

        private void btnLapPhieuChi_Click(object sender, EventArgs e)
        {

            GridView gridView = grcDanhSachCongNoPhaiChi.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");// lấy được mã phiếu
            var ngayLap = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgayLap");
            var tenNCC = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenNCC");
            var maNCC = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC");
            var soTien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TongTienTra");

            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
            }
            else
            {
                PhieuChiTien phieuChi = new PhieuChiTien();
                phieuChi.MaChungTu = (string)maPhieu;
                phieuChi.NgayLap = (DateTime)ngayLap;
                phieuChi.SoTien = (float)Convert.ToDouble(soTien);
                phieuChi.TenNCC = (string)tenNCC;
                phieuChi.MaNCC = (string)maNCC;
                frmPay_LapPhieuChi fCM_LapPhieuChi = new frmPay_LapPhieuChi(phieuChi);
                fCM_LapPhieuChi.ShowDialog();

                grcDanhSachCongNoPhaiChi.DataSource = inforBuy.getListInforDetailBuyConNo();

            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcDanhSachCongNoPhaiChi);
        }
        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();
        DetailBuyGoodsBUS detailBus = new DetailBuyGoodsBUS();

        List<DetailBuyGoods> listChiTiet = new List<DetailBuyGoods>();

        public void loadInforDetailBuy()
        {
            grcDanhSachCongNoPhaiChi.DataSource = inforBuy.getListInforDetailBuyConNo();

            listChiTiet = detailBus.getListChiTietHoaDonMuaHang();


        }
        private void grcDanhSachCongNoPhaiChi_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            loadInforDetailBuy();
        }

        private void grvCongNo_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailBuy infor = grv.GetRow(e.RowHandle) as InforDetailBuy;

            if (infor != null)
            {
                e.IsEmpty = !listChiTiet.Any(x => x.MaPhieu == infor.MaPhieu);

            }
        }

        private void grvCongNo_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailBuy infor = grv.GetRow(e.RowHandle) as InforDetailBuy;


            e.ChildList = listChiTiet.Where(x => x.MaPhieu == infor.MaPhieu).ToList();
        }

        private void grvCongNo_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
          
            e.RelationCount = 1;
        }

        private void grvCongNo_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ChiTietCongNoMua";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));


            grcDanhSachCongNoPhaiChi.DataSource = inforBuy.getListInforDetailBuyConNoFromNgay(dateTu, dateDen);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
