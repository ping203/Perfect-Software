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

namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class frmPay : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // tên chức năng hiện tại
        string TenChucNang = "Trả Tiền";

        string user;
        VaiTro_ChucNangDTO vtcn;

        public frmPay(VaiTro_ChucNangDTO pqtt, string un)
        {
            InitializeComponent();
            vtcn = pqtt;
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
        private void frmPay_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadDanhSachPhieuChi();
        }
        private void loadDanhSachPhieuChi()
        {
            ucPay_DanhSachPhieuChi uc = new ucPay_DanhSachPhieuChi();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
        private void nbiDanhSachPhieuChi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadDanhSachPhieuChi();
        }

        private void nbiDanhSachPhieuCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucPay_DanhSachPhieuCongNo uc = new ucPay_DanhSachPhieuCongNo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiDanhSachPhieuTraNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucPay_DanhSachPhieuTraNgay uc = new ucPay_DanhSachPhieuTraNgay();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoDoiCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucPay_TheoDoiCongNo uc = new ucPay_TheoDoiCongNo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTongHopCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucPay_TongHopCongNo uc = new ucPay_TongHopCongNo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
    }
}