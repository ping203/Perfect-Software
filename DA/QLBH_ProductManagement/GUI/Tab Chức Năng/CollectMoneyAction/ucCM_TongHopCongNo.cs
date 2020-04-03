using System;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.CollectMoneyAction
{
    public partial class ucCM_TongHopCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucCM_TongHopCongNo()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcDanhSachCongNoTongHop);
        }

        BangTheoDoiCongNoBUS congNo = new BangTheoDoiCongNoBUS();
        private void grcDanhSachCongNoTongHop_Load(object sender, EventArgs e)
        {
            grcDanhSachCongNoTongHop.DataSource = congNo.getListCongNoCuaKhachHang();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
