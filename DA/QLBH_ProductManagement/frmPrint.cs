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

namespace QLBH_ProductManagement
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintReportThu(PhieuThuTien ptTien)
        {
            ReportPhieuThuChi reportPhieuThuChi = new ReportPhieuThuChi();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in reportPhieuThuChi.Parameters)
            {
                p.Visible = false;
            }
            reportPhieuThuChi.initDataThu(ptTien);
            docPrint.DocumentSource = reportPhieuThuChi;

            reportPhieuThuChi.CreateDocument();
        }

        public void PrintReportChi(PhieuChiTien pcTien)
        {
            ReportPhieuThuChi reportPhieuThuChi = new ReportPhieuThuChi();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in reportPhieuThuChi.Parameters)
            {
                p.Visible = false;
            }
            reportPhieuThuChi.initDataChi(pcTien);
            docPrint.DocumentSource = reportPhieuThuChi;

            reportPhieuThuChi.CreateDocument();
        }
    }
}