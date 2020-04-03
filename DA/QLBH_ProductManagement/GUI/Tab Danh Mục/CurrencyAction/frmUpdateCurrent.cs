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

namespace QLBH_ProductManagement.GUI.CurrencyAction
{
    public partial class frmUpdateCurrent : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateCurrent()
        {
            InitializeComponent();
        }
        string maPhieuNhan;
        public frmUpdateCurrent(string maPhieu) : this()
        {
            maPhieuNhan = maPhieu;


        }
        CurrencyBUS curBUS = new CurrencyBUS();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CurrencyDTO curDTO = new CurrencyDTO();

            curDTO.iMaTT = txtMa.Text;
            curDTO.iTenTT = txtTen.Text;
            curDTO.iTGQD = (float)Convert.ToDouble(calTyGia.Text);
            curDTO.iActive = check.Checked;

            int checkUpdate = curBUS.UpdateCur(curDTO);

            if (checkUpdate == 1)
            {
                XtraMessageBox.Show("Update Thành Công");
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Update Thất Bại");
            }
        }

        private void frmUpdateCurrent_Load_1(object sender, EventArgs e)
        {
            CurrencyDTO curDTO = curBUS.getCurrentcy(maPhieuNhan);

            txtMa.Text = curDTO.iMaTT;
            txtTen.Text = curDTO.iTenTT;
            calTyGia.Text = curDTO.iTGQD.ToString();
            check.Checked = curDTO.iActive;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}