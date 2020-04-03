using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.CollectMoneyAction
{
    public partial class ucCM_DanhSachPhieuTraNgay : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();
        InforSellBUS inforSellBus = new InforSellBUS();

        public ucCM_DanhSachPhieuTraNgay()
        {
            InitializeComponent();
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            
            GridView gridView = grcBangKeThanhToanNgay.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");// lấy được mã phiếu
            var ngayLap = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgayLap");
            var tenKhachHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenKH");
            var maKhachHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaKH");
            var soTien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TongTienNhan");

            int checkInPhieuThu = inforSellBus.checkMaChungTuInPhieuThu((string)maPhieu);
            
            if (checkInPhieuThu == 1)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Đơn hàng đã được thu tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
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
                grcBangKeThanhToanNgay.DataSource = inforSellBus.getListThanhToanNgay(a, b, 0);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBangKeThanhToanNgay);
        }
     
        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        private void grcBangKeThanhToanNgay_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            // load caác thông tin bán hàng theo từng khác hàng:
            grcBangKeThanhToanNgay.DataSource = inforSellBus.getListThanhToanNgay(a, b, 0);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            grcBangKeThanhToanNgay.DataSource = inforSellBus.getListThanhToanNgay(dateTu, dateDen, 1);
        }
    }
}
