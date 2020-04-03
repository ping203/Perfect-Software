using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.CustomerAction;
using QLBH_ProductManagement.GUI.WarehouseAction;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmSell : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Bán Hàng";
       

        private void AddNhatKy(string hanhDong, string chucnang)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = chucnang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        public frmSell(VaiTro_ChucNangDTO vtpq, string un)
        {         
            InitializeComponent();
            user = un;
           
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            loadPhieuBanHang();
        }
        ucSellPhieuBanHang uc = new ucSellPhieuBanHang();
        private void loadPhieuBanHang()
        {

            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
        private void nbiPhieuBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSellPhieuBanHang uc = new ucSellPhieuBanHang();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSellTheoChungTu uc = new ucSellTheoChungTu();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
            uc.TaoMoiHangHoa += TaoMoiPhieuBanHang;
            uc.UpdateBanHang += UpdatePhieuBanHang;
        }

        private void UpdatePhieuBanHang(InforDetailSell inforSell, List<DetailSellGoods> list)
        {
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
            uc.getDuLieu(inforSell, list);
        }

        private void TaoMoiPhieuBanHang()
        {
            ucSellPhieuBanHang uc = new ucSellPhieuBanHang();
            userControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Add(uc);
        }

        private void nbiTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSellTheoHangHoa uc = new ucSellTheoHangHoa();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
            uc.TaoMoiHangHoa += TaoMoiPhieuBanHang;
            uc.UpdateBanHang += UpdatePhieuBanHang;
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