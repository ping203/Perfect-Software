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
using QLBH_ProductManagement.DTO;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace QLBH_ProductManagement.GUI.WarehouseTranferAction
{
    public partial class ucWT_TheoChungTu : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucWT_TheoChungTu()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcBangKeTongHop);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBangKeTongHop);
        }
        InforTransWarehouseBUS inforTransBUS = new InforTransWarehouseBUS();
        DetailTransWarehouseBUS detailTransBUS = new DetailTransWarehouseBUS();

        TonKhoBUS tkBUS = new TonKhoBUS();


        List<DetailTransWarehouseDTO> listDetailTransWarehouse = new List<DetailTransWarehouseDTO>();
        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        private void grcBangKeTongHop_Load(object sender, EventArgs e)
        {
            

            grcBangKeTongHop.DataSource = inforTransBUS.getListInforTrans(a, b, 0);
            listDetailTransWarehouse = detailTransBUS.getListDetailTrans();

            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        private void grvThongTinChuyenKho_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            InforTransWarehouseDTO infor = grv.GetRow(e.RowHandle) as InforTransWarehouseDTO;

            if (infor != null)
            {
                e.IsEmpty = !listDetailTransWarehouse.Any(x => x.MaPhieuChuyen == infor.MaPhieuChuyen);

            }
        }

        private void grvThongTinChuyenKho_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            InforTransWarehouseDTO infor = grv.GetRow(e.RowHandle) as InforTransWarehouseDTO;


            e.ChildList = listDetailTransWarehouse.Where(x => x.MaPhieuChuyen == infor.MaPhieuChuyen).ToList();
        }

        private void grvThongTinChuyenKho_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvThongTinChuyenKho_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ChiTietChuyenKho";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GridView gridView = grcBangKeTongHop.FocusedView as GridView;
            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuChuyen");  // lấy được mã phiếu
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu nhập hàng cần xóa");
            }
            else
            {

                // cấp nhật lại số lượng 2 bên kho đã chuyển cho nhau:

                // lấy được mã phiếu chuyển

                // lấy các thông tin chi tiết của phiếu chuyểnn:

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
                    inforTransBUS.DeleteInforTransWarehouse((string)maPhieu);
                    // xóa chi tiết 
                    detailTransBUS.DeleteDetailTransWarehouse((string)maPhieu);
                    XtraMessageBox.Show("Xóa thành công phiếu chuyển kho");
                    grcBangKeTongHop.DataSource = inforTransBUS.getListInforTrans(a, b, 0);

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
            grcBangKeTongHop.DataSource = inforTransBUS.getListInforTrans(dateTu, dateDen, 1);

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
            GridView gridView = grcBangKeTongHop.FocusedView as GridView;

            InforTransWarehouseDTO inforSellGui = new InforTransWarehouseDTO();

            var maPhieu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhieuChuyen");  // lấy được mã phiếu 
            if (maPhieu == null)
            {
                XtraMessageBox.Show("Mời bạn chọn mã phiếu cần sửa");
            }
            else
            {
                // lấy thông tin chuyển kho biết mã: 


                inforSellGui = inforTransBUS.getDetailTransFromMa(maPhieu.ToString());
                List<DetailTransWarehouseDTO> listDetailBuyGui = detailTransBUS.getListDetailTransFromMa(maPhieu.ToString());


                if (UpdateChuyenKho != null)
                {
                    UpdateChuyenKho(inforSellGui, listDetailBuyGui); // chhuyeenr sang bên nhận
                }
            }
        }
    }
}
