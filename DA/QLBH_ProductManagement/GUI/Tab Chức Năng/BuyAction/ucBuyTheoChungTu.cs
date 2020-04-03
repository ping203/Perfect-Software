using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class ucBuyTheoChungTu : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucBuyTheoChungTu()
        {
            InitializeComponent();
        }
        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();
        DetailBuyGoodsBUS detailBus = new DetailBuyGoodsBUS();

        List<DetailBuyGoods> listChiTiet = new List<DetailBuyGoods>();

        public void loadInforDetailBuy()
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
            DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

            List<InforDetailBuy> data = inforBuy.getListInforDetailBuy(a, b, 0);

            grcChungTu.DataSource = data;
           
            listChiTiet = detailBus.getListChiTietHoaDonMuaHang();

            
        }

        SupplierBUS supBUS = new SupplierBUS();
        public void loadNCC()
        {

            cbNCC.Properties.DataSource = supBUS.getNCCBanHang();
            cbNCC.Properties.DisplayMember = "TenNCC";
            cbNCC.Properties.ValueMember = "MaNCC";
            cbNCC.ItemIndex = 1;
        }

        private void grvChungTu_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {

            GridView grv = sender as GridView;

            InforDetailBuy infor = grv.GetRow(e.RowHandle) as InforDetailBuy;

            if (infor != null)
            {
                e.IsEmpty = !listChiTiet.Any(x => x.MaPhieu == infor.MaPhieu);

            }
        }

        private void grvChungTu_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailBuy infor = grv.GetRow(e.RowHandle) as InforDetailBuy;

            e.ChildList = listChiTiet.Where(x => x.MaPhieu == infor.MaPhieu).ToList();

        }

        private void grvChungTu_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvChungTu_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {

            e.RelationName = "grvChiTietHoaDon";
         
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcChungTu);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcChungTu);
        }

        private void gvcChungTu_Load(object sender, EventArgs e)
        {
            loadInforDetailBuy();
            loadNCC();
        }
        InforDetailBuyBUS inforDetailBuy = new InforDetailBuyBUS();
        DetailBuyGoodsBUS detailBuyBus = new DetailBuyGoodsBUS();

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grcChungTu.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");  // lấy được mã phiếu


            int checkInPhieuChi = inforBuy.checkMaChungTuInPhieuChi((string)maPhieu);

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
                    loadInforDetailBuy();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            var maNCC = cbNCC.EditValue != null ? cbNCC.EditValue.ToString() : null;

            if (maNCC == "All")
            {
                List<InforDetailBuy> data = inforBuy.getListInforDetailBuy(dateTu, dateDen, 1);
                grcChungTu.DataSource = data;
            }
            else
            {
                List<InforDetailBuy> data = inforBuy.getListInforDetailBuyFormMaNCC(dateTu, dateDen, maNCC);
                grcChungTu.DataSource = data;
            }
        }


        public delegate void TaoMoi();
        public event TaoMoi TaoMoiHangHoa = null;

        public delegate void UpdatePhieuMua(InforDetailBuy inforBuy, List<DetailBuyGoods> list);
        public event UpdatePhieuMua UpdateMuaHang;

        

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            GridView gridView = grcChungTu.FocusedView as GridView;

            InforDetailBuy inforBuyGui = new InforDetailBuy();

            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");  // lấy được mã phiếu 
            if(maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu cần sửa");
            }
            else
            {
                inforBuyGui = inforBuy.getInforDetailBuyFromMa(maPhieu.ToString());  // lấy thông tin mua hàng của mã phiếu
                List<DetailBuyGoods> listDetailBuyGui = detailBuyBus.getListChiTietHoaDonMuaHangFromMaPhieu(maPhieu.ToString());
                /// lấy ra danh sách các chi tiết mua hàng của mã phiếu

                if (UpdateMuaHang != null)
                {
                    UpdateMuaHang(inforBuyGui, listDetailBuyGui);  // đưa sang màn hiinhf bên kia
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiHangHoa();
        }
    }
}
