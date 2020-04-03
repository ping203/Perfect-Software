using System;
using System.Windows.Forms;
using System.IO;
using QLBH_ProductManagement.DAO;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Phục Hồi Dữ Liệu";

        public frmRestore(string un)
        {
            InitializeComponent();
            user = un;
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
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string path = txtTenTapTin.Text;
            string Database = "PM_QLBH";

            if (File.Exists(path) == false)
            {
                MessageBox.Show("Tập tin không tồn tại, vui lòng chọn lại");
                return;
            }
            else
            {
                ConnectionDB.RestoreDatabase(path, Database);
                AddNhatKy("Thực Hiện");
                lblPhucHoi.Text = "Phục hồi thành công!";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile.Filter = "BackUp Files (*.bak)|*.bak|All files (*.*)|*.*";

            DialogResult result = OpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtTenTapTin.Text = OpenFile.FileName;
            }
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            string csdl = "PM_QLBH";
            txtCSDL.Text = csdl;
            txtCSDL.ReadOnly = true;
        }
    }
}