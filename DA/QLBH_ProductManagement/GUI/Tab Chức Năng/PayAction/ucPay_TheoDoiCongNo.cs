using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI.PayAction
{
    public partial class ucPay_TheoDoiCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();

        public ucPay_TheoDoiCongNo()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                bienToanCuc.In(grcBangCongNo);
            }
            else
            {
                bienToanCuc.In(grcDanhSachHangHoaChiTiet);
            }
        }
        SupplierBUS supBUS = new SupplierBUS();

        public void loadNCC()
        {
             
            cbNCC.Properties.DataSource = supBUS.getNCCBanHang();
            cbNCC.Properties.DisplayMember = "TenNCC";
            cbNCC.Properties.ValueMember = "MaNCC";
            cbNCC.ItemIndex = 1;
        }


        private void cbNCC_EditValueChanged(object sender, EventArgs e)
        {
            var id = cbNCC.EditValue != null ? cbNCC.EditValue.ToString() : null;
            cbMa.Text = id;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                bienToanCuc.xuatFile(grcBangCongNo);
            }
            else
            {
                bienToanCuc.xuatFile(grcDanhSachHangHoaChiTiet);
            }
        }

        BangTheoDoiCongNoBUS theoDoiCongNo = new BangTheoDoiCongNoBUS();
        DateTime a = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        private void grcBangCongNo_Load(object sender, EventArgs e)
        {
           
            grcBangCongNo.DataSource = theoDoiCongNo.getListBangTheoDoiCongNoBuy(a, a, 0);
            dtTu.Text = dtDen.Text = DateTime.Now.ToString("M/d/yyyy");

            loadNCC();
        }

        TheoHangHoaBuyBUS theoHangHoaBUS = new TheoHangHoaBuyBUS();
        public void LoadTheoHangHoa()
        {
            grcDanhSachHangHoaChiTiet.DataSource = theoHangHoaBUS.getChiTietHoangHoaBuy();
        }

        private void grcDanhSachHangHoaChiTiet_Load(object sender, EventArgs e)
        {
            LoadTheoHangHoa();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime dateTu = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtTu.Text));
            DateTime dateDen = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtDen.Text));

            if(xtraTabControl1.SelectedTabPage.Name == "BangCongNo")
            {
                if(cbMa.Text == "All")
                {
                    grcBangCongNo.DataSource = theoDoiCongNo.getListBangTheoDoiCongNoBuy(dateTu, dateDen, 1);
                }
                else
                {
                    grcBangCongNo.DataSource = theoDoiCongNo.getListBangTheoDoiTheoNhomNCC(cbMa.Text, dateTu, dateDen, 1);
                }
            }
            else
            {
                if (cbMa.Text == "All")
                {
                    grcDanhSachHangHoaChiTiet.DataSource = theoHangHoaBUS.getChiTietHoangHoaBuyFromDate(dateTu, dateDen);
                }
                else
                {
                    grcDanhSachHangHoaChiTiet.DataSource = theoHangHoaBUS.getChiTietHoangHoaBuyFromDateAndNCC(dateTu, dateDen, cbMa.Text);
                }
            }
        }

        
    }
}
