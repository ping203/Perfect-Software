using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBH_ProductManagement.GUI.CustomerAction;
using QLBH_ProductManagement.GUI.WarehouseAction;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmBuy : DevExpress.XtraEditors.XtraForm
    {

        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Mua Hàng";

        private void AddNhatKy(string hanhDong, string cn)
        {
            
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = cn;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        public frmBuy(VaiTro_ChucNangDTO vtbh, string un)
        {
            InitializeComponent();
            user = un;
        }

        public frmBuy(int check) : this()
        {
            loadPhieuNhapHang();
        }

        public frmBuy()
        {
        }

        private void frmBuy_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            loadPhieuNhapHang();
        }
        ucBuyPhieuNhapHang uc = new ucBuyPhieuNhapHang();
        DetailBuyGoodsBUS detailBuyBus = new DetailBuyGoodsBUS();
        // thằng này phải toàn cục máy update dc
        public void loadPhieuNhapHang()
        {

            detailBuyBus.deleteChiTietHoaDonAo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;

        }

        public void nbiPhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucBuyPhieuNhapHang uc = new ucBuyPhieuNhapHang();
            detailBuyBus.deleteChiTietHoaDonAo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucBuyTheoChungTu uc = new ucBuyTheoChungTu();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            uc.TaoMoiHangHoa += TaoMoiPhieuMuaHang;
            uc.UpdateMuaHang += UpdatePhieuMuaHang;
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;

        }

        private void UpdatePhieuMuaHang(InforDetailBuy inforBuy, List<DetailBuyGoods> list)
        {

            userControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Add(uc);
            uc.getDuLieu(inforBuy, list);
        }

        private void TaoMoiPhieuMuaHang()
        {
            ucBuyPhieuNhapHang ucNHapHang = new ucBuyPhieuNhapHang();
            userControl.Controls.Clear();
            ucNHapHang.Dock = DockStyle.Fill;
            userControl.Controls.Add(ucNHapHang);
        }

        private void nbiTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucBuyTheoHangHoa uc = new ucBuyTheoHangHoa();
            uc.Dock = DockStyle.Fill;

            userControl.Controls.Clear();

            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;

            uc.TaoMoiHangHoa += TaoMoiPhieuMuaHang;
            uc.UpdateMuaHang += UpdatePhieuMuaHang;
        }

        private void nbiHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAddGoods fAddGoods = new frmAddGoods();
            AddNhatKy("Thêm", "Hàng Hóa");
            fAddGoods.ShowDialog();
         
        }

        private void nbiKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAddCustomer fAddCustomer = new frmAddCustomer();
            AddNhatKy("Thêm", "Khách Hàng");
            fAddCustomer.ShowDialog();
            
        }

        private void nbiKhoHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAddWarehouse fAddWarehouse = new frmAddWarehouse();
            AddNhatKy("Thêm", "Kho Hàng");
            fAddWarehouse.ShowDialog();
           
        }
    }
}