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

namespace QLBH_ProductManagement.GUI.UnitAction
{
    public partial class frmAddUnit : DevExpress.XtraEditors.XtraForm
    {
        UnitBUS b_unit = new UnitBUS();
        public frmAddUnit()
        {
            InitializeComponent();
        }

        private void frmAddUnit_Load(object sender, EventArgs e)
        {
            txtMaDVT.ReadOnly = true;
            txtMaDVT.Text = b_unit.IDAuto();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UnitDTO unit = new UnitDTO();
            unit.iTen = txtTen.Text;
            unit.iGhiChu = txtGhiChu.Text;
            unit.iActive = bool.Parse(checkBoxActive.Checked.ToString());
            int check = b_unit.insertUnit(unit);
            if (check == 1)
            {
                XtraMessageBox.Show("Thêm đơn vị tính " + unit.iMaDVT + " thành công!!!");
                frmUnit.statusAction = 1;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Thêm đơn vị tính " + unit.iMaDVT + " thất bại!!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}