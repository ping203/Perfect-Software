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
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmDocumentManagement : DevExpress.XtraEditors.XtraForm
    {
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Chứng Từ";
        public frmDocumentManagement(VaiTro_ChucNangDTO vtch, string un)
        {
            InitializeComponent();
            user = un;
        }
        private void AddNhatKy(string hanhDong, string cn)
        {

            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = cn;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }
        TheKhoBUS tkBUS = new TheKhoBUS();
        private void grcQuanLyChungTu_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");
            dtTu.ReadOnly = true;
            dtDen.ReadOnly = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
           
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            var text = rdChoose.Properties.Items[rdChoose.SelectedIndex].Description;
            if (text == "Tất cả")
            {
                AddNhatKy("Xem", TenChucNang);
                btnClose.DataSource = tkBUS.getListChungTu(0 , dateDen, dateDen);
            }
            else
            {
                btnClose.DataSource = tkBUS.getListChungTu(1, dateTu, dateDen);
            }
           
        }

        private void rdChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = rdChoose.Properties.Items[rdChoose.SelectedIndex].Description;
            if(text == "Tất cả")
            {
                dtTu.ReadOnly = true;
                dtDen.ReadOnly = true;
            }
            else
            {
                dtTu.ReadOnly = false;
                dtDen.ReadOnly = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}