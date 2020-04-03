using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.DTO;
using System.Data;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.GUI.AreaAction;
using QLBH_ProductManagement.DAO;

namespace QLBH_ProductManagement.GUI.CustomerAction
{
    public partial class frmUpdateCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        CustomerDTO cusDTO = new CustomerDTO();
        AreaBUS areaBUS = new AreaBUS();
        CustomerBUS cusBus = new CustomerBUS();

        private void loadKV()
        {
            string sql = "select  MaKV, TenKV from KHUVUC";
            DataTable dt = ConnectionDB.getData(sql);
            cbKhuVuc.Properties.DataSource = dt;
            cbKhuVuc.Properties.DisplayMember = "TenKV";
            cbKhuVuc.Properties.ValueMember = "MaKV";
            cbKhuVuc.ItemIndex = 0;
        }

        public frmUpdateCustomer(CustomerDTO cus):this()
        {
            cusDTO.MaKH = cus.MaKH;
            cusDTO.TenKH = cus.TenKH;
            cusDTO.NguoiLienHe = cus.NguoiLienHe;
            cusDTO.MaKV = cus.MaKV;
            cusDTO.Email = cus.Email;
            cusDTO.DiaChi = cus.DiaChi;
            cusDTO.DiDong = cus.DiDong;
            cusDTO.DienThoai = cus.DienThoai;
            cusDTO.Website = cus.Website;
            cusDTO.TenNganHang = cus.TenNganHang;
            cusDTO.SoTK = cus.SoTK;
            cusDTO.Active = cus.Active;
        }
    
        private void frmUpdateCustomer_Load(object sender, System.EventArgs e)
        {
            txtMa.Text = cusDTO.MaKH;
            txtTen.Text = cusDTO.TenKH;
            txtNLH.Text = cusDTO.NguoiLienHe;
            txtNH.Text = cusDTO.TenNganHang;
            txtMST.Text = cusDTO.MaSoThue;
            txtFAX.Text = cusDTO.Fax;
            txtEmail.Text = cusDTO.Email;
            txtDT.Text = cusDTO.DienThoai;
            txtDiDong.Text = cusDTO.DiDong;
            txtDiaChi.Text = cusDTO.DiaChi;
            txtWeb.Text = cusDTO.Website;
            checkAc.Checked = cusDTO.Active;
            loadKV();

            txtMa.ReadOnly = true;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            CustomerDTO cusDTO = new CustomerDTO();
            cusDTO.MaKH = txtMa.Text;
            cusDTO.TenKH = txtTen.Text;
            cusDTO.NguoiLienHe = txtNLH.Text;
            cusDTO.MaSoThue = txtMST.Text;
            cusDTO.SoTK = txtTK.Text;
            cusDTO.TenNganHang = txtNH.Text;
            cusDTO.Website = txtWeb.Text;
            cusDTO.MaKV = cbKhuVuc.EditValue != null ? cbKhuVuc.EditValue.ToString() : null;
            cusDTO.Fax = txtFAX.Text;
            cusDTO.Email = txtEmail.Text;
            cusDTO.DienThoai = txtDT.Text;
            cusDTO.DiDong = txtDiDong.Text;
            cusDTO.DiaChi = txtDiaChi.Text;
            cusDTO.Active = bool.Parse(checkAc.Checked.ToString());

            int check = cusBus.UpdateKhachHang(cusDTO);
            if (check == 1)
            {
                XtraMessageBox.Show("Update thành công");
                this.Close();
            }
            else
                XtraMessageBox.Show("Update thất bại");
        }
        DataTable listArea = new DataTable();

        private void btnAddKV_Click(object sender, System.EventArgs e)
        {
            var frmadd = new frmAddArea();
            frmadd.ShowDialog();
            loadKV();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}