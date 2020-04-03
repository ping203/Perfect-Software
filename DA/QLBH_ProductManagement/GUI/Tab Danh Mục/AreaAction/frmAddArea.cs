using System;
using QLBH_ProductManagement.BUS;
using System.Windows.Forms;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using DevExpress.XtraEditors;

namespace QLBH_ProductManagement.GUI.AreaAction
{
    public partial class frmAddArea : DevExpress.XtraEditors.XtraForm
    {
        public frmAddArea()
        {
            InitializeComponent();
        }


        AreaBUS arBus = new AreaBUS();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string maKV = txtMaKV.Text;
            string tenKV = txtTenKV.Text;
            string ghiChu = txtGhiChu.Text;
            bool active = bool.Parse(checkAc.Checked.ToString());



            if (tenKV == "")
            {
                XtraMessageBox.Show("Trường Name không được để trống");
                txtTenKV.Focus();

            }
            else
            {
                int check = arBus.InsertArea(maKV, tenKV, ghiChu, active);
                if (check == 1)
                {
                    XtraMessageBox.Show("INSERT thành công");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("INSERT thất bại");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddArea_Load(object sender, EventArgs e)
        {
            string maLast = arBus.getLastMaKV();
            txtMaKV.Text = SetIDAutomatic.getIDAutomatic2(maLast);
            txtMaKV.ReadOnly = true;
        }
    }
}