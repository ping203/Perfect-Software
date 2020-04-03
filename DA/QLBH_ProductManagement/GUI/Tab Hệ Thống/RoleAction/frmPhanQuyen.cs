﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraTreeList;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using TreeNode = System.Windows.Forms.TreeNode;
using DevExpress.XtraGrid.Views.Grid;

namespace QLBH_ProductManagement.GUI.RoleAction
{
    public partial class frmPQ : DevExpress.XtraEditors.XtraForm
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Phân Quyền";

        VaiTroBUS vaiTroBUS = new VaiTroBUS();
        NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
        VaiTro_ChucNangBUS VaiTro_ChucNangBUS = new VaiTro_ChucNangBUS();

        string MaVaiTro = null;
        string IDUser = null;
        int numChildNode = 0;
        string TenVT = null;
        string TenDangNhap = null;

        public frmPQ(VaiTro_ChucNangDTO phanquyenPQ, string un)
        {
            InitializeComponent();

            user = un;

            Load += FrmPhanQuyen_Load;

            this.ContextMenuStrip = ctmsPhanQuyen;

            // ẩn context menu strip khi click vào header column
            gvDsUser.MouseUp += gvdsUserMouseUp;
            tlBPQ.MouseUp += TlBPQ_MouseUp;

            //khu vực định nghĩa sự kiện button
            btnThemNguoiDung.Click += btnThemNguoiDung_Click;
            btnThemVaiTro.Click += BtnThemVaiTro_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;

            //sự kiện click tsmi
            tsmiThemVT.Click += BtnThemVaiTro_Click;
            tsmiThemND.Click += btnThemNguoiDung_Click;
            tsmiSua.Click += BtnSua_Click;
            tsmiXoa.Click += BtnXoa_Click;

            tvVaiTroNguoiDung.AfterSelect += TvVaiTroNguoiDung_AfterSelect;


            if (phanquyenPQ != null)
            {
                btnThemNguoiDung.Enabled = phanquyenPQ.Them == 0 ? false : true;
                btnThemVaiTro.Enabled = phanquyenPQ.Them == 0 ? false : true;
                btnSua.Enabled = phanquyenPQ.Sua == 0 ? false : true;
                btnXoa.Enabled = phanquyenPQ.Xoa == 0 ? false : true;
            }
        }

        private void TvVaiTroNguoiDung_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = e.Node;

            numChildNode = tn.GetNodeCount(true);

            if (tn.Parent == null)
            {
                VaiTro vt = tn.Tag as VaiTro;
                MaVaiTro = vt.MaVaiTro;
                TenVT = vt.TenVaiTro;
                IDUser = null;
                TenDangNhap = null;
            }
            else
            {
                NguoiDung nd = tn.Tag as NguoiDung;
                MaVaiTro = nd.MaVaiTro;
                IDUser = nd.ID.ToString();
                TenDangNhap = nd.TenDangNhap;
            }

            FillGridView(MaVaiTro);

            FillTreeList(MaVaiTro);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (IDUser == null)
            {
                if (numChildNode == 0)
                {
                    DialogResult dr = XtraMessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa VAI TRÒ:\n\n\t{0}", TenVT), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        VaiTro_ChucNangBUS.XoaVTCN(MaVaiTro);
                        vaiTroBUS.XoaVaiTro(MaVaiTro);
                        FillTreeView();
                        XtraMessageBox.Show("Xóa thành công!");
                    }
                }
                else if (numChildNode > 0)
                {
                    XtraMessageBox.Show("Phải xóa hết người dùng thuộc nhóm này trước khi xóa vai trò", "Hệ Thống");
                }
            }
            else
            {
                DialogResult dr = XtraMessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa NGƯỜI DÙNG:\n\n\t{0}", TenDangNhap), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nguoiDungBUS.XoaNguoiDung(TenDangNhap);
                    FillTreeView();
                    XtraMessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (IDUser == null)
            {
                VaiTro vt = LayVaiTroDangChon();
                frmAddRole frmvt = new frmAddRole(vt);
                frmvt.CapNhatThanhCong += FillTreeView;
                frmvt.CapNhatThanhCong += NhatKySuaVaiTro;
                frmvt.ShowDialog();
            }
            else
            {
                NguoiDung nd = LayNguoiDungDangChon();
                frmAddUser frm = new frmAddUser(nd);
                frm.CapNhatThanhCong += FillTreeView;
                frm.CapNhatThanhCong += NhatKySuaNguoiDung;
                frm.ShowDialog();
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            frmAddUser frmnd = new frmAddUser();
            frmnd.ThemThanhCong += FillTreeView;
            frmnd.ThemThanhCong += NhatKyThemNguoiDung;
            frmnd.CapNhatVaiTro += FillTreeView;
            frmnd.ShowDialog();
        }

        private void BtnThemVaiTro_Click(object sender, EventArgs e)
        {
            frmAddRole frmtvt = new frmAddRole();
            frmtvt.ThemThanhCong += FillTreeView;
            frmtvt.ThemThanhCong += NhatKyThemVaiTro;
            frmtvt.ShowDialog();
        }

        private void TlBPQ_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeList view = sender as TreeList;
                TreeListHitInfo info = view.CalcHitInfo(e.Location);
                if (info.HitInfoType == HitInfoType.Column)
                {
                    this.ContextMenuStrip.Hide();
                }
            }
        }

        private void gvdsUserMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Right)
                {
                    GridView view = sender as GridView;
                    GridHitInfo info = view.CalcHitInfo(e.Location);
                    if (info.HitTest == GridHitTest.Column)
                    {
                        this.ContextMenuStrip.Hide();
                    }
                }
            }
        }

        private void AddNhatKy(string hanhDong, string chucnang)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = chucnang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }
        private void NhatKySuaVaiTro()
        {
            AddNhatKy("Cập Nhật", "Vai Trò");
        }
        private void NhatKyThemVaiTro()
        {
            AddNhatKy("Thêm", "Vai Trò");
        }
        private void NhatKySuaNguoiDung()
        {
            AddNhatKy("Cập Nhật", "Người Dùng");
        }
        private void NhatKyThemNguoiDung()
        {
            AddNhatKy("Thêm", "Người Dùng");
        }
        private VaiTro LayVaiTroDangChon()
        {
            string sql = string.Format("select * from VAITRO where MaVaiTro='{0}'", MaVaiTro);
            DataTable dt = ConnectionDB.LayDuLieuBang(sql);
            DataRow r = dt.Rows[0];

            VaiTro vt = new VaiTro();
            vt.MaVaiTro = MaVaiTro;
            vt.TenVaiTro = r["TenVaiTro"].ToString();
            vt.DienGiai = r["DienGiai"].ToString();
            vt.KichHoat = bool.Parse(r["KichHoat"].ToString());

            return vt;
        }
        private NguoiDung LayNguoiDungDangChon()
        {
            string sql = "select * from NGUOIDUNG where ID = " + IDUser;
            DataTable dt = ConnectionDB.LayDuLieuBang(sql);
            DataRow r = dt.Rows[0];

            NguoiDung nd = new NguoiDung();
            nd.ID = int.Parse(IDUser);
            nd.TenDangNhap = r["TenDangNhap"].ToString();
            nd.Password = r["Password"].ToString();
            nd.MaVaiTro = r["MaVaiTro"].ToString();
            nd.MaNV = r["MaNV"].ToString();
            nd.DienGiai = r["DienGiai"].ToString();
            nd.ConQuanLy = bool.Parse(r["ConQuanLy"].ToString());

            return nd;
        }
        private void FillTreeList(string maVaiTro)
        {
            string sql = string.Format("select vc.MaChucNang, cn.TenChucNang, vc.TatCa, vc.TruyCap, vc.Them, vc.Xoa, vc.Sua, vc.InAn, vc.Nhap, vc.Xuat, cn.MaCha" +
                                    " from VAITRO_CHUCNANG vc, CHUCNANG cn" +
                                    " where vc.MaChucNang = cn.MaChucNang and vc.MaVaiTro = '{0}'", maVaiTro);
            DataTable dt = ConnectionDB.LayDuLieuBang(sql);

            tlBPQ.DataMember = null;
            tlBPQ.DataSource = dt;
            tlBPQ.KeyFieldName = "MaChucNang";
            tlBPQ.ParentFieldName = "MaCha";
        }
        private void FillGridView(string mavt)
        {
            string sql = "select nd.TenDangNhap, vt.TenVaiTro, nd.DienGiai, nd.ConQuanLy" +
                            " from NGUOIDUNG nd, VAITRO vt" +
                            " where nd.MaVaiTro = vt.MaVaiTro" +
                            string.Format(" and nd.MaVaiTro = '{0}'", mavt);

            DataTable dt = ConnectionDB.LayDuLieuBang(sql);
            gcdsUser.DataSource = dt;
        }
        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            FillTreeView();
        }
        private void FillTreeView()
        {
            tvVaiTroNguoiDung.Nodes.Clear();

            List<VaiTro> dsVaiTro = LayListVaiTro();

            foreach (VaiTro vt in dsVaiTro)
            {
                TreeNode tn = new TreeNode(vt.TenVaiTro);
                tn.Tag = vt;
                tvVaiTroNguoiDung.Nodes.Add(tn);
                tvVaiTroNguoiDung.TopNode = tn;

                FillChildNode(vt.MaVaiTro, tn);
            }

            tvVaiTroNguoiDung.ExpandAll();
        }
        private void FillChildNode(string mavt, TreeNode topnode)
        {
            DataTable dt = nguoiDungBUS.LayDuLieuNguoiDung(string.Format("select ID, TenDangNhap, MaVaiTro from NGUOIDUNG where MaVaiTro = '{0}'", mavt));

            foreach (DataRow row in dt.Rows)
            {
                NguoiDung nd = new NguoiDung();

                nd.ID = int.Parse(row["ID"].ToString());
                nd.TenDangNhap = row["TenDangNhap"].ToString();
                nd.MaVaiTro = row["MaVaiTro"].ToString();

                TreeNode tn = new TreeNode(nd.TenDangNhap);
                tn.Tag = nd;

                topnode.Nodes.Add(tn);
            }
        }
        private List<VaiTro> LayListVaiTro()
        {
            DataTable dt = vaiTroBUS.LayDuLieuVaiTro("select * from VAITRO");
            List<VaiTro> lvt = new List<VaiTro>();

            foreach (DataRow row in dt.Rows)
            {
                VaiTro vt = new VaiTro();
                vt.MaVaiTro = row["MaVaiTro"].ToString();
                vt.TenVaiTro = row["TenVaiTro"].ToString();
                vt.DienGiai = row["DienGiai"].ToString();
                vt.KichHoat = bool.Parse(row["KichHoat"].ToString());

                lvt.Add(vt);
            }

            return lvt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}