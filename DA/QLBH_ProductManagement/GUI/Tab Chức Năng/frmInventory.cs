using System;
using System.Data;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmInventory : DevExpress.XtraEditors.XtraForm
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Tồn Kho";

        public frmInventory(VaiTro_ChucNangDTO pqtk, string un)
        {
            InitializeComponent();
            user = un;
            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqtk != null)
            {
                if (pqtk.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                }
            }

        }
        private void AddNhatKy(string hanhDong)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        TonKhoBUS tonKhoBus = new TonKhoBUS();
        WarehouseBUS wareBUS = new WarehouseBUS();
        private void frmInventory_Load(object sender, EventArgs e)
        {
            // load Tất cả các kho có trong tồn kho

            DataTable data = tonKhoBus.getTonKho();
            grvTonKho.DataSource = data;
            AddNhatKy("Xem");
            loadKhoHang();


        }

        public void loadKhoHang()
        {
            DataTable data = new DataTable();
            data = wareBUS.LoadKhoHang();

            cbKhoHang.Properties.DataSource = data;
            cbKhoHang.Properties.DisplayMember = "TenKho";
            cbKhoHang.Properties.ValueMember = "MaKho";

        }

        private void cbKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            string maKho = cbKhoHang.EditValue != null ? cbKhoHang.EditValue.ToString() : null;

            DataTable data = tonKhoBus.getTonKhoFromMaKho(maKho);
            grvTonKho.DataSource = data;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            bienToanCuc.xuatFile(grvTonKho);
            AddNhatKy("Xuất");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grvTonKho);
            AddNhatKy("In");
        }
    }
}