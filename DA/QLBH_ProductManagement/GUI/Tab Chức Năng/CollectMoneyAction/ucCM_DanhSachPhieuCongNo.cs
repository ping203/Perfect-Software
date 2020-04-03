using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace QLBH_ProductManagement.GUI.CollectMoneyAction
{
    public partial class ucCM_DanhSachPhieuCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();
        InforSellBUS inforSell = new InforSellBUS();
        DetailSellGoodsBUS detailSell = new DetailSellGoodsBUS();
        public ucCM_DanhSachPhieuCongNo()
        {
            InitializeComponent();
        }

        List<DetailSellGoods> listDetailSellGoods = new List<DetailSellGoods>();
        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBangKeThanhToanNgay);
        }

        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        private void grcDanhSachCongNoChiTiet_Load(object sender, EventArgs e)
        {
             dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            // load các thông tin đơn hàng theo nợ:
            grcBangKeThanhToanNgay.DataSource = inforSell.getListThanhToanCongNo(a, b, 0);


            // load chi tiết:
            listDetailSellGoods = detailSell.getListChiTietMuaCongNo();

            grvChiTietCongNo.OptionsView.AllowCellMerge = !grvChiTietCongNo.OptionsView.AllowCellMerge;
        }

        private void grvCongNo_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailSell infor = grv.GetRow(e.RowHandle) as InforDetailSell;

            if (infor != null)
            {
                e.IsEmpty = !listDetailSellGoods.Any(x => x.MaPhieuXuat == infor.MaPhieu);
            }
        }

        private void grvCongNo_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailSell infor = grv.GetRow(e.RowHandle) as InforDetailSell;


            e.ChildList = listDetailSellGoods.Where(x => x.MaPhieuXuat == infor.MaPhieu).ToList();
        }

        private void grvCongNo_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvCongNo_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ChiTietCongNo";
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            GridView gridView = grcBangKeThanhToanNgay.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");// lấy được mã phiếu
            var ngayLap = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgayLap");
            var tenKhachHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenKH");
            var maKhachHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaKH");
            var soTien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TongTienNhan");
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần lập phiếu thu tiền");
            }
            else
            {
                PhieuThuTien phieuThu = new PhieuThuTien();
                phieuThu.MaChungTu = (string)maPhieu;
                phieuThu.NgayLap = (DateTime)ngayLap;
                phieuThu.SoTien = (float)Convert.ToDouble(soTien);
                phieuThu.TenKH = (string)tenKhachHang;
                phieuThu.MaKH = (string)maKhachHang;
                frmCM_LapPhieuThu fCM_LapPhieuThu = new frmCM_LapPhieuThu(phieuThu);
                fCM_LapPhieuThu.ShowDialog();

                grcBangKeThanhToanNgay.DataSource = inforSell.getListThanhToanCongNo(a, b, 0);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            grcBangKeThanhToanNgay.DataSource = inforSell.getListThanhToanCongNo(dateTu, dateDen, 1);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
