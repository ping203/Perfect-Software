using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.DepartmentAction
{
    public partial class frmAddDepartment : DevExpress.XtraEditors.XtraForm
    {

        public frmAddDepartment()
        {
            InitializeComponent();
        }
        DepartmentBUS departmentBUS = new DepartmentBUS();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string MaBP = txtMaBP.Text;
            string TenBP = txtTenBP.Text;
            string GhiChu = txtGhiChu.Text;
            bool Active = bool.Parse(ckActive.Checked.ToString());
            if (TenBP == "")
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBP.Focus();
            }
            else
            {
                int check = departmentBUS.InsertDepartment(MaBP, TenBP, GhiChu, Active);
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

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {
            txtMaBP.ReadOnly = true;
            txtMaBP.Text = departmentBUS.IDAuto();
        }
    }
}