namespace QLBH_ProductManagement.GUI
{
    partial class frmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.lblSaoLuu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTapTin = new DevExpress.XtraEditors.TextEdit();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.cbGhiDe = new DevExpress.XtraEditors.CheckEdit();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.fbdSaoLuu = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGhiDe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaoLuu
            // 
            resources.ApplyResources(this.lblSaoLuu, "lblSaoLuu");
            this.lblSaoLuu.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblSaoLuu.Appearance.Font")));
            this.lblSaoLuu.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSaoLuu.Appearance.Options.UseFont = true;
            this.lblSaoLuu.Appearance.Options.UseForeColor = true;
            this.lblSaoLuu.Name = "lblSaoLuu";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // txt
            // 
            resources.ApplyResources(this.txt, "txt");
            this.txt.Name = "txt";
            // 
            // txtTenTapTin
            // 
            resources.ApplyResources(this.txtTenTapTin, "txtTenTapTin");
            this.txtTenTapTin.Name = "txtTenTapTin";
            // 
            // txtDuongDan
            // 
            resources.ApplyResources(this.txtDuongDan, "txtDuongDan");
            this.txtDuongDan.Name = "txtDuongDan";
            // 
            // btnOpenFile
            // 
            resources.ApplyResources(this.btnOpenFile, "btnOpenFile");
            this.btnOpenFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.ImageOptions.Image")));
            this.btnOpenFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbGhiDe
            // 
            resources.ApplyResources(this.cbGhiDe, "cbGhiDe");
            this.cbGhiDe.Name = "cbGhiDe";
            this.cbGhiDe.Properties.Caption = resources.GetString("cbGhiDe.Properties.Caption");
            this.cbGhiDe.Properties.DisplayValueChecked = resources.GetString("cbGhiDe.Properties.DisplayValueChecked");
            this.cbGhiDe.Properties.DisplayValueGrayed = resources.GetString("cbGhiDe.Properties.DisplayValueGrayed");
            this.cbGhiDe.Properties.DisplayValueUnchecked = resources.GetString("cbGhiDe.Properties.DisplayValueUnchecked");
            this.cbGhiDe.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("cbGhiDe.Properties.GlyphVerticalAlignment")));
            // 
            // btnThucHien
            // 
            resources.ApplyResources(this.btnThucHien, "btnThucHien");
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnDong
            // 
            resources.ApplyResources(this.btnDong, "btnDong");
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Name = "btnDong";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // fbdSaoLuu
            // 
            resources.ApplyResources(this.fbdSaoLuu, "fbdSaoLuu");
            // 
            // frmBackup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.cbGhiDe);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblSaoLuu);
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGhiDe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSaoLuu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl txt;
        private DevExpress.XtraEditors.TextEdit txtTenTapTin;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private DevExpress.XtraEditors.CheckEdit cbGhiDe;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog fbdSaoLuu;
    }
}