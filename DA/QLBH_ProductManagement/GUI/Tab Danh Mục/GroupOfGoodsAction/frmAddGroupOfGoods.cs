using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.GroupOfGoodsAction
{
    public partial class frmAddGroupOfGoods : DevExpress.XtraEditors.XtraForm
    {
        public frmAddGroupOfGoods()
        {
            InitializeComponent();
        }
         NhomHangBUS nhomHangBUS = new NhomHangBUS();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string manhom = txtMaNhom.Text;
            string tennhom = txtTenNhom.Text;
            string GhiChu = txtGhichu.Text;
            bool Active = bool.Parse(ckActive.Checked.ToString());
            if (tennhom == "")
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhom.Focus();
            }
            else
            {
                int check = nhomHangBUS.InsertNhomHang(manhom, tennhom, GhiChu, Active);
                if (check == 1)
                {
                    XtraMessageBox.Show("Success!!!");
                    frmDepartment.statusAction = 1;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Fail!!!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddGroupOfGoods_Load(object sender, EventArgs e)
        {
            txtMaNhom.ReadOnly = true;
            txtMaNhom.Text = nhomHangBUS.IDAuto();
        }
    }
}