using System;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.DepartmentAction
{
    public partial class frmUpdateDepartmentAction : DevExpress.XtraEditors.XtraForm
    {
        DepartmentDTO departmentDTO = new DepartmentDTO();
        DepartmentBUS departmentBUS = new DepartmentBUS();
        public frmUpdateDepartmentAction()
        {
            InitializeComponent();
        }
        public frmUpdateDepartmentAction(DepartmentDTO department) : this()
        {
            departmentDTO.iMaBP = department.iMaBP;
            departmentDTO.iTenBP = department.iTenBP;
            departmentDTO.iGhiChu = department.iGhiChu;
            departmentDTO.iActive = department.iActive;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //string mabp = departmentDTO.iMaBP;
            departmentDTO.iTenBP = txtTenBP.Text;
            departmentDTO.iGhiChu = txtGhiChu.Text;
            departmentDTO.iActive = bool.Parse(ckActive.Checked.ToString());

            int check = departmentBUS.UpdateDepartment(departmentDTO);
            if (check == 1)
            {
                XtraMessageBox.Show("Success!!!");

            }
            else
            {
                XtraMessageBox.Show("Fail!!!");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmUpdateDepartmentAction_Load(object sender, EventArgs e)
        {
            txtMaBP.Text = departmentDTO.iMaBP;
            txtMaBP.ReadOnly = true;
            txtTenBP.Text = departmentDTO.iTenBP;
            txtGhiChu.Text = departmentDTO.iGhiChu;
            ckActive.Checked = departmentDTO.iActive;
        }
    }
}