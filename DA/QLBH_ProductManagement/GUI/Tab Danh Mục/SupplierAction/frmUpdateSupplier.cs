using System;
using System.Data;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.GUI.AreaAction;
using QLBH_ProductManagement.DAO;

namespace QLBH_ProductManagement.GUI.SupplierAction
{
    public partial class frmUpdateSupplier : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateSupplier()
        {
            InitializeComponent();
        }
        SupplierDTO supplier = new SupplierDTO();
        SupplierBUS supBus = new SupplierBUS();
        AreaBUS areaBUS = new AreaBUS();
        DataTable listArea = new DataTable();

        public frmUpdateSupplier(SupplierDTO sup) : this()
        {
            supplier.MaNCC = sup.MaNCC;
            supplier.TenNCC = sup.TenNCC;
            supplier.NguoiLienHe = sup.NguoiLienHe;
            supplier.Fax = sup.Fax;
            supplier.DiaChi = sup.DiaChi;
            supplier.ChucVu = sup.ChucVu;
            supplier.Active = sup.Active;
            supplier.DiDong = sup.DiDong;
            supplier.DienThoai = sup.DienThoai;
        }


        private void loadKV()
        {
            string sql = "select MaKV, TenKV from KHUVUC";
            DataTable dt = ConnectionDB.getData(sql);

            cbKhuVuc.Properties.DataSource = dt;
            cbKhuVuc.Properties.ValueMember = "MaKV";
            cbKhuVuc.Properties.DisplayMember = "TenKV";
            cbKhuVuc.ItemIndex = 0;
        }

        private void frmUpdateSupplier_Load(object sender, EventArgs e)
        {

            txtFax.Text = supplier.Fax;
            txtMa.Text = supplier.MaNCC;
            txtTen.Text = supplier.TenNCC;
            txtNLH.Text = supplier.NguoiLienHe;
            txtDiaChi.Text = supplier.DiaChi;
            txtChucVu.Text = supplier.ChucVu;
            checkAc.Checked = supplier.Active;
            txtDiDong.Text = supplier.DiDong;
            txtDT.Text = supplier.DienThoai;
            loadKV();
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

            int check = supBus.UpdateSup(supDTO);
            if (check == 1)
            {
                XtraMessageBox.Show("Update thành công");
                this.Close();
            }
            else
                XtraMessageBox.Show("Update thất bại");
        }

        private void btnAddKV_Click(object sender, EventArgs e)
        {
            var frmadd = new frmAddArea();
            frmadd.ShowDialog();
            loadKV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}