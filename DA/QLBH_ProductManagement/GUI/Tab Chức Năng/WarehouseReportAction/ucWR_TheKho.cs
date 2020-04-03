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

namespace QLBH_ProductManagement.GUI.WarehouseReportAction
{
    public partial class ucWR_TheKho : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucWR_TheKho()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcTheKho);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcTheKho);
        }
        TheKhoBUS theKhoBUS = new TheKhoBUS();
        private void grcTheKho_Load(object sender, EventArgs e)
        {
            grcTheKho.DataSource = theKhoBUS.getListTheKho();
        }
    }
}
