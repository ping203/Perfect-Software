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

namespace QLBH_ProductManagement.GUI.WarehouseReportAction
{
    public partial class ucWR_SoChiTietHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucWR_SoChiTietHangHoa()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcSoChiTietHangHoa);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcSoChiTietHangHoa);
        }
    }
}
