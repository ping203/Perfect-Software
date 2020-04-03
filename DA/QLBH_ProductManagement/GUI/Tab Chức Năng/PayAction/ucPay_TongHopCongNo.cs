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

namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class ucPay_TongHopCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucPay_TongHopCongNo()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcDanhSachCongNoTongHop);
        }
        BangTheoDoiCongNoBUS bangTheoDoiCongNo = new BangTheoDoiCongNoBUS();
        private void grcDanhSachCongNoTongHop_Load(object sender, EventArgs e)
        {
            grcDanhSachCongNoTongHop.DataSource = bangTheoDoiCongNo.getListCongNoNCC();
        }
    }
}
