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
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    public partial class ucSR_TheoNgay : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSR_TheoNgay()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoChiPhiMuaHangTheoNgay);
        }
        BaoCaoTheoChungTuBUS baoCao = new BaoCaoTheoChungTuBUS();

        private void grcBaoCaoChiPhiMuaHangTheoNgay_Load(object sender, EventArgs e)
        {
            DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

            grcBaoCaoChiPhiMuaHangTheoNgay.DataSource = baoCao.getListBaoCaoTheoNgay(0, a, a);

            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            grcBaoCaoChiPhiMuaHangTheoNgay.DataSource = baoCao.getListBaoCaoTheoNgay(1, dateTu, dateDen);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
