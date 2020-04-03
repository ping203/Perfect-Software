using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    public partial class ucSR_DoanhSoTheoNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSR_DoanhSoTheoNhanVien()
        {
            InitializeComponent();
        }
       
        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoDoanhSoTheoNhanVien);
        }
        TheoHangHoaBuyBUS theoHangHoaBUS = new TheoHangHoaBuyBUS();
        List<TheoHangHoaBuy> listTheoHangHoaBuy = new List<TheoHangHoaBuy>();
        EmployeesBUS employeesBUS = new EmployeesBUS();


        private void grcBaoCaoDoanhSoTheoNhanVien_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");

            
            listTheoHangHoaBuy = theoHangHoaBUS.getChiTietHoangHoaBuy();

            grcBaoCaoDoanhSoTheoNhanVien.DataSource = employeesBUS.getEmployeesMuaBan();

        }

        private void grvNhanVien_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            EmployeesDTO infor = grv.GetRow(e.RowHandle) as EmployeesDTO;

            if (infor != null)
            {
                e.IsEmpty = !listTheoHangHoaBuy.Any(x => x.MaNV == infor.iMaNV);

            }
        }

        private void grvNhanVien_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            EmployeesDTO infor = grv.GetRow(e.RowHandle) as EmployeesDTO;
            e.ChildList = listTheoHangHoaBuy.Where(x => x.MaNV == infor.iMaNV).ToList();
        }

        private void grvNhanVien_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvNhanVien_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ChiTietMuaBan";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));
            grcBaoCaoDoanhSoTheoNhanVien.DataSource = employeesBUS.getEmployeesMuaBan();
            listTheoHangHoaBuy = theoHangHoaBUS.getChiTietHoangHoaBuyFromDate(dateTu, dateDen);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
