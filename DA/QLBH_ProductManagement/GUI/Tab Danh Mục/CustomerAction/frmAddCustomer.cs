using System;
using System.Data;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.AreaAction;

namespace QLBH_ProductManagement.GUI.CustomerAction
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
      

        AreaBUS areaBUS = new AreaBUS();
        CustomerBUS cusBUS = new CustomerBUS();

        private void loadKV()
        {
            DataTable dt = areaBUS.getAreaDataTable();
            cbKhuVuc.Properties.DataSource = dt;
            cbKhuVuc.Properties.DisplayMember = "TenKV";
            cbKhuVuc.Properties.ValueMember = "MaKV";
            cbKhuVuc.ItemIndex = 0;
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            loadKV();
            string maKVLast = cusBUS.getMaKHLast();
            txtMa.Text = SetIDAutomatic.getIDAutomatic2(maKVLast);
            txtMa.ReadOnly = true;
        }

        private void btnAddKV_Click(object sender, EventArgs e)
        {
            var frmadd = new frmAddArea();
            frmadd.ShowDialog();
            loadKV();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {

            CustomerDTO cusDTO = new CustomerDTO();
            cusDTO.MaKH = txtMa.Text;
            cusDTO.TenKH = txtTenKH.Text;
            cusDTO.NguoiLienHe = txtNLH.Text;
            cusDTO.MaSoThue = txtMaThue.Text;
            cusDTO.SoTK = txtTK.Text;
            cusDTO.TenNganHang = txtNH.Text;
            cusDTO.Website = txtWeb.Text;
            cusDTO.MaKV = cbKhuVuc.EditValue != null ? cbKhuVuc.EditValue.ToString() : null;
            cusDTO.Fax = txtFax.Text;
            cusDTO.Email = txtEmail.Text;
            cusDTO.DienThoai = txtDT.Text;
            cusDTO.DiDong = txtMobile.Text;
            cusDTO.DiaChi = txtDiaChi.Text;
            cusDTO.Active = bool.Parse(checkQL.Checked.ToString());

            int check = cusBUS.InsertKhachHang(cusDTO);
            if (check == 1)
            {
                XtraMessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
                XtraMessageBox.Show("Thêm thất bại");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}