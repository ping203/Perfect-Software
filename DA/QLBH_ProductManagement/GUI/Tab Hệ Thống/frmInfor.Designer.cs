namespace QLBH_ProductManagement.GUI
{
    partial class frmInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfor));
            this.btnKetThuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.txtGPKD = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cbLinhVuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnKetThuc.Appearance.Options.UseForeColor = true;
            this.btnKetThuc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKetThuc.ImageOptions.SvgImage")));
            this.btnKetThuc.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnKetThuc.Location = new System.Drawing.Point(187, 281);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(78, 23);
            this.btnKetThuc.TabIndex = 66;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnDongY.Appearance.Options.UseForeColor = true;
            this.btnDongY.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDongY.ImageOptions.SvgImage")));
            this.btnDongY.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDongY.Location = new System.Drawing.Point(94, 281);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(74, 23);
            this.btnDongY.TabIndex = 65;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtGPKD
            // 
            this.txtGPKD.Location = new System.Drawing.Point(94, 254);
            this.txtGPKD.Name = "txtGPKD";
            this.txtGPKD.Size = new System.Drawing.Size(405, 21);
            this.txtGPKD.TabIndex = 62;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 257);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(26, 13);
            this.labelControl10.TabIndex = 61;
            this.labelControl10.Text = "GPKD";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(94, 227);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(183, 21);
            this.txtMaSoThue.TabIndex = 60;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 230);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 59;
            this.labelControl6.Text = "Mã số thuế";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 203);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "Lĩnh vực";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 21);
            this.txtEmail.TabIndex = 57;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 176);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 56;
            this.labelControl8.Text = "Email";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(94, 146);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(183, 21);
            this.txtWebsite.TabIndex = 55;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 149);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 54;
            this.labelControl9.Text = "Website";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(94, 119);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(183, 21);
            this.txtFax.TabIndex = 53;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 13);
            this.labelControl4.TabIndex = 52;
            this.labelControl4.Text = "Fax";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(94, 92);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(183, 21);
            this.txtDienThoai.TabIndex = 51;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "Điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(94, 65);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(405, 21);
            this.txtDiaChi.TabIndex = 49;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Location = new System.Drawing.Point(94, 38);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.ReadOnly = true;
            this.txtTenDonVi.Size = new System.Drawing.Size(405, 21);
            this.txtTenDonVi.TabIndex = 47;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "Tên đơn vị";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 25);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "THÔNG TIN";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(283, 92);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(216, 156);
            this.pictureEdit1.TabIndex = 67;
            // 
            // cbLinhVuc
            // 
            this.cbLinhVuc.FormattingEnabled = true;
            this.cbLinhVuc.Location = new System.Drawing.Point(94, 200);
            this.cbLinhVuc.Name = "cbLinhVuc";
            this.cbLinhVuc.Size = new System.Drawing.Size(183, 21);
            this.cbLinhVuc.TabIndex = 68;
            // 
            // frmInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 315);
            this.Controls.Add(this.cbLinhVuc);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtGPKD);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtMaSoThue);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTenDonVi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.frmInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKetThuc;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private System.Windows.Forms.TextBox txtGPKD;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtWebsite;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtFax;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.ComboBox cbLinhVuc;
    }
}