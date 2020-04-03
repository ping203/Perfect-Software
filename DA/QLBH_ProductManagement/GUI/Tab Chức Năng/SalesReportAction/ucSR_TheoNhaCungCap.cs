using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI;
using QLBH_ProductManagement.GUI.PayAction;
using QLBH_ProductManagement.GUI.SalesReportAction;
using QLBH_ProductManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    public partial class ucSR_TheoNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSR_TheoNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoChiPhiMuaHangTheoNhaCungCap);
        }
        SupplierBUS ncc = new SupplierBUS();
        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();
        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        List<InforDetailBuy> listInforBuy;

        private void grcBaoCaoChiPhiMuaHangTheoNhaCungCap_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            grcBaoCaoChiPhiMuaHangTheoNhaCungCap.DataSource = ncc.getListNCCMuaHang(0, a,a);

            listInforBuy = inforBuy.getListInforDetailBuy(a, a, 0);


        }

        private void grvNCC_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            SupplierDTO infor = grv.GetRow(e.RowHandle) as SupplierDTO;

            if (infor != null)
            {
                e.IsEmpty = !listInforBuy.Any(x => x.MaNCC == infor.MaNCC);

            }
        }

        private void grvNCC_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            SupplierDTO infor = grv.GetRow(e.RowHandle) as SupplierDTO;
            e.ChildList = listInforBuy.Where(x => x.MaNCC == infor.MaNCC).ToList();
        }

        private void grvNCC_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvNCC_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ListInforBuy";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            grcBaoCaoChiPhiMuaHangTheoNhaCungCap.DataSource = ncc.getListNCCMuaHang(1, dateTu, dateDen);
            listInforBuy = inforBuy.getListInforDetailBuy(dateTu, dateDen, 1);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
