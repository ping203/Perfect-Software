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
    public partial class frmInfor : DevExpress.XtraEditors.XtraForm
    {
        public frmInfor()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInfor_Load(object sender, EventArgs e)
        {
            txtTenDonVi.Text = "ĐH KHOA HỌC TỰ NHIÊN";
            txtDiaChi.Text = "227 Nguyễn Văn Cừ, P.4, Q.5, TPHCM";
            txtDienThoai.Text = "0332006789";
            txtFax.Text = "0332006789";
            txtWebsite.Text = "www.perfect.com.vn";
            txtEmail.Text = "www.perfect.com.vn";
            string[] LinhVuc = new string[] { "1.Sản Xuất", "2.Thương Mại", "3.Dịch Vụ", "4.CNTT", "5.Khác" };
            cbLinhVuc.Items.AddRange(LinhVuc);
            cbLinhVuc.SelectedIndex = 0;
            txtMaSoThue.Text = "1100803080";
            txtGPKD.Text = "1100803080";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Dữ liệu đã được lưu!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}