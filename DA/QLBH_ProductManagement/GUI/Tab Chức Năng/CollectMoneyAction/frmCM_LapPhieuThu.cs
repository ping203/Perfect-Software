using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using System.Data.SqlClient;

namespace QLBH_ProductManagement.GUI.CollectMoneyAction
{
    public partial class frmCM_LapPhieuThu : DevExpress.XtraEditors.XtraForm
    {
        public frmCM_LapPhieuThu()
        {
            InitializeComponent();
        }
        PhieuThuTien phieuThuTien = new PhieuThuTien();
        EmployeesBUS employ = new EmployeesBUS();
        PhieuThuTienBUS ptTienBUS = new PhieuThuTienBUS();
        InforSellBUS inforSell = new InforSellBUS();
        PhieuThuTien ptTien = new PhieuThuTien();
        public frmCM_LapPhieuThu(PhieuThuTien phieuThu) :this()
        {
            ptTien.TenKH = phieuThuTien.TenKH = phieuThu.TenKH;
            ptTien.MaKH = phieuThuTien.MaKH = phieuThu.MaKH;
            ptTien.SoTien = phieuThuTien.SoTien = phieuThu.SoTien;
            ptTien.MaChungTu  = phieuThuTien.MaChungTu = phieuThu.MaChungTu;
            ptTien.NgayLap = phieuThuTien.NgayLap = phieuThu.NgayLap;
        }


        public void loadNhaVien()
        {
            cbNhanVien.Properties.DataSource = employ.getEmployeesDataTable();
            cbNhanVien.Properties.DisplayMember = "TenNV";
            cbNhanVien.Properties.ValueMember = "MaNV";
            cbNhanVien.ItemIndex = 1;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {


            ptTien.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtPhieu.Text));
            ptTien.SoTien = (float)Convert.ToDouble(txtTienTra.Text);
            ptTien.GhiChu = txtLyDo.Text;
            ptTien.MaPhieu = txtPhieu.Text;
            ptTien.TenNV = cbNhanVien.Text;

            var print = new frmPrint();
            print.PrintReportThu(ptTien);
            print.ShowDialog();
        }

        private void frmCM_LapPhieuThu_Load(object sender, EventArgs e)
        {
            txtChungTu.Text = phieuThuTien.MaChungTu;
            dtPhieu.Text = dtChungTu.Text = phieuThuTien.NgayLap.ToString();
            txtNo.Text = phieuThuTien.SoTien.ToString();
            txtSoTien.Text = phieuThuTien.SoTien.ToString();
            txtTienTra.Text = phieuThuTien.SoTien.ToString();
            txtKhachHang.Text = phieuThuTien.TenKH;
            txtLyDo.Text = "Thu Tiền Khách Hàng";
            loadNhaVien();

            txtPhieu.Text = ptTienBUS.IDAuto();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            float tienTra = (float)Convert.ToDouble(txtTienTra.Text);
            if (Convert.ToDouble(txtNo.Text) < tienTra)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Số tiền trả phải <= Số tiền đang nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienTra.Focus();
            }
            else
            {
                phieuThuTien.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtPhieu.Text));
                phieuThuTien.SoTien = tienTra;
                phieuThuTien.GhiChu = txtLyDo.Text;
                phieuThuTien.MaPhieu = txtPhieu.Text;
                phieuThuTien.TenNV = cbNhanVien.Text;
                try
                {
                    ptTienBUS.InsertPhieuThuTien(phieuThuTien);
                    inforSell.UpdateIsCheck(phieuThuTien.MaChungTu, 0);
                    XtraMessageBox.Show("Thêm phiếu thu tiền thành công");

                    this.Close();
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi thêm vào thông tin phiếu thu tiền:  " + ex.Message);
                }
            }

           
        }
    }
}