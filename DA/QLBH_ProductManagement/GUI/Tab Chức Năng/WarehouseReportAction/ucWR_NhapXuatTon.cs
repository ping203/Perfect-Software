using System;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using System.Web.UI.WebControls;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.WarehouseReportAction
{
    public partial class ucWR_NhapXuatTon : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucWR_NhapXuatTon()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcTongHopNhapXuatTon);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcTongHopNhapXuatTon);
        }
        NhapXuatTonBUS nhapXuatTon = new NhapXuatTonBUS();
        private void grcTongHopNhapXuatTon_Load(object sender, EventArgs e)
        {
            //grvNhapXuatTon.OptionsView.AllowCellMerge = !grvNhapXuatTon.OptionsView.AllowCellMerge;

            loadKhoHang();
            grcTongHopNhapXuatTon.DataSource = nhapXuatTon.getListNhapXuatTon(0, "");

        }
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        public void loadKhoHang()
        {
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
                grcTongHopNhapXuatTon.DataSource = nhapXuatTon.getListNhapXuatTon(0, "");
            }
            else
            {
                grcTongHopNhapXuatTon.DataSource = nhapXuatTon.getListNhapXuatTon(1, maKho);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
