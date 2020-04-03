using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class ucPay_DanhSachPhieuChi : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucPay_DanhSachPhieuChi()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcDanhSachPhieuChi);
        }


        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        
        PhieuChiTienBUS pcTien = new PhieuChiTienBUS();

        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();

        private void grcDanhSachPhieuChi_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            grcDanhSachPhieuChi.DataSource = pcTien.LoadPhieuChiTien(a, a, 0);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grcDanhSachPhieuChi.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuBangKe");// lấy được mã phiếu
            var maChungTu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuChi");// lấy được chứng từ

            if (maPhieu != null && maChungTu != null)
            {
                try
                {
                    inforBuy.UpdateIsCheck((string)maChungTu, 1);

                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi tại update Ischeck mã chững từ:  " + ex.Message);
                }
                try
                {
                    pcTien.DeletePhieuChi((string)maPhieu);

                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi tại Delete Phiếu thu tiền:  " + ex.Message);
                }
                grcDanhSachPhieuChi.DataSource = pcTien.LoadPhieuChiTien(a, a, 0);
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

            grcDanhSachPhieuChi.DataSource = pcTien.LoadPhieuChiTien(dateTu, dateDen, 1);
        }
    }
}
