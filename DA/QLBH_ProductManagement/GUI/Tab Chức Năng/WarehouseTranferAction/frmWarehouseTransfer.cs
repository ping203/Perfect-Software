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
using QLBH_ProductManagement.GUI.WarehouseTranferAction;
using QLBH_ProductManagement.GUI.WarehouseAction;
using QLBH_ProductManagement.GUI.EmployeesAction;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmWarehouseTransfer : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Chuyển Kho";

        public frmWarehouseTransfer(VaiTro_ChucNangDTO pqck, string un)
        {
            InitializeComponent();
            user = un;
        }

        private void AddNhatKy(string hanhDong, string chucnang)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = chucnang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        private void frmWarehouseTransfer_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            loadPhieuChuyenKho();
        }
        ucWT_PhieuChuyenKho uc = new ucWT_PhieuChuyenKho();
        private void loadPhieuChuyenKho()
        {
            
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
        private void nbiPhieuChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucWT_PhieuChuyenKho uc = new ucWT_PhieuChuyenKho();
           
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucWT_TheoChungTu uc = new ucWT_TheoChungTu();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;

            uc.TaoMoiChuyenKho += TaoMoiChuyenKho;
            uc.UpdateChuyenKho += UpdateChuyenKho;
        }

        private void UpdateChuyenKho(InforTransWarehouseDTO inforTrans, List<DetailTransWarehouseDTO> list)
        {
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;

            uc.getDuLieu(inforTrans, list);
        }

        private void TaoMoiChuyenKho()
        {
            ucWT_PhieuChuyenKho uc = new ucWT_PhieuChuyenKho();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucWT_TheoHangHoa uc = new ucWT_TheoHangHoa();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;

            uc.TaoMoiChuyenKho += TaoMoiChuyenKho;
            uc.UpdateChuyenKho += UpdateChuyenKho;
        }

        private void nbiHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAddGoods fAddGoods = new frmAddGoods();
            fAddGoods.ShowDialog();
            AddNhatKy("Thêm", "Hàng Hóa");
        }

        private void nbiKhoHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAddWarehouse fAddWarehouse = new frmAddWarehouse();
            fAddWarehouse.ShowDialog();
            AddNhatKy("Thêm", "Kho Hàng");
        }

        private void nbiNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAddEmployees fAddEmployees = new frmAddEmployees();
            fAddEmployees.ShowDialog();
            AddNhatKy("Thêm", "Nhân Viên");
        }
    }
}