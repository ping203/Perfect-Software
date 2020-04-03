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
using QLBH_ProductManagement.GUI.WarehouseAction;
using QLBH_ProductManagement.GUI.GroupOfGoodsAction;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.GUI.UnitAction;
using QLBH_ProductManagement.GUI.SupplierAction;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.GoodsAction
{
    public partial class frmUpdateGoods : DevExpress.XtraEditors.XtraForm
    {
        GoodDTO goodDTO = new GoodDTO();
        GoodBUS goodBUS = new GoodBUS();
        string maHangUpdate;
        public frmUpdateGoods()
        {
            InitializeComponent();
        }

        public frmUpdateGoods(string maHang):this()
        {
            maHangUpdate = maHang;
        }

        public void Update()
        {

            goodDTO = goodBUS.getInforGoods(maHangUpdate);

            cbLoaiHangHoa.Properties.Items.Add("Hàng Hóa");
            cbLoaiHangHoa.Properties.Items.Add("Dịch Vụ");
            cbLoaiHangHoa.SelectedIndex = 0;

            txtMaHang.ReadOnly = true;
            txtMaVach.ReadOnly = true;
            txtXuatXu.ReadOnly = true;

            txtMaHang.Text = txtMaVach.Text = goodDTO.MaHang;
            txtTenHang.Text = goodDTO.TenHang;
            calToiThieu.Text = goodDTO.SoLuongToiThieu.ToString();
            calGiaMua.Text = goodDTO.GiaMua.ToString();
            calGiaBanLe.Text = goodDTO.GiabanLe.ToString();
            calGiaBanSi.Text = goodDTO.GiaBanSi.ToString();
            ckActive.Checked = goodDTO.Active;
        }

        public void LoadKhoHang()
        {
            string sql = "select TenKho, MaKho from KHOHANG";
            DataTable dt = ConnectionDB.getData(sql);
            cbKhoMacDinh.Properties.DataSource = dt;
            cbKhoMacDinh.Properties.DisplayMember = "TenKho";
            cbKhoMacDinh.Properties.ValueMember = "MaKho";
            cbKhoMacDinh.ItemIndex = 0;
        }
        public void LoadDonVi()
        {
            string sql = "select Ten, MaDVT from DONVITINH";
            DataTable dt = ConnectionDB.getData(sql);
            cbDonVi.Properties.DataSource = dt;
            cbDonVi.Properties.DisplayMember = "Ten";
            cbDonVi.Properties.ValueMember = "MaDVT";
            cbDonVi.ItemIndex = 0;
        }
        public void LoadNCC()
        {
            string sql = "select TenNCC, MaNCC from NCC";
            DataTable dt = ConnectionDB.getData(sql);
            cbNhaCungCap.Properties.DataSource = dt;
            cbNhaCungCap.Properties.DisplayMember = "TenNCC";
            cbNhaCungCap.Properties.ValueMember = "MaNCC";
            cbNhaCungCap.ItemIndex = 0;
        }
        public void LoadNhomHang()
        {
            string sql = "select  TenNhom, MaNhom from NHOMHANG";
            DataTable dt = ConnectionDB.getData(sql);
            cbPhanLoai.Properties.DataSource = dt;
            cbPhanLoai.Properties.DisplayMember = "TenNhom";
            cbPhanLoai.Properties.ValueMember = "MaNhom";
            cbPhanLoai.ItemIndex = 0;
        }

        private void frmUpdateGoods_Load(object sender, EventArgs e)
        {
            LoadDonVi();
            LoadNCC();
            LoadKhoHang();
            LoadNhomHang();

            Update();



        }

        private void btnAddKhoMacDinh_Click(object sender, EventArgs e)
        {
            frmAddWarehouse fAddWarehouse = new frmAddWarehouse();
            fAddWarehouse.ShowDialog();
        }

        private void btnAddPhanLoai_Click(object sender, EventArgs e)
        {
            frmAddGroupOfGoods fAddGroupOfGoods = new frmAddGroupOfGoods();
            fAddGroupOfGoods.ShowDialog();
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
            goodDTO.MaKho = cbKhoMacDinh.EditValue != null ? cbKhoMacDinh.EditValue.ToString() : null;
            goodDTO.MaNhom = cbPhanLoai.EditValue != null ? cbPhanLoai.EditValue.ToString() : null;
            goodDTO.TenHang = txtTenHang.Text;
            goodDTO.MaDonVi = cbDonVi.EditValue != null ? cbDonVi.EditValue.ToString() : null;
            goodDTO.SoLuongToiThieu = int.Parse(calToiThieu.Text);
            goodDTO.MaNCC = cbNhaCungCap.EditValue != null ? cbNhaCungCap.EditValue.ToString() : null;
            goodDTO.GiaMua = float.Parse(calGiaMua.Text);
            goodDTO.GiaBanSi = float.Parse(calGiaBanSi.Text);
            goodDTO.GiabanLe = float.Parse(calGiaBanSi.Text);
            goodDTO.Active = bool.Parse(ckActive.Checked.ToString());
            goodDTO.MaHang = txtMaHang.Text;


            int check = goodBUS.updateGood(goodDTO);

            if (check == 1)
            {

                XtraMessageBox.Show("Cập nhật hàng hóa " + goodDTO.MaHang + " thành công!!");
                frmGoods.statusAction = 1;
                this.Close();

            }
            else
            {
                XtraMessageBox.Show("Cập nhật đơn vị tính " + goodDTO.MaHang + " thất bại!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}