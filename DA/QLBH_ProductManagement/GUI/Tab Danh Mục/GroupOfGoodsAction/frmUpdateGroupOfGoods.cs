using System;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI.GroupOfGoodsAction
{
    public partial class frmUpdateGroupOfGoods : DevExpress.XtraEditors.XtraForm
    {
        NhomHang nhomHang = new NhomHang();
        NhomHangBUS nhomHangBUS = new NhomHangBUS();
        public frmUpdateGroupOfGoods()
        {
            InitializeComponent();
        }
        public frmUpdateGroupOfGoods(NhomHang nhomHang1) : this()
        {
            nhomHang.maNhomHang = nhomHang1.maNhomHang;
            nhomHang.tenNhomHang = nhomHang1.tenNhomHang;
            nhomHang.ghiChu = nhomHang1.ghiChu;
            nhomHang.kichHoat = nhomHang1.kichHoat;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nhomHang.tenNhomHang = txtTenNhom.Text;
            nhomHang.ghiChu = txtGhiChu.Text;
            nhomHang.kichHoat = bool.Parse(ckActive.Checked.ToString());

            int check = nhomHangBUS.UpdateNhomHang(nhomHang);
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

        private void frmUpdateGroupOfGoods_Load(object sender, EventArgs e)
        {
            txtMaNhom.Text = nhomHang.maNhomHang;
            txtMaNhom.ReadOnly = true;
            txtTenNhom.Text = nhomHang.tenNhomHang;
            txtGhiChu.Text = nhomHang.ghiChu;
            ckActive.Checked = nhomHang.kichHoat;
        }
    }
}