using System;
using System.Data;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.AreaAction;

namespace QLBH_ProductManagement.GUI.SupplierAction
{
    public partial class frmAddSupplier : DevExpress.XtraEditors.XtraForm
    {
        //event khi thêm thành công
        public delegate void dNCC();
        public event dNCC ThemThanhCong;
        public event dNCC CapNhatThanhCong;

        public frmAddSupplier()
        {
            InitializeComponent();
        }

        DataTable listArea = new DataTable();
        AreaBUS areaBUS = new AreaBUS();
        SupplierBUS supBus = new SupplierBUS();

        private void loadKV()
        {
           
            DataTable dt = areaBUS.getAreaDataTable();
            cbKhuVuc.Properties.DataSource = dt;
            cbKhuVuc.Properties.ValueMember = "MaKV";
            cbKhuVuc.Properties.DisplayMember = "TenKV";
            cbKhuVuc.ItemIndex = 0;
        }
        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            loadKV();
            string maNCCLast = supBus.getMaNCCLast();
            string MaNCC = SetIDAutomatic.getIDAutomatic3(maNCCLast);
            txtMa.Text = MaNCC;
            txtMa.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SupplierDTO supDTO = new SupplierDTO();

            supDTO.MaNCC = txtMa.Text;
            supDTO.TenNCC = txtTen.Text;
            supDTO.NguoiLienHe = txtNLH.Text;
            supDTO.MaKV = cbKhuVuc.EditValue != null ? cbKhuVuc.EditValue.ToString() : null;
            supDTO.Fax = txtFax.Text;
            supDTO.DienThoai = txtDT.Text;
            supDTO.DiDong = txtDiDong.Text;
            supDTO.DiaChi = txtDiaChi.Text;
            supDTO.Active = bool.Parse(checkAc.Checked.ToString());
            supDTO.ChucVu = txtChucVu.Text;

            int check = supBus.InsertSupplier(supDTO);
            if (check == 1)
            {
                //ThemThanhCong();
                XtraMessageBox.Show("Insert thành công");
                this.Close();
            }
            else
                XtraMessageBox.Show("Insert thất bại");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddKV_Click(object sender, EventArgs e)
        {
            var frmadd = new frmAddArea();
            frmadd.ShowDialog();
            loadKV();
        }

    }
}