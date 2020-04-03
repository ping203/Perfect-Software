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
    public partial class ucSellTheoChungTu : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSellTheoChungTu()
        {
            InitializeComponent();
        }
        DetailSellGoodsBUS detailSellBus = new DetailSellGoodsBUS();
        List<DetailSellGoods> listChiTietSell = new List<DetailSellGoods>();

        BangTheoDoiCongNoBUS theoDoiBUS = new BangTheoDoiCongNoBUS();

        public void LoadThongTinHoaDon()
        {
            DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
            DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
            grcChungTu.DataSource = detailSellBus.getThongTinHoaDon(a, b , 0);

            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");

            cbKhachHang.Properties.DataSource = theoDoiBUS.getKhachHangMua();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";
            cbKhachHang.ItemIndex = 1;
        }   

        private void grvChungTu_Load(object sender, EventArgs e)
        {
            LoadThongTinHoaDon();

            listChiTietSell = detailSellBus.getListChiTietMua();
        }

        private void grvChungTu_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailSell infor = grv.GetRow(e.RowHandle) as InforDetailSell;

            if (infor != null)
            {
                e.IsEmpty = !listChiTietSell.Any(x => x.MaPhieuXuat == infor.MaPhieu);
            }
        }

        private void grvChungTu_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            InforDetailSell infor = grv.GetRow(e.RowHandle) as InforDetailSell;


            e.ChildList = listChiTietSell.Where(x => x.MaPhieuXuat == infor.MaPhieu).ToList();
        }

        private void grvChungTu_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvChungTu_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ChiTietHoaDon";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcChungTu);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcChungTu);
        }

        InforSellBUS inforSell = new InforSellBUS();
        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grcChungTu.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");  // lấy được mã phiếu

           
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
            }
            else
            {
                int checkInPhieuThu = inforSell.checkMaChungTuInPhieuThu((string)maPhieu);
                if(checkInPhieuThu == 1)
                {
                    DialogResult dr;
                    dr = XtraMessageBox.Show("Đơn hàng đã được thu tiền. Không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int checkDelInfor = inforSell.DeleteInforDetailSell((string)maPhieu);
                    int checkDelDetail = detailSellBus.DeleteDetailSell((string)maPhieu);
                    if (checkDelInfor == 0 || checkDelDetail == 0)
                    {
                        XtraMessageBox.Show("Xóa thất bại đơn hàng");
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa thành công đơn hàng");
                        LoadThongTinHoaDon();
                    }
                }            
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));


            var MaKH = cbKhachHang.EditValue != null ? cbKhachHang.EditValue.ToString() : null;

            if (MaKH == "All")
            {
                grcChungTu.DataSource = detailSellBus.getThongTinHoaDon(dateTu, dateDen, 1);
            }
            else
            {
                grcChungTu.DataSource = detailSellBus.getThongTinHoaDonFromMaKH(dateTu, dateDen, MaKH);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public delegate void TaoMoi();
        public event TaoMoi TaoMoiHangHoa = null;
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiHangHoa();
        }


        public delegate void UpdatePhieuBan(InforDetailSell inforSell, List<DetailSellGoods> list);
        public event UpdatePhieuBan UpdateBanHang;

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            GridView gridView = grcChungTu.FocusedView as GridView;

            InforDetailSell inforSellGui = new InforDetailSell();

            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieu");  // lấy được mã phiếu 
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu cần sửa");
            }
            else
            {
                // lấy thông tin: 


                inforSellGui = inforSell.getInforDetailSellFromMa(maPhieu.ToString());
                List<DetailSellGoods> listDetailBuyGui = detailSellBus.getListChiTietHoaDonBanHangFromMaPhieu(maPhieu.ToString());


                if (UpdateBanHang != null)
                {
                    UpdateBanHang(inforSellGui, listDetailBuyGui); // chhuyeenr sang bên nhận
                }
            }
        }
    }
}
