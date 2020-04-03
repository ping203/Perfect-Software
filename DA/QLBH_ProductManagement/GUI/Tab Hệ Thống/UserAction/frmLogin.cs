using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using static QLBH_ProductManagement.frmMain;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        NguoiDungBUS nguoiDung = new NguoiDungBUS();
        ConnectionDB connectionDB = new ConnectionDB();

        public frmLogin()
        {
            InitializeComponent();

        }
        UserBUS user_BUS = new UserBUS();
        int checkCloseFrmLogin = 0;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtUser.Text = Properties.Settings.Default.user;
            txtPass.Text = Properties.Settings.Default.pass;
            ckbNhoMK.Checked = Properties.Settings.Default.ckbNhoMK;

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUser.Text;
            int kt = nguoiDung.TonTaiDangNhap(tendangnhap, txtPass.Text);
            if (kt == 1)
            {
                //nhớ mật khẩu nếu được check
                Properties.Settings.Default.user = txtUser.Text;
                Properties.Settings.Default.pass =
                    ckbNhoMK.Checked == true ? txtPass.Text : "";
                Properties.Settings.Default.ckbNhoMK = ckbNhoMK.Checked;
                Properties.Settings.Default.Save();

                //this.Close();

                string mavt = nguoiDung.LayMaVaiTro(tendangnhap);
                frmMain main = new frmMain(mavt, tendangnhap);
                main.KhiFormDong += CloseForm;
                main.Show();
            }
            else
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkCloseFrmLogin == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}