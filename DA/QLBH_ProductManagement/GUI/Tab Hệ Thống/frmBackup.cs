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
using System.IO;
using QLBH_ProductManagement.DAO;
using System.Diagnostics;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Sao Lưu";

        public frmBackup(string un)
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
        private void frmBackup_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            GenerateTxtTenTapTin();
            fbdSaoLuu.SelectedPath = "D:\\";
            txtDuongDan.Text = fbdSaoLuu.SelectedPath;
        }
        private void GenerateTxtTenTapTin()
        {
            string db = "PM_QLBH";

            string date = DateTime.Now.Day.ToString() + "." +
                DateTime.Now.Month.ToString() + "." +
                DateTime.Now.Year.ToString();

            string time = DateTime.Now.Hour.ToString() + "." +
                DateTime.Now.Minute.ToString();

            string txt = db + "_" + date + "_" + time + ".bak";

            txtTenTapTin.Text = txt;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string duongDanFinal = "";
            string duongDan = txtDuongDan.Text;
            string tenTapTin = txtTenTapTin.Text;
            string Database = "PM_QLBH";

            if (tenTapTin.Contains(":") || tenTapTin.Contains("\\") || tenTapTin.Contains("/") ||
                tenTapTin.Contains("*") || tenTapTin.Contains("?") || tenTapTin.Contains("\"") ||
                tenTapTin.Contains("<") || tenTapTin.Contains(">") || tenTapTin.Contains("|"))
            {
                string t = "\\ / : * ? \" < > |";
                XtraMessageBox.Show(string.Format("A name can't contain any of the following characters:\n\t{0}", t), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(duongDan) == false)
            {
                XtraMessageBox.Show("Thư mục không tồn tại, vui lòng chọn lại!");
                return;
            }

            duongDanFinal = tenTapTin.EndsWith(".bak") == true ? (duongDan + "\\" + tenTapTin) : (duongDan + "\\" + tenTapTin + ".bak");

            //Nếu file tồn tại thì xóa file cũ
            if (File.Exists(duongDanFinal))
            {
                File.Delete(duongDanFinal);
            }
            ConnectionDB.BackUpDatabase(duongDanFinal, Database);

            AddNhatKy("Thực Hiện");

            Process.Start(duongDan);
            lblSaoLuu.Text = "Sao lưu thành công!";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdSaoLuu.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDuongDan.Text = fbdSaoLuu.SelectedPath;
            }
        }
    }
}