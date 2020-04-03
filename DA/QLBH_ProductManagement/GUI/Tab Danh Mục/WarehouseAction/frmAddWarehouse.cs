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
using QLBH_ProductManagement.DTO;
using DevExpress.XtraEditors.DXErrorProvider;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;

namespace QLBH_ProductManagement.GUI.WarehouseAction
{
    public partial class frmAddWarehouse : DevExpress.XtraEditors.XtraForm
    {
        WarehouseBUS b_warehouse = new WarehouseBUS();
        EmployeesBUS b_employees = new EmployeesBUS();

        public frmAddWarehouse()
        {
            InitializeComponent();

            txtMaKho.LostFocus += txtMaKho_Focus;
            txtMaKho.GotFocus += txtMaKho_Focus;
            txtKyHieu.LostFocus += txtKyHieu_Focus;
            txtKyHieu.GotFocus += txtKyHieu_Focus;
            txtTenKho.LostFocus += txtTenKho_Focus;
            txtTenKho.GotFocus += txtTenKho_Focus;

        }
    

        private void frmAddWarehouse_Load(object sender, EventArgs e)
        {
            txtMaKho.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtEmail.ReadOnly = true;

            txtMaKho.Text = b_warehouse.IDAuto();

            string sql = "select MaNV, TenNV from _NHANVIEN";
            DataTable dt = ConnectionDB.getData(sql);
            cbNguoiQuanLy.Properties.DataSource = dt;
            cbNguoiQuanLy.Properties.ValueMember = "MaNV";
            cbNguoiQuanLy.Properties.DisplayMember = "TenNV";
            cbNguoiQuanLy.ItemIndex = 0;
        }


        public int checkThongTinBatBuoc(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isnull = false;
            if (checkThongTinBatBuoc(txtMaKho.Text) == -1)
            {
                dxErrorProvider1.SetError(txtMaKho, "Không được bỏ trống trường này", ErrorType.Default);
                isnull = true;
            }
            if (checkThongTinBatBuoc(txtKyHieu.Text) == -1)
            {
                dxErrorProvider1.SetError(txtKyHieu, "Không được bỏ trống trường này", ErrorType.Default);
                isnull = true;
            }
            if (checkThongTinBatBuoc(txtTenKho.Text) == -1)
            {
                dxErrorProvider1.SetError(txtTenKho, "Không được bỏ trống trường này", ErrorType.Default);
                isnull = true;
            }

            if (isnull == false)
            {
                WarehouseDTO warehouse = new WarehouseDTO();

                warehouse.iMaKho = txtMaKho.Text;
                warehouse.iTenKho = txtTenKho.Text;
                warehouse.iLienHe = txtNguoiLienHe.Text;
                warehouse.iDiaChi = txtDiaChi.Text;
                warehouse.iDienThoai = txtDienThoai.Text;
                warehouse.iKyHieu = txtKyHieu.Text;
                warehouse.iGhiChu = txtDienGiai.Text;
                warehouse.iMaNV = cbNguoiQuanLy.EditValue != null ? cbNguoiQuanLy.EditValue.ToString() : null;
                warehouse.iActive = checkBoxActive.Checked;

                int check = b_warehouse.insertWarehouse(warehouse);

                if (check == 1)
                {
                    XtraMessageBox.Show("Thêm thành công!!!");
                    frmWarehouse.statusAction = 1;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại!!!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region các sự kiện focus và lost focus

        //focusva lost tên kho
        private void txtTenKho_Focus(object sender, EventArgs e)
        {
            if (checkThongTinBatBuoc(txtTenKho.Text) == -1)
            {
                dxErrorProvider1.SetError(txtTenKho, "Không được bỏ trống trường này", ErrorType.Default);
            }
            else
            {
                dxErrorProvider1.SetError(txtTenKho, null);
            }
        }
        //focus và lost kí hiệu
        private void txtKyHieu_Focus(object sender, EventArgs e)
        {
            if (checkThongTinBatBuoc(txtKyHieu.Text) == -1)
            {
                dxErrorProvider1.SetError(txtKyHieu, "Không được bỏ trống trường này", ErrorType.Default);
            }
            else
            {
                dxErrorProvider1.SetError(txtKyHieu, null);
            }
        }
        //focus và lost mã kho
        private void txtMaKho_Focus(object sender, EventArgs e)
        {
            if (checkThongTinBatBuoc(txtMaKho.Text) == -1)
            {
                dxErrorProvider1.SetError(txtMaKho, "Không được bỏ trống trường này", ErrorType.Default);
            }
            else
            {
                dxErrorProvider1.SetError(txtMaKho, null);
            }
        }

        #endregion
    }
}