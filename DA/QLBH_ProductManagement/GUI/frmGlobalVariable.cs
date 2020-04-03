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
using DevExpress.XtraGrid;
using System.Diagnostics;
using DevExpress.XtraTreeList;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmGlobalVariable : DevExpress.XtraEditors.XtraForm
    { 
        public frmGlobalVariable()
        {
            InitializeComponent();
        }

        public class BienToanCuc
        {
            public static string username;

            private XtraSaveFileDialog xtraSaveFileDialog = new XtraSaveFileDialog();

            public BienToanCuc()
            {
                xtraSaveFileDialog.Filter = "Microsoft Excel (2003)(*.xls)|*.xls|Microsoft Excel (2010) (*.xlsx)|*.xlsx |PDF File (*.pdf)|*.pdf";
                xtraSaveFileDialog.Title = "Save as";
                xtraSaveFileDialog.FileName = "document";
            }

            public void xuatFile(GridControl grc)
            {
                Cursor.Current = Cursors.WaitCursor;
            
                DialogResult dr = xtraSaveFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string FilePath = xtraSaveFileDialog.FileName;
                    string fileExtension = new FileInfo(FilePath).Extension;

                    switch (fileExtension)
                    {
                        case ".xls":
                            grc.ExportToXls(FilePath);
                            break;
                        case ".xlsx":
                            grc.ExportToXlsx(FilePath);
                            break;
                        case ".pdf":
                            grc.ExportToPdf(FilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(FilePath))
                    {

                        if (XtraMessageBox.Show("Bạn có muốn mở file lên không?", "Mở File Đã Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                Process.Start(FilePath);
                            }
                            catch
                            {
                                XtraMessageBox.Show("Không thể mở file");
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("File chưa được lưu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            public void xuatFileTree(TreeList tree)
            {
                Cursor.Current = Cursors.WaitCursor;

                DialogResult dr = xtraSaveFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string FilePath = xtraSaveFileDialog.FileName;
                    string fileExtension = new FileInfo(FilePath).Extension;

                    switch (fileExtension)
                    {
                        case ".xls":
                            tree.ExportToXls(FilePath);
                            break;
                        case ".xlsx":
                            tree.ExportToXlsx(FilePath);
                            break;
                        case ".pdf":
                            tree.ExportToPdf(FilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(FilePath))
                    {

                        if (XtraMessageBox.Show("Bạn có muốn mở file lên không?", "Mở File Đã Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                Process.Start(FilePath);
                            }
                            catch
                            {
                                XtraMessageBox.Show("Không thể mở file");
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("File chưa được lưu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            public void In(GridControl grc)
            {
                if (!grc.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("Lỗi không thể In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    grc.ShowPrintPreview();
                }
            }
        }
    }
}