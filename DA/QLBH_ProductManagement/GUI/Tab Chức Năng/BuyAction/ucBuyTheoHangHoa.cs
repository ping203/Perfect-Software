using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraGrid.Views.Grid;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class ucBuyTheoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucBuyTheoHangHoa()
        {
            InitializeComponent();
        }

        TheoHangHoaBuyBUS theoHangHoaBUS = new TheoHangHoaBuyBUS();
        InforDetailBuyBUS inforDetailBuy = new InforDetailBuyBUS();
        DetailBuyGoodsBUS detailBuyBus = new DetailBuyGoodsBUS();

        public void LoadTheoHangHoa()
        {
            List<TheoHangHoaBuy> listTheoHangHoaBuy = new List<TheoHangHoaBuy>();
            listTheoHangHoaBuy = theoHangHoaBUS.getChiTietHoangHoaBuy();
            grvTheoHangHoa.DataSource = listTheoHangHoaBuy;

            loadNCC();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grvTheoHangHoa.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");  // lấy được mã phiếu

            int checkInPhieuChi = inforDetailBuy.checkMaChungTuInPhieuChi((string)maPhieu);

            if (checkInPhieuChi == 1)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Đơn hàng đã được chi tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
            }
            else
            {
                int checkDelInfor = inforDetailBuy.DeleteInforDetailBuy((string)maPhieu);
                int checkDelDetail = detailBuyBus.DeleteDetailBuy((string)maPhieu);
                if (checkDelInfor == 0 || checkDelDetail == 0)
                {
                    XtraMessageBox.Show("Xóa thất bại đơn hàng");
                }
                else
                {
                    XtraMessageBox.Show("Xóa thành công đơn hàng");
                    LoadTheoHangHoa();
                }
            }
        }

        

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grvTheoHangHoa);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grvTheoHangHoa);
        }

        SupplierBUS supBUS = new SupplierBUS();
        public void loadNCC()
        {

            cbNCC.Properties.DataSource = supBUS.getNCCBanHang();
            cbNCC.Properties.DisplayMember = "TenNCC";
            cbNCC.Properties.ValueMember = "MaNCC";
            cbNCC.ItemIndex = 1;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", cbTu.Text));

            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", cbDen.Text));
            var maNCC = cbNCC.EditValue != null ? cbNCC.EditValue.ToString() : null;

            if (maNCC == "All")
            {
                grvTheoHangHoa.DataSource = theoHangHoaBUS.getChiTietHoangHoaBuyFromDate(dateTu, dateDen);
            }
            else
            {
                grvTheoHangHoa.DataSource = theoHangHoaBUS.getChiTietHoangHoaBuyFromDateAndNCC(dateTu, dateDen, maNCC);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public delegate void UpdatePhieuMua(InforDetailBuy inforBuy, List<DetailBuyGoods> list);
        public event UpdatePhieuMua UpdateMuaHang;


        private void btnSuaChua_Click(object sender, EventArgs e)
        {
           
            GridView gridView = grvTheoHangHoa.FocusedView as GridView;

            InforDetailBuy inforBuyGui = new InforDetailBuy();

            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");  // lấy được mã phiếu 
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu cần sửa");
            }
            else
            {
                inforBuyGui.MaPhieu = maPhieu.ToString();

                inforBuyGui = inforDetailBuy.getInforDetailBuyFromMa(maPhieu.ToString());
                List<DetailBuyGoods> listDetailBuyGui = detailBuyBus.getListChiTietHoaDonMuaHangFromMaPhieu(maPhieu.ToString());
                if (UpdateMuaHang != null)
                {
                    UpdateMuaHang(inforBuyGui, listDetailBuyGui);
                }
            }
           
        }

        public delegate void TaoMoi();
        public event TaoMoi TaoMoiHangHoa = null;

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiHangHoa();
        }

        private void grvTheoHangHoa_Load(object sender, EventArgs e)
        {
            cbTu.Text = cbDen.Text = DateTime.Now.ToString("M/d/yyyy");
            LoadTheoHangHoa();
        }
    }
}
