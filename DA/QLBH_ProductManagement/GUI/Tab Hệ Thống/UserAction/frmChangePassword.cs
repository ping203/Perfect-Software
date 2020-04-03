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
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using static QLBH_ProductManagement.frmMain;
using DevExpress.XtraEditors.DXErrorProvider;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
        // tên chức năng hiện tại
        string TenChucNang = "Đổi Mật Khẩu";

        string username;

        public frmChangePassword(string tenDangNhap)
        {
            InitializeComponent();

            username = tenDangNhap;

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string pass = nguoiDungBUS.GetPassword(username);
            string oldPass = txtMatKhauCu.Text;

            if (string.Compare(pass, oldPass) != 0)
            {
                XtraMessageBox.Show("Mật Khẩu cũ không đúng!", "Sai Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.Compare(txtMatKhauMoi.Text, txtNhapLaiMK.Text) != 0)
                {
                    XtraMessageBox.Show("Mật khẩu nhập lại không trùng khớp!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int kq = nguoiDungBUS.CapNhatMatKhau(username, txtMatKhauMoi.Text);

                    if (kq >= 1)
                    {
                        AddNhatKy("Cập nhật");
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Đổi mật khẩu thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddNhatKy(string hanhDong)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = username;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        private void frmChangePassword_Load_1(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
        }
    }
}