using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.GUI
{
    public partial class ucSellTheoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucSellTheoHangHoa()
        {
            InitializeComponent();
        }
        DetailSellGoodsBUS detailSellBus = new DetailSellGoodsBUS();
        InforSellBUS inforSell = new InforSellBUS();
        public void loadCT_PhieuXuat()
        {
            grvTheoHangHoa.DataSource = detailSellBus.getCTPhieuXuat();

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));

            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            var MaKH = cbKhachHang.EditValue != null ? cbKhachHang.EditValue.ToString() : null;

            if(MaKH == "All")
            {
                grvTheoHangHoa.DataSource = detailSellBus.getCTPhieuXuatFromNgay(dateTu, dateDen);
            }
            else
            {
                grvTheoHangHoa.DataSource = detailSellBus.getCTPhieuXuatTheoKhachHang(MaKH, dateTu, dateDen, 0);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grvTheoHangHoa.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuXuat");  // lấy được mã phiếu
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
            }
            else
            {
                int checkInPhieuThu = inforSell.checkMaChungTuInPhieuThu((string)maPhieu);
                
                if (checkInPhieuThu == 1)
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
                        loadCT_PhieuXuat();
                    }
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grvTheoHangHoa);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grvTheoHangHoa);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        BangTheoDoiCongNoBUS theoDoiBUS = new BangTheoDoiCongNoBUS();

        private void grvTheoHangHoa_Load(object sender, EventArgs e)
        {
            loadCT_PhieuXuat();
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");


            cbKhachHang.Properties.DataSource = theoDoiBUS.getKhachHangMua();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";
            cbKhachHang.ItemIndex = 1;

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
            GridView gridView = grvTheoHangHoa.FocusedView as GridView;

            InforDetailSell inforSellGui = new InforDetailSell();

            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuXuat");  // lấy được mã phiếu 
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
