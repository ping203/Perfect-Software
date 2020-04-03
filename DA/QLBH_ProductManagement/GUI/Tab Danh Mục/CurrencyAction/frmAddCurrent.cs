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
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.CurrencyAction
{
    public partial class frmAddCurrent : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCurrent()
        {
            InitializeComponent();
        }
        CurrencyBUS current = new CurrencyBUS();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            CurrencyDTO cur = new CurrencyDTO();
            cur.iMaTT = txtMa.Text;
            cur.iTenTT = txtTen.Text;
            cur.iTGQD = (float)Convert.ToDouble(calTyGia.Text);

            int check = current.InsertCurrent(cur);
            if (check == 1)
            {
                XtraMessageBox.Show("Thêm tỷ giá thành công");
                this.Close();
            }
            else
                XtraMessageBox.Show("Thêm tỷ giá thất bại");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCurrent_Load(object sender, EventArgs e)
        {
            check.Checked = true;
        }
    }
}