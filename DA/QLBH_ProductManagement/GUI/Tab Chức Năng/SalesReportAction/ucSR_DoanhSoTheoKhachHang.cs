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

namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    public partial class ucSR_DoanhSoTheoKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void dBCKhoHang(cSystemLog diary);
        public event dBCKhoHang ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Báo Cáo Kho Hàng";
        public ucSR_DoanhSoTheoKhachHang(string un)
        {          
            InitializeComponent();
            user = un;
        }
        private void AddNhatKy(string hanhDong)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            //ThemNhatKyHeThong(nk);
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grcBaoCaoDanhSoTheoKhachHang);
            AddNhatKy("In");
        }

        CustomerBUS cusBUS = new CustomerBUS();
        DetailSellGoodsBUS detailSellBus = new DetailSellGoodsBUS();
        List<InforDetailSell> listInforSell = new List<InforDetailSell>();

        DateTime b = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));

        private void grcBaoCaoDanhSoTheoKhachHang_Load(object sender, EventArgs e)
        {
            grcBaoCaoDanhSoTheoKhachHang.DataSource = cusBUS.getListKhachHangMuaHang(b, b, 0);
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");

            listInforSell = detailSellBus.getThongTinHoaDon(b, b, 0);
           
        }

        private void grvKhachHang_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            CustomerDTO infor = grv.GetRow(e.RowHandle) as CustomerDTO;

            if (infor != null)
            {
                e.IsEmpty = !listInforSell.Any(x => x.MaKH == infor.MaKH);

            }
        }

        private void grvKhachHang_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            CustomerDTO infor = grv.GetRow(e.RowHandle) as CustomerDTO;
            e.ChildList = listInforSell.Where(x => x.MaKH == infor.MaKH).ToList();
        }

        private void grvKhachHang_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvKhachHang_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ThongTinPhieuBan";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));
            grcBaoCaoDanhSoTheoKhachHang.DataSource = cusBUS.getListKhachHangMuaHang(dateTu, dateDen, 1);
            listInforSell = detailSellBus.getThongTinHoaDon(dateTu, dateDen, 1);
        }
    }
}
