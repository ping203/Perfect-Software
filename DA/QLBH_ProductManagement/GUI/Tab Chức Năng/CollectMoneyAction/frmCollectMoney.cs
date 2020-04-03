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
using QLBH_ProductManagement.GUI.CollectMoneyAction;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmCollectMoney : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // tên chức năng hiện tại
        string TenChucNang = "Thu Tiền";

        string user;
        VaiTro_ChucNangDTO vtcn;

        public frmCollectMoney(VaiTro_ChucNangDTO pqtt, string un)
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

        private void frmCollectMoney_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            loadDanhSachPhieuThu();
        }

        private void loadDanhSachPhieuThu()
        {
            ucCM_DanhSachPhieuThu uc = new ucCM_DanhSachPhieuThu();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
        private void nbiDanhSachPhieuThu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadDanhSachPhieuThu();
        }

        private void nbiDanhSachPhieuCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucCM_DanhSachPhieuCongNo uc = new ucCM_DanhSachPhieuCongNo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiDanhSachPhieuTraNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucCM_DanhSachPhieuTraNgay uc = new ucCM_DanhSachPhieuTraNgay();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoDoiCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucCM_TheoDoiCongNo uc = new ucCM_TheoDoiCongNo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTongHopCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucCM_TongHopCongNo uc = new ucCM_TongHopCongNo();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

    }
}