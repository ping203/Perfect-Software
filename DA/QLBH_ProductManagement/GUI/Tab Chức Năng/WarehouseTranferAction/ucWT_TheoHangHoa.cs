using System;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Data.SqlClient;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.GUI.WarehouseTranferAction
{
    public partial class ucWT_TheoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();
        DetailTransWarehouseBUS detailTransBUS = new DetailTransWarehouseBUS();
        InforTransWarehouseBUS inforTrans = new InforTransWarehouseBUS();
        TonKhoBUS tkBUS = new TonKhoBUS();
        public ucWT_TheoHangHoa()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcTheoHangHoa);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcTheoHangHoa);
        }

        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        private void ucWT_TheoHangHoa_Load(object sender, EventArgs e)
        {
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            // Load chi tiết chuyển kho:
            

            grcTheoHangHoa.DataSource = detailTransBUS.getDetailTransWarehouse(a, b, 0);

            grvTheoHangHoa.OptionsView.AllowCellMerge = !grvTheoHangHoa.OptionsView.AllowCellMerge;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grcTheoHangHoa.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuChuyen");  // lấy được mã phiếu

            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
            }
            else
            {

                DataTable data = detailTransBUS.getDetailTransFromMa((string)maPhieu);
                foreach (DataRow dataRow in data.Rows)
                {
                    TonKho tkChuyen = new TonKho();
                    TonKho tkNhan = new TonKho();

                    tkChuyen.MaKho = dataRow["MaKhoXuat"].ToString();
                    tkNhan.MaKho = dataRow["MaKhoNhan"].ToString();
                    tkNhan.MaHang = tkChuyen.MaHang = dataRow["MaHang"].ToString();

                    int slChuyen = int.Parse(dataRow["SoLuong"].ToString());

                    // lấy số lượng hiện tại của các mặt hàng mỗi kho
                    int slKhoChuyen = tkBUS.getSoLuong(tkChuyen);
                    int slKhoNhan = tkBUS.getSoLuong(tkNhan);

                    tkBUS.UpdateSoLuong(tkChuyen, slKhoChuyen + slChuyen);
                    tkBUS.UpdateSoLuong(tkNhan, slKhoNhan - slChuyen);

                }

                try
                {
                    // xóa thông tin chuyển
                    inforTrans.DeleteInforTransWarehouse((string)maPhieu);
                    // xóa chi tiết 
                    detailTransBUS.DeleteDetailTransWarehouse((string)maPhieu);
                    XtraMessageBox.Show("Xóa thành công phiếu chuyển kho");

                    grcTheoHangHoa.DataSource = detailTransBUS.getDetailTransWarehouse(a, b, 0);

                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi tại xóa thông tin chuyển kho:  " + ex.Message);
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));
            grcTheoHangHoa.DataSource = detailTransBUS.getDetailTransWarehouse(dateTu, dateDen, 1);
        }

        public delegate void TaoMoi();
        public event TaoMoi TaoMoiChuyenKho = null;

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiChuyenKho();
        }
        public delegate void Update(InforTransWarehouseDTO inforTrans, List<DetailTransWarehouseDTO> list);
        public event Update UpdateChuyenKho;
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            GridView gridView = grcTheoHangHoa.FocusedView as GridView;

            InforTransWarehouseDTO inforSellGui = new InforTransWarehouseDTO();

            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuChuyen");  // lấy được mã phiếu 
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu cần sửa");
            }
            else
            {
                // lấy thông tin chuyển kho biết mã: 


                inforSellGui = inforTrans.getDetailTransFromMa(maPhieu.ToString());
                List<DetailTransWarehouseDTO> listDetailBuyGui = detailTransBUS.getListDetailTransFromMa(maPhieu.ToString());


                if (UpdateChuyenKho != null)
                {
                    UpdateChuyenKho(inforSellGui, listDetailBuyGui); // chhuyeenr sang bên nhận
                }
            }
        }
    }
}
