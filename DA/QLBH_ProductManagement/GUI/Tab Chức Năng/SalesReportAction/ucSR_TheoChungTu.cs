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

namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    public partial class ucSR_TheoChungTu : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSR_TheoChungTu()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoLoiNhuanTheoChungTu);
        }
        BaoCaoTheoChungTuBUS baoCaoBUS = new BaoCaoTheoChungTuBUS();
        BangTheoDoiCongNoBUS theoDoiBUS = new BangTheoDoiCongNoBUS();
        private void grcBaoCaoLoiNhuanTheoChungTu_Load(object sender, EventArgs e)
        {
            DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
            grcBaoCaoLoiNhuanTheoChungTu.DataSource = baoCaoBUS.getListBaoCao(0, a, a);
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            grcBaoCaoLoiNhuanTheoChungTu.DataSource = baoCaoBUS.getListBaoCao(1, dateTu, dateDen);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
