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
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraEditors.Controls;
using System.Security.Cryptography;

namespace QLBH_ProductManagement.GUI.RoleAction
{
    public partial class frmAddUser : DevExpress.XtraEditors.XtraForm
    {
        EmployeesBUS employeesBUS = new EmployeesBUS();
        VaiTroBUS vaiTroBUS = new VaiTroBUS();
        NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();

        //event khi thêm người dùng thành công
        public delegate void dNguoiDung();
        public event dNguoiDung ThemThanhCong;
        public event dNguoiDung CapNhatThanhCong;

        //event khi thêm vai trò thành công
        public delegate void ndVaiTro();
        public event ndVaiTro CapNhatVaiTro;
        // lưu trạng thái là đang thêm đang sửa
        int Cur_State = 1;
        // dùng để thêm
        public frmAddUser()
        {
            InitializeComponent();

            Cur_State = 1;

            Load += new EventHandler(frmLoad_Them);
            btnDong.Click += new EventHandler(btnDong_click);
            btnLuu.Click += new EventHandler(btnLuu_click);

            lkueVaiTro.ButtonClick += LkueVaiTro_ButtonClick;
            lkueNhanVien.EditValueChanged += new EventHandler(lkueNhanVien_editValueChanged);


            this.Text = "Thêm Người Dùng";
           
        }
        private string hashStringToPassword(string iPassword)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(iPassword, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }
        private void LkueVaiTro_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //if (e.Button.Index == 0)
            //{
            //    frmAddRole vt = new frmAddRole();
            //    vt.ThemThanhCong += FillCbVaiTro;
            //    vt.ShowDialog();
            //}
        }
        // dùng để sửa
        public frmAddUser(NguoiDung nd)
        {
            InitializeComponent();

            this.Text = "Sửa Người Dùng";
            Cur_State = 0;

            btnDong.Click += new EventHandler(btnDong_click);
            btnLuu.Click += new EventHandler(btnLuu_click);

            lkueVaiTro.ButtonClick += LkueVaiTro_ButtonClick;
            lkueNhanVien.EditValueChanged += new EventHandler(lkueNhanVien_editValueChanged);


            FillDuLieu(nd);
        }
        private void lkueNhanVien_editValueChanged(object sender, EventArgs e)
        {
            txtDienGiai.Text = lkueNhanVien.Text;
        }
        private void frmLoad_Them(object sender, EventArgs e)
        {
            FillCbNhanVien();
            FillCbVaiTro();
        }
        private void btnThemVaiTro_Click(object sender, EventArgs e)
        {
            frmAddRole vt = new frmAddRole();
            vt.ThemThanhCong += FillCbVaiTro;
            vt.ShowDialog();
        }    
        private void btnLuu_click(object sender, EventArgs e)
        {
            if (Cur_State == 1)
            {
                int KT_NguoiDung = nguoiDungBUS.DaTonTai(txtTaiKhoan.Text);
                if (KT_NguoiDung >= 1)
                {
                    XtraMessageBox.Show("Tên người dùng đã tồn tại", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (string.Compare(txtMatKhau.Text, txtReMK.Text) != 0)
            {
                XtraMessageBox.Show("Mật khẩu nhập lại không đúng", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    XtraMessageBox.Show("Không được để trống tài khoản hoặc mật khẩu", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NguoiDung nd = new NguoiDung();
                    nd.TenDangNhap = txtTaiKhoan.Text;
                    nd.Password = hashStringToPassword(txtMatKhau.Text);
                    nd.MaNV = lkueNhanVien.EditValue.ToString();
                    nd.MaVaiTro = lkueVaiTro.EditValue.ToString();
                    nd.DienGiai = txtDienGiai.Text;
                    nd.ConQuanLy = ckbConQuanLy.Checked;

                    //thêm
                    if (Cur_State == 1)
                    {
                        int kq = nguoiDungBUS.ThemNguoiDung(nd);
                        if (kq >= 1)
                        {
                            ThemThanhCong();
                            XtraMessageBox.Show("Thêm người dùng thành công", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm thất bại", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    //sửa
                    else if (Cur_State == 0)
                    {
                        int kq = nguoiDungBUS.CapNhatNguoiDung(nd);
                        if (kq >= 1)
                        {
                            CapNhatThanhCong();
                            XtraMessageBox.Show("Cập nhật người dùng thành công", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Cập nhật thất bại", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void btnDong_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillDuLieu(NguoiDung nd)
        {
            FillCbNhanVien();
            FillCbVaiTro();

            lkueNhanVien.EditValue = nd.MaNV;
            txtDienGiai.Text = lkueNhanVien.Text;
            txtTaiKhoan.Text = nd.TenDangNhap;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.Text = hashStringToPassword(nd.Password);
            txtReMK.Text = hashStringToPassword(txtMatKhau.Text);
            lkueVaiTro.EditValue = nd.MaVaiTro;
            ckbConQuanLy.Checked = nd.ConQuanLy;
        }
        private void FillCbVaiTro()
        {
            string sql = "select MaVaiTro, TenVaiTro from VAITRO";
            DataTable dt = vaiTroBUS.LayDuLieuVaiTro(sql);

            lkueVaiTro.Properties.DataSource = dt;
            lkueVaiTro.Properties.ValueMember = "MaVaiTro";
            lkueVaiTro.Properties.DisplayMember = "TenVaiTro";
            lkueVaiTro.ItemIndex = 0;

            //CapNhatVaiTro();
        }
        private void FillCbNhanVien()
        {
            string sql = "select nv.MaNV, nv.TenNV, bp.TenBP from _NHANVIEN nv, BOPHAN bp where nv.BoPhan = bp.MaBP";
            DataTable dt = employeesBUS.LayDuLieuNV(sql);

            lkueNhanVien.Properties.DataSource = dt;
            lkueNhanVien.Properties.ValueMember = "MaNV";
            lkueNhanVien.Properties.DisplayMember = "TenNV";
            lkueNhanVien.ItemIndex = 0;
        }
    }
}