using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.SalesReportAction
{
    public partial class frmSalesReport : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void dBCKhoHang(cSystemLog diary);
        public event dBCKhoHang ThemNhatKyHeThong;
        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Báo Cáo Kho Hàng";

        public frmSalesReport(VaiTro_ChucNangDTO pqbc, string un)
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

            ThemNhatKyHeThong(nk);
        }
        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadChiPhiMuaTheoNgay();
        }

        private void loadChiPhiMuaTheoNgay()
        {
            ucSR_TheoNgay uc = new ucSR_TheoNgay();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
        private void nbiChiPhiMuaHangTheoNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadChiPhiMuaTheoNgay();
        }

        private void nbiTheoNhaCungCap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_TheoNhaCungCap uc = new ucSR_TheoNhaCungCap();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiDoanhSoTheoNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_DoanhSoTheoNgay uc = new ucSR_DoanhSoTheoNgay();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiDoanhSoTheoKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_DoanhSoTheoKhachHang uc = new ucSR_DoanhSoTheoKhachHang(user);
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiDoanhSoTheoNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_DoanhSoTheoNhanVien uc = new ucSR_DoanhSoTheoNhanVien();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiDoanhSoTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_DoanhSoTheoHangHoa uc = new ucSR_DoanhSoTheoHangHoa();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_TheoChungTu uc = new ucSR_TheoChungTu();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSR_TheoHangHoa uc = new ucSR_TheoHangHoa();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
    }
}