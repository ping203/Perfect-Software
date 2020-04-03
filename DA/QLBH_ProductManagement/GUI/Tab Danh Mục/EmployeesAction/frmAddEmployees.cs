using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.DepartmentAction;

namespace QLBH_ProductManagement.GUI.EmployeesAction
{
    public partial class frmAddEmployees : DevExpress.XtraEditors.XtraForm
    {

        public frmAddEmployees()
        {
            InitializeComponent();
            FillCbBoPhan();
            FillCbQuanLy();
        }
        EmployeesBUS employeesBUS = new EmployeesBUS();
        private void FillCbBoPhan()
        {
            string sql = "select TenBP, MaBP from BOPHAN";
            DataTable dt = ConnectionDB.getData(sql);
            lkBoPhan.Properties.DataSource = dt;
            lkBoPhan.Properties.ValueMember = "MaBP";
            lkBoPhan.Properties.DisplayMember = "TenBP";
            lkBoPhan.ItemIndex = 0;
        }

        private void FillCbQuanLy()
        {
            string sql = "select TenNV, MaNV from _NHANVIEN";
            DataTable dt = ConnectionDB.getData(sql);

            lkQuanLy.Properties.DataSource = dt;
            lkQuanLy.Properties.ValueMember = "MaNV";
            lkQuanLy.Properties.DisplayMember = "TenNV";
            lkQuanLy.ItemIndex = -1;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            EmployeesDTO nv = new EmployeesDTO();
            nv.iTenNV = txtTenNV.Text;
            nv.iDiaChi = txtDiaChi.Text;
            nv.iDienThoai = txtDienThoai.Text;
            nv.iDiDong = txtDiDong.Text;
            nv.iEmail = txtEmail.Text;
            nv.iBoPhan = lkBoPhan.EditValue != null ? lkBoPhan.EditValue.ToString() : null;
            nv.iNguoiQL = lkQuanLy.EditValue != null ? lkQuanLy.EditValue.ToString() : null;
            nv.iActive = bool.Parse(ckActive.Checked.ToString());

            if (nv.iTenNV == "")
            {
                XtraMessageBox.Show("Dữ liệu ô này không được bỏ trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
            }
            else
            {
                int check = employeesBUS.InsertEmployees(nv);
                if (check == 1)
                {
                    XtraMessageBox.Show("Success!!!");
                    frmEmployees.statusAction = 1;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Fail!!!");
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEmployees_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtMaNV.Text = employeesBUS.IDAuto();
            FillCbBoPhan();
            FillCbQuanLy();
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            frmAddDepartment fAddDepartment = new frmAddDepartment();
            fAddDepartment.ShowDialog();

            FillCbBoPhan();
        }

        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {

            FillCbQuanLy();
        }
    }
}