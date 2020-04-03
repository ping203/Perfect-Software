using System;
using System.Data;
using System.Windows.Forms;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.GUI.SupplierAction;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.DTO;
using static QLBH_ProductManagement.frmMain;
using System.Data.SqlClient;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using System.Collections.Generic;

namespace QLBH_ProductManagement.GUI
{
    public partial class ucBuyPhieuNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        //public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        string TenChucNang = "Mua Hàng";
        public ucBuyPhieuNhapHang()
        {
            string un;
            un = user;
            InitializeComponent();
           
        }
        GoodBUS gBus = new GoodBUS();
        SupplierBUS supBUS = new SupplierBUS();
        EmployeesBUS employBUS = new EmployeesBUS();
        WarehouseBUS wareBUS = new WarehouseBUS();
        DetailBuyGoodsBUS detailBuyBus = new DetailBuyGoodsBUS();
        InforDetailBuyBUS inforBUS = new InforDetailBuyBUS();
        TonKhoBUS tkBus = new TonKhoBUS();
        UnitBUS unitBUS = new UnitBUS();
        PTThanhToanBUS ptThanhToanBUS = new PTThanhToanBUS();
        DKThanhToanBUS dkThanhToan = new DKThanhToanBUS();
        BienToanCuc bienToanCuc = new BienToanCuc();

        private void grcHangHoa_Load(object sender, EventArgs e)
        {
            detailBuyBus.deleteChiTietHoaDonAo();

            grcHangHoa.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();

            loadListGoods();
            txtPhieu.ReadOnly = true;

            loadNCC();
            loadNhanVien();
            loadKho();
            loadHinhThucThanhToan();
            loadDieukhoanThanhToan();

            txtPhieu.Text = inforBUS.IDAuto();

            dtNgay.Text = DateTime.Now.ToString("M/d/yyyy");
            dtHanThanhToan.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        public void getDuLieu(InforDetailBuy infor, List<DetailBuyGoods> listDetail)
        {
            txtPhieu.Text = infor.MaPhieu;

            txtMaNCC.Text = infor.MaNCC;
            cbTenNCC.Text = infor.TenNCC;
            cbKhoNhap.EditValue = infor.MaKhoNhap;
            cbDieuKhoanThanhToan.EditValue = infor.Ma_DieuKhoan;
            cbHinhThucThanhToan.EditValue = infor.Ma_PhuongThuc;
            dtNgay.Text = infor.NgayLap.ToString();
            cbNhanVien.EditValue = infor.MaNVLap;

            foreach (DetailBuyGoods x in listDetail)
            {
                detailBuyBus.InsertChiTietHoaDonMuaHang_Ao(x.MaPhieu, x.MaHang, x.TenHang, x.DonVi, x.SoLuong, x.DonGia, x.ThanhTien);
            }
            grcHangHoa.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();

        }

        public void loadKho()
        {

            DataTable data = wareBUS.LoadKhoHang();
            cbKhoNhap.Properties.DataSource = data;
            cbKhoNhap.Properties.DisplayMember = "TenKho";
            cbKhoNhap.Properties.ValueMember = "MaKho";
            cbKhoNhap.ItemIndex = 0;
        }

        public void loadNhanVien()
        {
            DataTable data = employBUS.getEmployeesDataTable();
            cbNhanVien.Properties.DataSource = data;
            cbNhanVien.Properties.DisplayMember = "TenNV";
            cbNhanVien.Properties.ValueMember = "MaNV";
            cbNhanVien.ItemIndex = 0;
        }

        public void loadNCC()
        {
            DataTable data = supBUS.getNCC();
            cbTenNCC.Properties.DataSource = data;
            cbTenNCC.Properties.DisplayMember = "TenNCC";
            cbTenNCC.Properties.ValueMember = "MaNCC";
            cbTenNCC.ItemIndex = 0;
        }

        public void loadHinhThucThanhToan()
        {
            DataTable data = new DataTable();
            data = ptThanhToanBUS.loadPTThanhToan();
            cbHinhThucThanhToan.Properties.DataSource = data;
            cbHinhThucThanhToan.Properties.ValueMember = "MaPT";
            cbHinhThucThanhToan.Properties.DisplayMember = "TenPT";

            cbHinhThucThanhToan.ItemIndex = 0;
        }

        public void loadDieukhoanThanhToan()
        {
            DataTable data = new DataTable();
            data = dkThanhToan.loadDKThanhToan();
            cbDieuKhoanThanhToan.Properties.DataSource = data;
            cbDieuKhoanThanhToan.Properties.ValueMember = "ID";
            cbDieuKhoanThanhToan.Properties.DisplayMember = "TenDK";

            cbDieuKhoanThanhToan.ItemIndex = 0;
        }

        private void cbTenNCC_EditValueChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = cbTenNCC.EditValue != null ? cbTenNCC.EditValue.ToString() : null;
        }

        public void loadListGoods()  // ok
        {
            DataTable data = gBus.getListGoodsDaoDich();
            repositoryItems.DataSource = data;
            repositoryItems.ValueMember = "MaHang";
            repositoryItems.DisplayMember = "MaHang";
            repositoryItems.NullText = "Chọn mặt hàng";
            colMa.ColumnEdit = repositoryItems;
            calCK.Text = "0";
            calVAT.Text = "0";
        }

        private void grdHoaDon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            float tongTien = 0;
            int soLuong = 0;
            float donGia = 0;

            if (e.Column.FieldName == "MaHang")
            {
                var MaHang = grdHoaDon.GetRowCellValue(e.RowHandle, e.Column); // lấy ra được mã hàng

                var MatHang = gBus.getInfoGoods((string)MaHang);

                string tenDVT = gBus.getTenDonVi((string)MaHang);

                if (MaHang != null)
                {
                    grdHoaDon.SetRowCellValue(e.RowHandle, "TenHang", MatHang.TenHang);
                    grdHoaDon.SetRowCellValue(e.RowHandle, "DonGia", MatHang.GiaMua);
                    grdHoaDon.SetRowCellValue(e.RowHandle, "DonVi", tenDVT);
                    grdHoaDon.SetRowCellValue(e.RowHandle, "SoLuong", 1);


                    if (grdHoaDon.GetFocusedRowCellValue(colSL).ToString() == "") // nếu chưa có sl thì set bằng O
                    {
                        soLuong = 1;
                    }
                    else
                    {
                        soLuong = int.Parse(grdHoaDon.GetFocusedRowCellValue(colSL).ToString());
                        donGia = float.Parse(grdHoaDon.GetFocusedRowCellValue(colGia).ToString());
                        tongTien = soLuong * donGia;
                        grdHoaDon.SetFocusedRowCellValue(colTien, tongTien);
                        getThueTinhTien();
                    }
                }
            }

            if (e.Column == colSL)
            {
                if (grdHoaDon.GetFocusedRowCellValue(colGia).ToString() == "")
                {
                    donGia = 1;
                }
                else
                {
                    donGia = float.Parse(grdHoaDon.GetFocusedRowCellValue(colGia).ToString());
                }
                soLuong = int.Parse(grdHoaDon.GetFocusedRowCellValue(colSL).ToString());

                tongTien = soLuong * donGia;
                grdHoaDon.SetFocusedRowCellValue(colTien, tongTien);
                getThueTinhTien();
            }


            if (e.Column == colGia)
            {

                if (grdHoaDon.GetFocusedRowCellValue(colSL).ToString() == "") // nếu chưa có sl thì set bằng O
                {
                    soLuong = 1;

                }
                else
                {
                    soLuong = int.Parse(grdHoaDon.GetFocusedRowCellValue(colSL).ToString());
                }
                donGia = float.Parse(grdHoaDon.GetFocusedRowCellValue(colGia).ToString());

                tongTien = soLuong * donGia;


                grdHoaDon.SetFocusedRowCellValue(colTien, tongTien);
                //calTongTienTra.Text = TinhTongTienThanhToan().ToString();
                getThueTinhTien();
            }

        }


        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            frmAddSupplier fAddSupplier = new frmAddSupplier();
            fAddSupplier.ThemThanhCong += NhatKyThemNCC;
            fAddSupplier.ShowDialog();
            loadNCC();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = true;
            TonKho tk = new TonKho();
            int count = grdHoaDon.RowCount;

            //float TongTienMua = 0;

            string maPhieu = "";
            int sl = 0;
            if (cbTenNCC.Text == "")
            {
                XtraMessageBox.Show("Thiếu trường thông tin");
                cbTenNCC.Focus();
            }
            else if (count < 2)
            {
                XtraMessageBox.Show("Mời bạn chọn mặt hàng");
                grdHoaDon.Focus();
            }
            else
            {


                InforDetailBuy inforBuy = new InforDetailBuy();
                inforBuy.MaPhieu = txtPhieu.Text;
                inforBuy.TenNCC = cbTenNCC.Text;
                inforBuy.MaNCC = txtMaNCC.Text;
                inforBuy.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtNgay.Text));

                inforBuy.HanThanhToan = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtHanThanhToan.Text));
                inforBuy.MaNVLap = cbNhanVien.EditValue != null ? cbNhanVien.EditValue.ToString() : null;
                inforBuy.MaKhoNhap = cbKhoNhap.EditValue != null ? cbKhoNhap.EditValue.ToString() : null;
                inforBuy.VAT = float.Parse(calVAT.Text);
                inforBuy.CK = float.Parse(calCK.Text);
                inforBuy.TongTienMua = getTongTien();
                inforBuy.TongTienTra = float.Parse(calTongTienTra.Text);
                tk.MaKho = inforBuy.MaKhoNhap;  // lấy Mã kho của măt hàng mua vào

                inforBuy.Ma_PhuongThuc = cbHinhThucThanhToan.EditValue != null ? cbHinhThucThanhToan.EditValue.ToString() : null;

                inforBuy.Ma_DieuKhoan = int.Parse(cbDieuKhoanThanhToan.EditValue != null ? cbDieuKhoanThanhToan.EditValue.ToString() : null);

                int checkMPhieu = inforBUS.checkMaPhieuMua(txtPhieu.Text);



                try
                {
                    // check xem mã đã có hay chưa. nếu chưa thì insert. COnf có rồi thò updaye
                    if (checkMPhieu == 1)
                    {
                        inforBUS.UpdateInforBuy(inforBuy);
                    }

                    else
                    {
                        inforBUS.InsertDetailBuyGoods(inforBuy);
                    }
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi  DetailBuyGoods:  " + ex.Message);
                }

                int isDelete = 0;
                for (int i = 0; i < count - 1; i++)
                {

                    DetailBuyGoods detailBuy = new DetailBuyGoods();
                    DataRow data = grdHoaDon.GetDataRow(i);

                    detailBuy.MaPhieu = txtPhieu.Text;
                    maPhieu = txtPhieu.Text;


                    txtMaNCC.Text = cbTenNCC.EditValue != null ? cbTenNCC.EditValue.ToString() : null;

                    detailBuy.MaHang = data[1].ToString();

                    detailBuy.TenHang = detailBuy.TenHang = data[2].ToString();
                    detailBuy.DonVi = data[3].ToString();
                    sl = detailBuy.SoLuong = int.Parse(data[4].ToString());
                    detailBuy.DonGia = float.Parse(data[5].ToString());
                    detailBuy.ThanhTien = float.Parse(data[6].ToString());

                    //  TongTienMua += detailBuy.ThanhTien;

                    tk.MaHang = data[1].ToString();  // lấy mã mặt hàng
                     
                    try
                    {
                        if (checkMPhieu == 1 && isDelete == 0) //có rồi
                        {
                            // xóa rồi thêm lại
                            detailBuyBus.DeleteDetailBuy(detailBuy.MaPhieu);
                            isDelete = 1;
                        }


                        detailBuyBus.InsertDetailBuyGoods(detailBuy);
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show("Lỗi tại thêm chi tiết phiếu mua:  " + ex.Message);
                    }

                    // nếu mặt hàng mua đã có trong Kho rồi thì chỉ cần Update lại số lượng
                    // còn nếu chưa có trong kho thì cần thêm mới vào tồn kho
                    int checkMaHang = tkBus.checkMatHang(tk.MaHang, tk.MaKho);
                    int slHienTai = tkBus.getSoLuong(tk);
                    slHienTai += sl;
                    // kiểm tra xem là mặt hàng nãy đã có trong kho hay chưa
                    if (checkMaHang == 1)
                    {
                        tkBus.UpdateSoLuong(tk, slHienTai);  // nếu có rồi thì chỉ cần update số luọng
                    }
                    else // chưa có thì insert
                    {
                        int checkInsertTonKho = tkBus.insertTonKho(tk, sl);
                        if (checkInsertTonKho == 0)
                        {
                            check = false;
                        }
                    }

                }
                if (check == false)
                {
                    XtraMessageBox.Show("Thêm Mặt hàng thất bại");
                }
                else
                {
                    XtraMessageBox.Show("Thêm Mặt hàng thành công");
                    AddNhatKy("Thêm", TenChucNang);
                    txtPhieu.Text = inforBUS.IDAuto();
                    detailBuyBus.deleteChiTietHoaDonAo();
                    grcHangHoa.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();
                }
            }

        }


        public float getTongTien()  // lay duocj tong tien
        {
            int count = grdHoaDon.RowCount;
            float tongTien = 0;
            for (int i = 0; i < count - 1; i++)
            {
                DetailBuyGoods detailBuy = new DetailBuyGoods();
                DataRow data = grdHoaDon.GetDataRow(i);
                tongTien += float.Parse(data[6].ToString());
            }
            return tongTien;
        }
        public void getThueTinhTien()
        {
            float tongTien = getTongTien();
            string CK;
            float chietKhau = 0;
            float gtriGT = 0;

            if (calCK.Text[calCK.Text.Length - 1].ToString() == ".")
            {
                CK = calCK.Text.Substring(0, calCK.Text.Length - 1);
            }
            else
            {
                CK = calCK.Text;
            }
            string GTDT;
            if (calVAT.Text[calVAT.Text.Length - 1].ToString() == ".")
            {
                GTDT = calVAT.Text.Substring(0, calVAT.Text.Length - 1);
            }
            else
            {
                GTDT = calVAT.Text;
            }
            chietKhau = (float)(tongTien * Convert.ToDouble(CK) * 0.01);
            gtriGT = (float)(tongTien * Convert.ToDouble(GTDT) * 0.01);
            ChietKhau.Text = chietKhau.ToString();
            VAT.Text = gtriGT.ToString();
            calTongTienTra.Text = (tongTien - chietKhau + gtriGT).ToString();
        }

        private void calCK_Leave(object sender, EventArgs e)
        {
            getThueTinhTien();

        }

        private void calVAT_Leave(object sender, EventArgs e)
        {
            getThueTinhTien();
        }

        private void btnReFresh_Click(object sender, EventArgs e)
        {
            detailBuyBus.deleteChiTietHoaDonAo();

            grcHangHoa.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();
            AddNhatKy("Nạp Lại", TenChucNang);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcHangHoa);
            AddNhatKy("In", TenChucNang);
        }
        private void NhatKyThemNCC()
        {
            AddNhatKy("Thêm", "Nhà Cung Cấp");
        }
        private void AddNhatKy(string hanhDong, string cn)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = cn;
            nk.HanhDong = hanhDong;

            //ThemNhatKyHeThong(nk);
        }
    }
}
