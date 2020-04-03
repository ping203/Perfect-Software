using System;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraEditors;
using System.Data;

namespace QLBH_ProductManagement.GUI.CollectMoneyAction
{
    public partial class ucCM_TheoDoiCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucCM_TheoDoiCongNo()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcDSChiTiet);
        }
        BangTheoDoiCongNoBUS theoDoiBUS = new BangTheoDoiCongNoBUS();

        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));


        private void grcBangTheoDoiCongNo_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");

            grcBangTheoDoiCongNo.DataSource = theoDoiBUS.getListBangTheoDoiCongNo(a, a, 0);

            // load Khách hàng

            cbKhachHang.Properties.DataSource = theoDoiBUS.getKhachHangMua();

            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";
            cbKhachHang.ItemIndex = 1;
        }

        DetailSellGoodsBUS detailSellBus = new DetailSellGoodsBUS();

        public void loadCT_PhieuXuat()
        {
            grcDSChiTiet.DataSource = detailSellBus.getCTPhieuXuat();
        }

        private void grcDSChiTiet_Load(object sender, EventArgs e)
        {
            loadCT_PhieuXuat(); 
        }

        private void cbKhachHang_EditValueChanged(object sender, EventArgs e)
        {
           var id =  cbKhachHang.EditValue != null ? cbKhachHang.EditValue.ToString() : null;
            txtMa.Text = id;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));
            string maKH = txtMa.Text;
            string tabName = xtraTabControl1.SelectedTabPage.Name;
            if(tabName == "BangCongNo")
            {
               
                if (maKH != "All")
                {
                    grcBangTheoDoiCongNo.DataSource = theoDoiBUS.getListBangTheoDoiTheoNhomKH(maKH, dateTu, dateDen, 1);
                }
                else
                {
                    grcBangTheoDoiCongNo.DataSource = theoDoiBUS.getListBangTheoDoiCongNo(dateTu, dateTu, 0);
                }
            }
            else
            {
                if (maKH != "All") // load
                {
                    grcDSChiTiet.DataSource = detailSellBus.getCTPhieuXuatTheoKhachHang(maKH, dateTu, dateDen, 0);
                }
                else
                {
                    grcDSChiTiet.DataSource = detailSellBus.getCTPhieuXuatTheoKhachHang(maKH, dateTu, dateDen, 1);
                }
            } 
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đã In ngoài tiệm photo");
        }
    }
}
