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
    public partial class frmUpdateUnit : DevExpress.XtraEditors.XtraForm
    {
        UnitDTO unit = new UnitDTO();
        UnitBUS b_unit = new UnitBUS();

        public frmUpdateUnit()
        {
            InitializeComponent();
        }

        public frmUpdateUnit(UnitDTO unitDTO) : this()
        {
            unit.iMaDVT = unitDTO.iMaDVT;
            unit.iTen = unitDTO.iTen;
            unit.iGhiChu = unitDTO.iGhiChu;
            unit.iActive = unitDTO.iActive;
        }

        private void frmUpdateUnit_Load(object sender, EventArgs e)
        {
            txtMaDVT.ReadOnly = true;

            txtMaDVT.Text = unit.iMaDVT;
            txtTen.Text = unit.iTen;
            txtGhiChu.Text = unit.iGhiChu;
            checkboxActive.Checked = unit.iActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            unit.iTen = txtTen.Text;
            unit.iGhiChu = txtGhiChu.Text;
            unit.iActive = bool.Parse(checkboxActive.Checked.ToString());

            int check = b_unit.updateUnit(unit);

            if (check == 1)
            {

                XtraMessageBox.Show("Cập nhật đơn vị tính " + unit.iMaDVT + " thành công!!");
                frmUnit.statusAction = 1;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Cập nhật đơn vị tính " + unit.iMaDVT + " thất bại!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}