using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using System.Data.SqlClient;
namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class frmPay_LapPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        public frmPay_LapPhieuChi()
        {
            InitializeComponent();
        }

        EmployeesBUS employ = new EmployeesBUS();
        PhieuChiTien pcTien = new PhieuChiTien();
        PhieuChiTienBUS pcTienBUS = new PhieuChiTienBUS();
        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();
        PhieuChiTien phieuChiTien = new PhieuChiTien();
        public frmPay_LapPhieuChi(PhieuChiTien pcTienNhan) :this()
        {

            phieuChiTien.TenNCC = pcTien.TenNCC = pcTienNhan.TenNCC;
            phieuChiTien.MaNCC = pcTien.MaNCC = pcTienNhan.MaNCC;
            phieuChiTien.SoTien = pcTien.SoTien = pcTienNhan.SoTien;
            phieuChiTien.MaChungTu = pcTien.MaChungTu = pcTienNhan.MaChungTu;
            phieuChiTien.NgayLap = pcTien.NgayLap = pcTienNhan.NgayLap;
        }
        
        public void loadNhaVien()
        {
            cbNhanVien.Properties.DataSource = employ.getEmployeesDataTable();
            cbNhanVien.Properties.DisplayMember = "TenNV";
            cbNhanVien.Properties.ValueMember = "MaNV";
            cbNhanVien.ItemIndex = 1;
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
                pcTien.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtPhieu.Text));
                pcTien.SoTien = tienTra;

                pcTien.GhiChu = txtLyDo.Text;
                pcTien.MaPhieu = txtPhieu.Text;
                pcTien.TenNV = cbNhanVien.Text;
                try
                {
                    pcTienBUS.InsertPhieuChiTien(pcTien);

                    inforBuy.UpdateIsCheck(pcTien.MaChungTu, 0);
                    XtraMessageBox.Show("Thêm phiếu chi tiền thành công");

                    this.Close();
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi thêm vào thông tin phiếu thu tiền:  " + ex.Message);
                }
            }

           
        }

        private void frmPay_LapPhieuChi_Load(object sender, EventArgs e)
        {
            txtChungTu.Text = pcTien.MaChungTu;
            dtPhieu.Text = dtChungTu.Text = pcTien.NgayLap.ToString();
            txtNo.Text = pcTien.SoTien.ToString();
            txtSoTien.Text = pcTien.SoTien.ToString();
            txtTienTra.Text = pcTien.SoTien.ToString();
            txtNCC.Text = pcTien.TenNCC;
            txtLyDo.Text = "Chi Tiền Khách Hàng";
            loadNhaVien();

            txtPhieu.Text = pcTienBUS.IDAuto();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            phieuChiTien.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtPhieu.Text));
            phieuChiTien.SoTien = (float)Convert.ToDouble(txtTienTra.Text);
            phieuChiTien.GhiChu = txtLyDo.Text;
            phieuChiTien.MaPhieu = txtPhieu.Text;
            phieuChiTien.TenNV = cbNhanVien.Text;

            var print = new frmPrint();
            print.PrintReportChi(phieuChiTien);
            print.ShowDialog();
        }

    }
}