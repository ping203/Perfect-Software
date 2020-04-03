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
    public partial class ucSR_DoanhSoTheoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSR_DoanhSoTheoHangHoa()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoDanhSoTheoHangHoa);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            

            var maKho = cbKhoHang.EditValue != null ? cbKhoHang.EditValue.ToString() : null;
            if (maKho == "All")
            {
                grcBaoCaoDanhSoTheoHangHoa.DataSource = detailSellBUS.getDataTheoHangHoa(1, dateTu, dateDen);
            }
            else
            {
                grcBaoCaoDanhSoTheoHangHoa.DataSource = detailSellBUS.getDataTheoHangHoaFromMaKho(dateTu, dateDen, maKho);
            }

        }

        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DetailSellGoodsBUS detailSellBUS = new DetailSellGoodsBUS();
        WarehouseBUS warehouseBUS = new WarehouseBUS();

        private void grcBaoCaoDanhSoTheoHangHoa_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            grcBaoCaoDanhSoTheoHangHoa.DataSource = detailSellBUS.getDataTheoHangHoa(0, a, a);

            
            cbKhoHang.Properties.DataSource = warehouseBUS.getKho();
            cbKhoHang.Properties.DisplayMember = "iTenKho";
            cbKhoHang.Properties.ValueMember = "iMaKho";
            cbKhoHang.ItemIndex = 0;
        }
    }
}
