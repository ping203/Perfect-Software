using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.GUI;
using QLBH_ProductManagement.GUI.PayAction;
using QLBH_ProductManagement.GUI.RoleAction;
using QLBH_ProductManagement.GUI.SalesReportAction;
using QLBH_ProductManagement.GUI.Tab_Danh_Mục;
using QLBH_ProductManagement.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string username;
        public delegate void FormMain();
        public event FormMain KhiFormDong;
        //Danh sách các nhật ký hệ thống
        List<cSystemLog> lstNhatKyFinal = new List<cSystemLog>();  
        
        public frmMain(string mavt, string tendangnhap)
        {
            InitializeComponent();

            Load += FrmMain_Load;
            username = tendangnhap;

            //Tab hệ thống

            btnPhanQuyen.ItemClick += BtnPhanQuyen_ItemClick;
            btnDoiMatKhau.ItemClick += BtnChangePassword_ItemClick;
            btnKetThuc.ItemClick += BtnClose_ItemClick;
            btnThongTin2.ItemClick += BtnInfor_ItemClick;
            btnSaoLuu.ItemClick += BtnSaoLuu_ItemClick;
            btnPhucHoii.ItemClick += BtnRestore_ItemClick;
            btnNhatKy.ItemClick += BtnSystem_ItemClick;

            //Tab danh mục

            btnKhuVuc.ItemClick += BtnArea_ItemClick;
            btnNCC.ItemClick += BtnSupplier_ItemClick;
            btnKhachHang.ItemClick += BtnCustomer_ItemClick;
            btnKhoHang.ItemClick += BtnKhoHang_ItemClick;
            btnHangHoa.ItemClick += BtnHangHoa_ItemClick;
            btnDonViTinh.ItemClick += BtnDVT_ItemClick;
            btnNhomHang.ItemClick += BtnGroupOfGoods_ItemClick;
            btnBoPhan.ItemClick += BtnBoPhan_ItemClick;
            btnNhanVien.ItemClick += BtnNhanVien_ItemClick;
            btnTyGia.ItemClick += BtnTyGia_ItemClick;
            btnBarcode.ItemClick += BtnBarcode_ItemClick;

            //Tab chức năng

            btnMuaHang.ItemClick += BtnBuy_ItemClick;
            btnBanHang.ItemClick += BtnSell_ItemClick;
            btnTonKho.ItemClick += BtnTonKho_ItemClick;
            btnChuyenKho.ItemClick += BtnWarehouseTransfer_ItemClick;
            btnThuTien.ItemClick += BtnThuTien_ItemClick;
            btnTraTien.ItemClick += BtnPay_ItemClick;
            btnBCKhoHang.ItemClick += BtnWarehouseReport_ItemClick;
            btnBCBanHang.ItemClick += BtnBaoCaoBanHang_ItemClick;
            btnChungTu.ItemClick += BtnChungTu_ItemClick;

            //Tab trợ giúp

            btnHoTroTrucTuyen.ItemClick += BtnHTTT_ItemClick;
            btnHDSD.ItemClick += BtnHDSD_ItemClick;
            btnLienHe.ItemClick += BtnLienHe_ItemClick;
            btnThongTin.ItemClick += BtnThongTin_ItemClick;

            PHANQUYEN(mavt);
            FormClosing += FrmMain_FormClosing;
        }

        private void BtnBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmBarcodePrinting));
            if (f == null)
            {
                frmBarcodePrinting frmBarcode = new frmBarcodePrinting();
                frmBarcode.MdiParent = this;
                frmBarcode.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            KhiFormDong();
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue";
        }
        UserBUS userBUS = new UserBUS();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            skin();

            cSystemLog c = new cSystemLog();
            c.ChucNang = "Hệ Thống";
            c.HanhDong = "Đăng Nhập";
            c.MayTinh = System.Environment.MachineName;
            c.NguoiDung = username;
            c.ThoiGian = DateTime.Now;

            lstNhatKyFinal.Add(c);
        }
        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //DialogResult dr;
        //    //dr = XtraMessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    //if (dr == DialogResult.No)
        //    //{
        //    //    e.Cancel = true;

        //    //}
        //    KhiFormDong();
        //}
        private new Form IsActive(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void ThemNhatKy_Main(cSystemLog nk)
        {
            lstNhatKyFinal.Add(nk);
        }
        private void BtnTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmCurency));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqtg = btnTyGia.Tag as VaiTro_ChucNangDTO;

                frmCurency frmRates = new frmCurency(pqtg, username);
                frmRates.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmRates.MdiParent = this;
                frmRates.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInfo_Help fInfor = new frmInfo_Help();
            fInfor.ShowDialog();
        }

        private void BtnLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmContact fInfor = new frmContact();
            fInfor.ShowDialog();
        }

        private void BtnHDSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfect.com.vn/Asset/Upload/File/QLBH%20-%20HDSD.pdf");
        }

        private void BtnHTTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            string pathTeamViewer = "C:/Program Files (x86)/TeamViewer/TeamViewer.exe";
            if (File.Exists(pathTeamViewer))
            {
                System.Diagnostics.Process.Start(pathTeamViewer);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng Cài đặt team viewer vào đường dẫn mặc định!");
                System.Diagnostics.Process.Start("https://www.teamviewer.com/en/");
            }
        }

        private void BtnChungTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmDocumentManagement));
            VaiTro_ChucNangDTO pqct = btnChungTu.Tag as VaiTro_ChucNangDTO;

            if (f == null)
            {
                frmDocumentManagement fDocumentManagement = new frmDocumentManagement(pqct, username);
                fDocumentManagement.ThemNhatKyHeThong += ThemNhatKy_Main;
                fDocumentManagement.MdiParent = this;
                fDocumentManagement.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnBaoCaoBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmSalesReport));

            VaiTro_ChucNangDTO pqbc = btnBCKhoHang.Tag as VaiTro_ChucNangDTO;

            if (f == null)
            {
                frmSalesReport fSalesReport = new frmSalesReport(pqbc, username);
                fSalesReport.ThemNhatKyHeThong += ThemNhatKy_Main;
                fSalesReport.MdiParent = this;
                fSalesReport.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnWarehouseReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmWarehouseReport));

            if (f == null)
            {
                frmWarehouseReport fWarehouseReport = new frmWarehouseReport();
                //fWarehouseReport.ThemNhatKyHeThong += ThemNhatKy_Main;
                fWarehouseReport.MdiParent = this;
                fWarehouseReport.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnPay_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmPay));
            VaiTro_ChucNangDTO pqct = btnTraTien.Tag as VaiTro_ChucNangDTO;
            if (f == null)
            {
                frmPay fPay = new frmPay(pqct, username);
                fPay.ThemNhatKyHeThong += ThemNhatKy_Main;
                fPay.MdiParent = this;
                fPay.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmCollectMoney));
            VaiTro_ChucNangDTO pqtt = btnThuTien.Tag as VaiTro_ChucNangDTO;
            if (f == null)
            {
                frmCollectMoney fCollectMoney = new frmCollectMoney(pqtt, username);
                fCollectMoney.ThemNhatKyHeThong += ThemNhatKy_Main;
                fCollectMoney.MdiParent = this;
                fCollectMoney.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnWarehouseTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmWarehouseTransfer));

            VaiTro_ChucNangDTO pqck = btnChuyenKho.Tag as VaiTro_ChucNangDTO;
            if (f == null)
            {
                frmWarehouseTransfer fWarehouseTransfer = new frmWarehouseTransfer(pqck, username);
                fWarehouseTransfer.ThemNhatKyHeThong += ThemNhatKy_Main;
                fWarehouseTransfer.MdiParent = this;
                fWarehouseTransfer.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmInventory));

            VaiTro_ChucNangDTO pqtk = btnTonKho.Tag as VaiTro_ChucNangDTO;

            if (f == null)
            {
                frmInventory fInventory = new frmInventory(pqtk, username);
                fInventory.ThemNhatKyHeThong += ThemNhatKy_Main;
                fInventory.MdiParent = this;
                fInventory.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnSell_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmSell));
            VaiTro_ChucNangDTO phanquyenBH = btnBanHang.Tag as VaiTro_ChucNangDTO;
            if (f == null)
            {
                frmSell fSell = new frmSell(phanquyenBH, username);
                fSell.ThemNhatKyHeThong += ThemNhatKy_Main;
                fSell.MdiParent = this;
                fSell.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnBuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmBuy));

            VaiTro_ChucNangDTO phanquyenMH = btnMuaHang.Tag as VaiTro_ChucNangDTO;
            if (f == null)
            {
                frmBuy fBuy = new frmBuy(phanquyenMH, username);
                fBuy.ThemNhatKyHeThong += ThemNhatKy_Main;
                fBuy.MdiParent = this;
                fBuy.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmEmployees));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqnv = btnNhanVien.Tag as VaiTro_ChucNangDTO;

                frmEmployees frmEmployees = new frmEmployees(pqnv, username);
                frmEmployees.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmEmployees.MdiParent = this;
                frmEmployees.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmDepartment));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqbp = btnBoPhan.Tag as VaiTro_ChucNangDTO;

                frmDepartment frmDepartment = new frmDepartment(pqbp, username);
                frmDepartment.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmDepartment.MdiParent = this;
                frmDepartment.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnGroupOfGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmGroupOfGoods));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqdvt = btnNhomHang.Tag as VaiTro_ChucNangDTO;

                frmGroupOfGoods fGroupOfGoods = new frmGroupOfGoods(pqdvt, username);
                fGroupOfGoods.ThemNhatKyHeThong += ThemNhatKy_Main;
                fGroupOfGoods.MdiParent = this;
                fGroupOfGoods.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnDVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmUnit));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqdvt = btnDonViTinh.Tag as VaiTro_ChucNangDTO;

                frmUnit frmUnit = new frmUnit(pqdvt, username);
                frmUnit.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmUnit.MdiParent = this;
                frmUnit.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmGoods));
            if (f == null)
            {
                VaiTro_ChucNangDTO phanquyenHH = btnHangHoa.Tag as VaiTro_ChucNangDTO;

                frmGoods frmGoods = new frmGoods(phanquyenHH, username);
                frmGoods.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmGoods.MdiParent = this;
                frmGoods.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmWarehouse));
            if (f == null)
            {
                VaiTro_ChucNangDTO phanquyenKho = btnKhoHang.Tag as VaiTro_ChucNangDTO;

                frmWarehouse frmWarehouse = new frmWarehouse(phanquyenKho, username);
                frmWarehouse.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmWarehouse.MdiParent = this;
                frmWarehouse.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmCustomer));
            if (f == null)
            {
                VaiTro_ChucNangDTO phanquyenKH = btnKhachHang.Tag as VaiTro_ChucNangDTO;

                frmCustomer frmCustomer = new frmCustomer(phanquyenKH, username);
                frmCustomer.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmCustomer.MdiParent = this;
                frmCustomer.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmSupplier));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqncc = btnNCC.Tag as VaiTro_ChucNangDTO;

                frmSupplier fSupplier = new frmSupplier(pqncc, username);
                fSupplier.ThemNhatKyHeThong += ThemNhatKy_Main;
                fSupplier.MdiParent = this;
                fSupplier.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmArea));
            if (f == null)
            {
                VaiTro_ChucNangDTO pqkv = btnKhuVuc.Tag as VaiTro_ChucNangDTO;

                frmArea frmArea = new frmArea(pqkv, username);
                frmArea.ThemNhatKyHeThong += ThemNhatKy_Main;
                frmArea.MdiParent = this;
                frmArea.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnSystem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmSystemLog));
            if (f == null)
            {
                frmSystemLog frmSystemLog = new frmSystemLog(lstNhatKyFinal);
                frmSystemLog.MdiParent = this;
                frmSystemLog.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void BtnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRestore fInfor = new frmRestore(username);
            fInfor.ThemNhatKyHeThong += ThemNhatKy_Main;
            fInfor.ShowDialog();
        }

        private void BtnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBackup fInfor = new frmBackup(username);
            fInfor.ThemNhatKyHeThong += ThemNhatKy_Main;
            fInfor.ShowDialog();
        }

        private void BtnInfor_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInfor fInfor = new frmInfor();
            fInfor.ShowDialog();
        }

        private void BtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword fChangePassword = new frmChangePassword(username);
            fChangePassword.ThemNhatKyHeThong += ThemNhatKy_Main;
            fChangePassword.ShowDialog();
        }

        private void BtnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = IsActive(typeof(frmPQ)); // kiếm tra frmRole có đang show hay không
            if (f == null) // nếu == null thì show ra
            {
                VaiTro_ChucNangDTO phanquyenPQ = btnPhanQuyen.Tag as VaiTro_ChucNangDTO;
                frmPQ formRole = new frmPQ(phanquyenPQ, username);
                formRole.ThemNhatKyHeThong += ThemNhatKy_Main;
                formRole.MdiParent = this;
                formRole.Show();
            }
            else
            {
                f.Activate(); // nếu frmRole đang show thì focus nó
            }
        }
    
        private void PHANQUYEN(string mavt)
        {
            List<VaiTro_ChucNangDTO> lstVTCN = LayListVTCN(mavt);

            ArrayList arrayRBC = rbcMain.TotalPageCategory.GetVisiblePages();
            foreach (RibbonPage page in arrayRBC)
            {
                VaiTro_ChucNangDTO VTofPage = LayVTCN(page.Name, lstVTCN);
                if (VTofPage != null)
                {
                    page.Visible = VTofPage.TruyCap == 0 ? false : true;
                }

                foreach (RibbonPageGroup group in page.Groups)
                {
                    VaiTro_ChucNangDTO VTofPageGroup = LayVTCN(group.Name, lstVTCN);
                    if (VTofPageGroup != null)
                    {
                        group.Visible = VTofPageGroup.TruyCap == 0 ? false : true;
                    }

                    foreach (BarItemLink link in group.ItemLinks)
                    {
                        VaiTro_ChucNangDTO VTofButton = LayVTCN(link.Item.Name, lstVTCN);
                        if (VTofButton != null)
                        {
                            link.Item.Tag = VTofButton;
                            link.Item.Enabled = VTofButton.TruyCap == 0 ? false : true;
                        }
                    }
                }
            }

        }
        private VaiTro_ChucNangDTO LayVTCN(string name, List<VaiTro_ChucNangDTO> lstVTCN)
        {
            foreach (VaiTro_ChucNangDTO vc in lstVTCN)
            {
                if (string.Compare(vc.TenTrongHeThong, name) == 0)
                {
                    return vc;
                }
            }
            return null;
        }

        private static List<VaiTro_ChucNangDTO> LayListVTCN(string mavt)
        {
            string sql = "select vc.*, cn.TenTrongHeThong " +
                            "from VAITRO_CHUCNANG vc, CHUCNANG cn " +
                            "where vc.MaChucNang = cn.MaChucNang and vc.MaVaiTro = '" + mavt + "'";

            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            List<VaiTro_ChucNangDTO> lstVTCN = new List<VaiTro_ChucNangDTO>();

            DataTable dt = connectionDB.Select(CommandType.Text, sql);
            foreach (DataRow row in dt.Rows)
            {
                VaiTro_ChucNangDTO vc = new VaiTro_ChucNangDTO();
                vc.MaVaiTro = row["MaVaiTro"].ToString();
                vc.MaChucNang = int.Parse(row["MaChucNang"].ToString());
                vc.TatCa = bool.Parse(row["TatCa"].ToString()) == true ? 1 : 0;
                vc.TruyCap = bool.Parse(row["TruyCap"].ToString()) == true ? 1 : 0;
                vc.Them = bool.Parse(row["Them"].ToString()) == true ? 1 : 0;
                vc.Xoa = bool.Parse(row["Xoa"].ToString()) == true ? 1 : 0;
                vc.Sua = bool.Parse(row["Sua"].ToString()) == true ? 1 : 0;
                vc.InAn = bool.Parse(row["InAn"].ToString()) == true ? 1 : 0;
                vc.Nhap = bool.Parse(row["Nhap"].ToString()) == true ? 1 : 0;
                vc.Xuat = bool.Parse(row["Xuat"].ToString()) == true ? 1 : 0;
                vc.TenTrongHeThong = row["TenTrongHeThong"].ToString();

                lstVTCN.Add(vc);
            }
            return lstVTCN;
        }
    }
}