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
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.GUI.DepartmentAction;

namespace QLBH_ProductManagement.GUI.EmployeesAction
{
    public partial class frmUpdateEmployees : DevExpress.XtraEditors.XtraForm
    {
        EmployeesDTO employeesDTO = new EmployeesDTO();
        EmployeesBUS employeesBUS = new EmployeesBUS();
        public frmUpdateEmployees()
        {
            InitializeComponent();
        }
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
        public frmUpdateEmployees(EmployeesDTO employees) : this()
        {
            employeesDTO.iMaNV = employees.iMaNV;
            employeesDTO.iTenNV = employees.iTenNV;
            employeesDTO.iDiaChi = employees.iDiaChi;
            employeesDTO.iDienThoai = employees.iDienThoai;
            employeesDTO.iDiDong = employees.iDiDong;
            employeesDTO.iEmail = employees.iEmail;
            employeesDTO.iBoPhan = employees.iBoPhan;
            employeesDTO.iActive = employees.iActive;
            employeesDTO.iNguoiQL = employees.iNguoiQL;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            employeesDTO.iMaNV = txtMaNV.Text;
            employeesDTO.iTenNV = txtTenNV.Text;
            employeesDTO.iDiaChi = txtDiaChi.Text;
            employeesDTO.iDienThoai = txtDienThoai.Text;
            employeesDTO.iDiDong = txtDiDong.Text;
            employeesDTO.iEmail = txtEmail.Text;
            employeesDTO.iBoPhan = lkBoPhan.Text;
            employeesDTO.iNguoiQL = lkQuanLy.Text;
            employeesDTO.iActive = bool.Parse(ckActive.Checked.ToString());

            int check = employeesBUS.UpdateEmpoyees(employeesDTO);
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

        private void frmUpdateEmployees_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = employeesDTO.iMaNV;
            txtMaNV.ReadOnly = true;
            txtTenNV.Text = employeesDTO.iTenNV;
            txtDiaChi.Text = employeesDTO.iDiaChi;
            txtDienThoai.Text = employeesDTO.iDienThoai;
            txtDiDong.Text = employeesDTO.iDiDong;
            txtEmail.Text = employeesDTO.iEmail;
            lkBoPhan.Text = employeesDTO.iBoPhan;
            lkQuanLy.Text = employeesDTO.iNguoiQL;
            ckActive.Checked = employeesDTO.iActive;
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
            frmAddEmployees fAddEmployees = new frmAddEmployees();
            fAddEmployees.ShowDialog();

            FillCbQuanLy();
        }
    }
}