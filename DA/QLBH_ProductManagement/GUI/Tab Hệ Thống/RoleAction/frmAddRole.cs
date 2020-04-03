using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.DAO;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Windows.Forms;

namespace QLBH_ProductManagement.GUI.RoleAction
{
    public partial class frmAddRole : DevExpress.XtraEditors.XtraForm
    {
        VaiTroBUS vaiTroBUS = new VaiTroBUS();
        VaiTro_ChucNangBUS vaiTro_ChucNangBUS = new VaiTro_ChucNangBUS();

        int Cur_State = 0;
        int checkNullVTCN = 0;

        //event thêm thành công
        public delegate void dVaiTro();
        public event dVaiTro ThemThanhCong;
        public event dVaiTro CapNhatThanhCong;

        public frmAddRole()
        {
            InitializeComponent();
   
            Cur_State = 1;

            cHUCNANGTableAdapter.Fill(pM_QLBH.CHUCNANG);

            tlQuyenHan.CellValueChanging += tlQuyenHan_CellValueChanging;
            Load += FrmThemVaiTro_Load;
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;
            this.Text = "Thêm Vai Trò";
        }
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            VaiTro vt = new VaiTro();
            vt.MaVaiTro = txtMaVaiTro.Text;
            vt.TenVaiTro = txtTenVaiTro.Text;
            vt.DienGiai = txtDienGiai.Text;
            vt.KichHoat = ckbKichHoat.Checked;

            if (string.IsNullOrEmpty(vt.TenVaiTro))
            {
                XtraMessageBox.Show("Không được để trống Tên Vai Trò", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //thêm
                if (Cur_State == 1)
                {
                    int kq = vaiTroBUS.ThemVaiTro(vt);
                    if (kq >= 1)
                    {
                        ThemVaiTroChucNang(vt.MaVaiTro);
                        ThemThanhCong();
                        XtraMessageBox.Show("Thêm thành công !!!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại !!!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //sửa
                else if (Cur_State == 0)
                {
                    int kq = vaiTroBUS.SuaVaiTro(vt);
                    if (kq >= 1)
                    {
                        if (checkNullVTCN == 1)
                            ThemVaiTroChucNang(vt.MaVaiTro);
                        else
                            SuaVaiTroChucNang(vt.MaVaiTro);
                        CapNhatThanhCong();
                        XtraMessageBox.Show("Cập nhật thành công !!!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật thất bại !!!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmThemVaiTro_Load(object sender, EventArgs e)
        {
            txtMaVaiTro.Text = ConnectionDB.GenerateMa("sp_LayMaVaiTro");
            txtMaVaiTro.ReadOnly = true;
        }    
        public frmAddRole(VaiTro vt)
        {
            InitializeComponent();
            Cur_State = 0;

            tlQuyenHan.CellValueChanging += tlQuyenHan_CellValueChanging;

            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;

            this.Text = "Sửa Vai Trò";

            FillDuLieu(vt);
        }
        private void tlQuyenHan_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            var col = e.Column.FieldName;
            if (col == "TatCa")
            {
                var tmp = tlQuyenHan.EditingValue;

                if ((bool)tmp == true)
                {
                    tlQuyenHan.FocusedNode.SetValue(2, false);
                    tlQuyenHan.FocusedNode.SetValue(3, false);
                    tlQuyenHan.FocusedNode.SetValue(4, false);
                    tlQuyenHan.FocusedNode.SetValue(5, false);
                    tlQuyenHan.FocusedNode.SetValue(6, false);
                    tlQuyenHan.FocusedNode.SetValue(7, false);
                    tlQuyenHan.FocusedNode.SetValue(8, false);
                }
                else if ((bool)tmp == false)
                {
                    tlQuyenHan.FocusedNode.SetValue(2, true);
                    tlQuyenHan.FocusedNode.SetValue(3, true);
                    tlQuyenHan.FocusedNode.SetValue(4, true);
                    tlQuyenHan.FocusedNode.SetValue(5, true);
                    tlQuyenHan.FocusedNode.SetValue(6, true);
                    tlQuyenHan.FocusedNode.SetValue(7, true);
                    tlQuyenHan.FocusedNode.SetValue(8, true);
                }
            }
            else
            {
                var tmp = tlQuyenHan.EditingValue;

                if ((bool)tmp == true)
                {
                    tlQuyenHan.FocusedNode.SetValue(1, false);
                }
            }
        }
        private void FillDuLieu(VaiTro vt)
        {
            txtMaVaiTro.Text = vt.MaVaiTro;
            txtMaVaiTro.ReadOnly = true;
            txtTenVaiTro.Text = vt.TenVaiTro;
            txtDienGiai.Text = vt.DienGiai;
            ckbKichHoat.Checked = vt.KichHoat;

            string sql = string.Format("select vc.MaChucNang, cn.TenChucNang, vc.TatCa, vc.TruyCap, vc.Them, vc.Xoa, vc.Sua, vc.InAn, vc.Nhap, vc.Xuat, cn.MaCha" +
                                    " from VAITRO_CHUCNANG vc, CHUCNANG cn" +
                                    " where vc.MaChucNang = cn.MaChucNang and vc.MaVaiTro = '{0}'", vt.MaVaiTro);

            DataTable dt = ConnectionDB.LayDuLieuBang(sql);

            if (dt.Rows.Count == 0)
            {
                dt = ConnectionDB.LayDuLieuBang("select * from CHUCNANG");
                checkNullVTCN = 1;
            }

            tlQuyenHan.DataMember = null;
            tlQuyenHan.DataSource = dt;
            tlQuyenHan.KeyFieldName = "MaChucNang";
            tlQuyenHan.ParentFieldName = "MaCha";
        }
        private void SuaVaiTroChucNang(string maVaiTro)
        {
            List<TreeListNode> nodes = tlQuyenHan.GetNodeList();
            string key = tlQuyenHan.KeyFieldName.ToString();

            foreach (TreeListNode node in nodes)
            {
                VaiTro_ChucNangDTO vtcn = new VaiTro_ChucNangDTO();
                vtcn.MaVaiTro = maVaiTro;
                vtcn.MaChucNang = int.Parse(node.GetValue(key).ToString());

                vtcn.TatCa = (bool)node.GetValue("TatCa") == true ? 1 : 0;
                vtcn.TruyCap = (bool)node.GetValue("TruyCap") == true ? 1 : 0;
                vtcn.Them = (bool)node.GetValue("Them") == true ? 1 : 0;
                vtcn.Xoa = (bool)node.GetValue("Xoa") == true ? 1 : 0;
                vtcn.Sua = (bool)node.GetValue("Sua") == true ? 1 : 0;
                vtcn.InAn = (bool)node.GetValue("InAn") == true ? 1 : 0;
                vtcn.Nhap = (bool)node.GetValue("Nhap") == true ? 1 : 0;
                vtcn.Xuat = (bool)node.GetValue("Xuat") == true ? 1 : 0;

                vaiTro_ChucNangBUS.SuaVTCN(vtcn);
            }
        }
        private void ThemVaiTroChucNang(string maVaiTro)
        {
            List<TreeListNode> nodes = tlQuyenHan.GetNodeList();
            string key = tlQuyenHan.KeyFieldName.ToString();

            foreach (TreeListNode node in nodes)
            {
                VaiTro_ChucNangDTO vtcn = new VaiTro_ChucNangDTO();
                vtcn.MaVaiTro = maVaiTro;
                vtcn.MaChucNang = int.Parse(node.GetValue(key).ToString());

                vtcn.TatCa = (bool)node.GetValue("TatCa") == true ? 1 : 0;
                vtcn.TruyCap = (bool)node.GetValue("TruyCap") == true ? 1 : 0;
                vtcn.Them = (bool)node.GetValue("Them") == true ? 1 : 0;
                vtcn.Xoa = (bool)node.GetValue("Xoa") == true ? 1 : 0;
                vtcn.Sua = (bool)node.GetValue("Sua") == true ? 1 : 0;
                vtcn.InAn = (bool)node.GetValue("InAn") == true ? 1 : 0;
                vtcn.Nhap = (bool)node.GetValue("Nhap") == true ? 1 : 0;
                vtcn.Xuat = (bool)node.GetValue("Xuat") == true ? 1 : 0;

                vaiTro_ChucNangBUS.ThemVTCN(vtcn);
            }
        }
    }
}