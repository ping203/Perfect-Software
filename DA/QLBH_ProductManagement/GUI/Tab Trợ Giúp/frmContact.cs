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

namespace QLBH_ProductManagement.GUI
{
    public partial class frmContact : DevExpress.XtraEditors.XtraForm
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            txtTenDonVi.Text = "ĐH KHOA HỌC TỰ NHIÊN";
            txtDiaChi.Text = "227 Nguyễn Văn Cừ, P.4, Q.5, TPHCM";
            txtDienThoai.Text = "0332006810";
            txtFax.Text = "0332006810";
            txtWebsite.Text = "www.perfect.com.vn";
            txtEmail.Text = "www.perfect.com.vn";
            txtNganhNghe.Text = "Công ty giải pháp phần mềm";
            string[] LinhVuc = new string[] { "1.Sản Xuất", "2.Thương Mại", "3.Dịch Vụ", "4.CNTT", "5.Khác" };
            cbLinhVuc.Items.AddRange(LinhVuc);
            cbLinhVuc.SelectedIndex = 0;
            txtMaSoThue.Text = "1100803080";
            txtGPKD.Text = "1100803080";

            string[] GioiTinh = new string[] { "Anh", "Chị" };
            cbNguoiLienHe.Items.AddRange(GioiTinh);
            cbNguoiLienHe.SelectedIndex = 0;

            txtNguoiLienHe.Text = "Phạm Nguyễn Mỹ Diễm";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Cập nhật thành công. \n\nCảm ơn quý khách đã sử dụng phần mềm của tôi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}