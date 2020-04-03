using System;
using System.Data;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI.WarehouseAction;
using QLBH_ProductManagement.GUI.GroupOfGoodsAction;
using QLBH_ProductManagement.GUI.UnitAction;
using QLBH_ProductManagement.GUI.SupplierAction;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmAddGoods : DevExpress.XtraEditors.XtraForm
    {
        DataTable list = new DataTable();
        SupplierBUS supplierBUS = new SupplierBUS();
        GoodBUS goodBUS = new GoodBUS();
        UnitBUS unitBus = new UnitBUS();
        WarehouseBUS wareBUS = new WarehouseBUS();
        NhomHangBUS nhomHang = new NhomHangBUS();
        TonKhoBUS tkBUS = new TonKhoBUS();
        public frmAddGoods()
        {
            InitializeComponent();
        }
        public void LoadKhoHang()
        {

            DataTable dt = wareBUS.LoadKhoHang();
            cbKhoMacDinh.Properties.DataSource = dt;
            cbKhoMacDinh.Properties.DisplayMember = "TenKho";
            cbKhoMacDinh.Properties.ValueMember = "MaKho";
            cbKhoMacDinh.ItemIndex = 0;
        }
        public void LoadDonVi()
        {

            DataTable dt = unitBus.getUnitDataTable();
            cbDonVi.Properties.DataSource = dt;
            cbDonVi.Properties.DisplayMember = "Ten";
            cbDonVi.Properties.ValueMember = "MaDVT";
            cbDonVi.ItemIndex = 0;
        }
        public void LoadNCC()
        {

            DataTable dt = supplierBUS.getNCC();
            cbNhaCungCap.Properties.DataSource = dt;
            cbNhaCungCap.Properties.DisplayMember = "TenNCC";
            cbNhaCungCap.Properties.ValueMember = "MaNCC";
            cbNhaCungCap.ItemIndex = 0;
        }
        public void LoadNhomHang()
        {

            DataTable dt = nhomHang.LoadNhomHang();
            cbPhanLoai.Properties.DataSource = dt;
            cbPhanLoai.Properties.DisplayMember = "TenNhom";
            cbPhanLoai.Properties.ValueMember = "MaNhom";
            cbPhanLoai.ItemIndex = 0;
        }
        private void frmAddGoods_Load(object sender, EventArgs e)
        {
            LoadDonVi();
            LoadNhomHang();
            LoadNCC();
            LoadKhoHang();

            cbLoaiHangHoa.Properties.Items.Add("Hàng Hóa");
            cbLoaiHangHoa.Properties.Items.Add("Dịch Vụ");
            cbLoaiHangHoa.SelectedIndex = 0;
            ckActive.Checked = true;
            txtMaHang.ReadOnly = true;
            txtMaHang.Text = goodBUS.IDAuto();
            txtMaVach.ReadOnly = true;
            txtMaVach.Text = txtMaHang.Text = goodBUS.IDAuto();


        }
        private void btnAddKhoMacDinh_Click(object sender, EventArgs e)
        {
            frmAddWarehouse fAddWarehouse = new frmAddWarehouse();
            fAddWarehouse.ShowDialog();
            LoadKhoHang();
        }
        private void btnAddPhanLoai_Click(object sender, EventArgs e)
        {
            frmAddGroupOfGoods fAddGroupOfGoods = new frmAddGroupOfGoods();
            fAddGroupOfGoods.ShowDialog();
            LoadNhomHang();
        }
        private void btnAddDonVi_Click(object sender, EventArgs e)
        {
            frmAddUnit fAddUnit = new frmAddUnit();
            fAddUnit.ShowDialog();
            LoadDonVi();
        }
        private void btnAddNhaCungCap_Click(object sender, EventArgs e)
        {
            frmAddSupplier fAddSupplier = new frmAddSupplier();
            fAddSupplier.ShowDialog();
            LoadNCC();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            GoodDTO good = new GoodDTO();
            TonKho tkDTO = new TonKho();

            tkDTO.MaHang = good.MaHang = txtMaHang.Text;
           
            good.TenHang = txtTenHang.Text;
            good.GiaMua = float.Parse(calGiaMua.Text.ToString());
            good.GiabanLe = float.Parse(calGiaBanLe.Text.ToString());
            good.GiaBanSi = float.Parse(calGiaBanSi.Text.ToString());
          
            good.Active = bool.Parse(ckActive.Checked.ToString());
            tkDTO.SoLuongToiThieu = good.SoLuongToiThieu = int.Parse(calToiThieu.Text.ToString());
            tkDTO.MaKho = good.MaKho = cbKhoMacDinh.EditValue != null ? cbKhoMacDinh.EditValue.ToString() : null;
            good.MaNCC = cbNhaCungCap.EditValue != null ? cbNhaCungCap.EditValue.ToString() : null;
            good.MaDonVi = cbDonVi.EditValue != null ? cbDonVi.EditValue.ToString() : null;
            good.MaNhom = cbPhanLoai.EditValue != null ? cbPhanLoai.EditValue.ToString() : null;

            

            int check = goodBUS.InsertGood(good);
            int checkInsertTonKho = tkBUS.insertTonKho(tkDTO, 0);

            if (check == 1 && checkInsertTonKho == 1)
            {
                // Thêm vào bên tồn kho

                

                XtraMessageBox.Show("Success!!!");
                this.Close();
            }
            else
                XtraMessageBox.Show("Fail!!!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}