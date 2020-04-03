using System;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLBH_ProductManagement.GUI.CollectMoneyAction
{
    public partial class ucCM_DanhSachPhieuThu : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();
        PhieuThuTienBUS ptTienBUS = new PhieuThuTienBUS();

        public ucCM_DanhSachPhieuThu()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcDanhSachPhieuThu);
        }
        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        private void grcDanhSachPhieuThu_Load(object sender, EventArgs e)
        {

            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            

            grcDanhSachPhieuThu.DataSource = ptTienBUS.LoadPhieuThuTien(a, b, 0);
        }
        InforSellBUS inforSell = new InforSellBUS();

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grcDanhSachPhieuThu.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuBangKe");// lấy được mã phiếu
            var maChungTu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuXuat");// lấy được chứng từ

            if(maPhieu != null && maChungTu != null)
            {
                try
                {
                    inforSell.UpdateIsCheck((string)maChungTu, 1);
                    
                }
                catch(SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi tại update Ischeck mã chững từ:  " + ex.Message);
                }
                try
                {
                    ptTienBUS.DeletePhieuThu((string)maPhieu);

                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi tại Delete Phiếu thu tiền:  " + ex.Message);
                }
                grcDanhSachPhieuThu.DataSource = ptTienBUS.LoadPhieuThuTien(a, b, 0);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn mã phiếu cần xóa");
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            grcDanhSachPhieuThu.DataSource = ptTienBUS.LoadPhieuThuTien(dateTu, dateDen, 1);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
