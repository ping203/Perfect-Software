using System;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.WarehouseReportAction
{
    public partial class ucWR_TonKhoTongHop : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucWR_TonKhoTongHop()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcTonKhoTongHop);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcTonKhoTongHop);
        }
        TonKhoTongHopBUS tkTongHopBUS = new TonKhoTongHopBUS();
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        private void grcTonKhoTongHop_Load(object sender, EventArgs e)
        {
            grcTonKhoTongHop.DataSource = tkTongHopBUS.getListTonKhoTongHop(0, "");

            cbKhoHang.Properties.DataSource = warehouseBUS.getKho();
            cbKhoHang.Properties.DisplayMember = "iTenKho";
            cbKhoHang.Properties.ValueMember = "iMaKho";
            cbKhoHang.ItemIndex = 0;

        }

        private void cbKhoHang_EditValueChanged(object sender, EventArgs e)
        {

            var maKho = cbKhoHang.EditValue != null ? cbKhoHang.EditValue.ToString() : null;
            if (maKho == "All")
            {
                grcTonKhoTongHop.DataSource = tkTongHopBUS.getListTonKhoTongHop(0, "");
            }
            else
            {
                grcTonKhoTongHop.DataSource = tkTongHopBUS.getListTonKhoTongHop(1, maKho);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
