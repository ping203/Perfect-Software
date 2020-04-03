using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class ucPay_DanhSachPhieuTraNgay : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();
        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();

        public ucPay_DanhSachPhieuTraNgay()
        {
            InitializeComponent();
        }
        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        private void btnLapPhieuChi_Click(object sender, EventArgs e)
        {
            GridView gridView = grcBangKePhieuThanhToanNgay.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");// lấy được mã phiếu
            var ngayLap = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgayLap");
            var tenNCC = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenNCC");
            var maNCC = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNCC");
            var soTien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TongTienTra");

            int checkInPhieuChi = inforBuy.checkMaChungTuInPhieuChi((string)maPhieu);

            if (checkInPhieuChi == 1)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Đơn hàng đã được chi tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maPhieu == null)
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

                grcBangKePhieuThanhToanNgay.DataSource = inforBuy.getListMuaTraNgay(a, a, 0);
            }

            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBangKePhieuThanhToanNgay);
        }
        
        private void grcBangKePhieuThanhToanNgay_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            
            grcBangKePhieuThanhToanNgay.DataSource = inforBuy.getListMuaTraNgay(a, a, 0);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));
            grcBangKePhieuThanhToanNgay.DataSource = inforBuy.getListMuaTraNgay(dateTu, dateDen, 1);
        }
    }
}
