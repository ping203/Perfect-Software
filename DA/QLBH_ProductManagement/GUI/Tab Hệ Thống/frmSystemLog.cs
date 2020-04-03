using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBH_ProductManagement.DTO;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmSystemLog : DevExpress.XtraEditors.XtraForm
    {
        List<cSystemLog> lstDiary;

        BienToanCuc bienToanCuc = new BienToanCuc();
        public frmSystemLog(List<cSystemLog> lstnk)
        {
            InitializeComponent();
            lstDiary = lstnk;

            FillSystemLog(lstDiary);
        }
        private void FillSystemLog(List<cSystemLog> lstDiary)
        {
            List<cSystemLog> listST = new List<cSystemLog>();
            foreach (cSystemLog c in lstDiary)
            {
                cSystemLog x = new cSystemLog();
                x.NguoiDung = c.NguoiDung;
                x.MayTinh = c.MayTinh;
                x.ThoiGian = c.ThoiGian;
                x.HanhDong = c.HanhDong;
                x.DoiTuong = c.DoiTuong;
                x.ChucNang = c.ChucNang;
                listST.Add(x);
            }
            grcSystemLog.DataSource = listST;
        }
        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bienToanCuc.xuatFile(grcSystemLog);
        }

        private void btnClose_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}