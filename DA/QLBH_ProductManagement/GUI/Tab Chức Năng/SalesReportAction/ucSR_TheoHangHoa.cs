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
    public partial class ucSR_TheoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSR_TheoHangHoa()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoLoiNhuanTheoHangHoa);
        }
        BaoCaoTheoChungTuBUS baoCao = new BaoCaoTheoChungTuBUS();
        WarehouseBUS warehouseBUS = new WarehouseBUS();

        private void grcBaoCaoLoiNhuanTheoHangHoa_Load(object sender, EventArgs e)
        {
            grcBaoCaoLoiNhuanTheoHangHoa.DataSource = baoCao.getListBaoCaoTheoHangHoa(0, "");

            cbKhoHang.Properties.DataSource = warehouseBUS.getKho();
            cbKhoHang.Properties.DisplayMember = "iTenKho";
            cbKhoHang.Properties.ValueMember = "iMaKho";
            cbKhoHang.ItemIndex = 0;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            var maKho = cbKhoHang.EditValue != null ? cbKhoHang.EditValue.ToString() : null;
            if (maKho == "All")
            {
                grcBaoCaoLoiNhuanTheoHangHoa.DataSource = baoCao.getListBaoCaoTheoHangHoa(0, "");
            }
            else
            {
                grcBaoCaoLoiNhuanTheoHangHoa.DataSource = baoCao.getListBaoCaoTheoHangHoa(1, maKho);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
