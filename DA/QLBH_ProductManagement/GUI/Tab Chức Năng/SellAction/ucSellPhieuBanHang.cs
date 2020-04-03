using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.GUI.CustomerAction;
using QLBH_ProductManagement.DTO;
using System.Data.SqlClient;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using System.Collections.Generic;

namespace QLBH_ProductManagement.GUI
{
    public partial class ucSellPhieuBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cSystemLog diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        //username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Bán Hàng";
        BienToanCuc bienToanCuc = new BienToanCuc();

        VaiTro_ChucNangDTO vtbh;
        public ucSellPhieuBanHang()
        {                   
            InitializeComponent();
            //user = un;
            if (vtbh != null)
            {
                if (vtbh.Them == 0)
                {
                    btnLuuVaThem.Enabled = false;
                    tsmiLuuvaDong.Enabled = false;
                }
            }
        }

        CustomerBUS cusBUS = new CustomerBUS();
        EmployeesBUS employBUS = new EmployeesBUS();
        WarehouseBUS wareBUS = new WarehouseBUS();
        GoodBUS gBus = new GoodBUS();
        DetailSellGoodsBUS detailSellBUS = new DetailSellGoodsBUS();
        PTThanhToanBUS ptThanhToanBUS = new PTThanhToanBUS();

        DKThanhToanBUS dkThanhToan = new DKThanhToanBUS();


        public void getDuLieu(InforDetailSell infor, List<DetailSellGoods> listDetail)
        {
            txtPhieu.Text = infor.MaPhieu;

            txtMaKH.Text = infor.MaKH;
            cbKhachHang.Text = infor.TenKH;
            cbKhoNhap.EditValue = infor.MaKho;
            cbDieuKhoanThanhToan.EditValue = infor.Ma_DieuKhoan;
            cbHinhThucThanhToan.EditValue = infor.Ma_PhuongThuc;
            dtNgay.Text = infor.NgayLap.ToString();
            cbNhanVien.EditValue = infor.MaNVLap;

            foreach (DetailSellGoods x in listDetail)
            {
                detailSellBUS.InsertChiTietHoaDonBanHang_Ao(x);
            }
            grcHangHoa.DataSource = detailSellBUS.getHTDetailSellBuy(); // lấy bảng ảo để hiển thị

        }


        public void loadKhachHang()
        {
            DataTable data = cusBUS.getCusDatatable();
            cbKhachHang.Properties.DataSource = data;
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";
            cbKhachHang.ItemIndex = 0;
        }

        private void cbKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = cbKhachHang.EditValue != null ? cbKhachHang.EditValue.ToString() : null;
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

        private void btnAddKhachHang_Click(object sender, EventArgs e)
        {
            var addCus = new frmAddCustomer();
            AddNhatKy("Thêm", "Khách hàng");
            addCus.ShowDialog();
            loadKhachHang();
        }

        public void loadListGoods()  // lấy mặt hàng để bán
        {
            DataTable data = gBus.getListGoodsDaoDich();
            repositoryGoods.DataSource = data;
            repositoryGoods.ValueMember = "MaHang";
            repositoryGoods.DisplayMember = "MaHang";
            repositoryGoods.NullText = "Chọn mặt hàng";
            colMa.ColumnEdit = repositoryGoods;

        }
        private void AddNhatKy(string hanhDong, string chucnang)
        {
            cSystemLog nk = new cSystemLog();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = chucnang;
            nk.HanhDong = hanhDong;

            //ThemNhatKyHeThong(nk);
        }
        private void grcHangHoa_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            detailSellBUS.deleteChiTietHoaDonAo();

            grcHangHoa.DataSource = detailSellBUS.getHTDetailSellBuy(); // lấy bảng ảo để hiển thị
            
            loadListGoods();

            loadKhachHang();
            loadKho();
            loadNhanVien();
            loadHinhThucThanhToan();
            loadDieukhoanThanhToan();

            txtPhieu.ReadOnly = true;
            txtPhieu.Text = inforSellBus.IDAuto();
            dtHanThanhToan.Text = DateTime.Now.ToString("M/d/yyyy");
            dtNgay.Text = DateTime.Now.ToString("M/d/yyyy");
            dtNgayGiao.Text = DateTime.Now.ToString("M/d/yyyy");
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

        private void grcHangHoa_Click(object sender, EventArgs e)
        {

        }



        private void grvListGoodSell_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            float tongTien = 0;
            int soLuong = 0;
            float donGia = 0;
            float CK = 0;
            float thanhTien = 0;

            if (e.Column.FieldName == "MaHang")
            {
                var MaHang = grvListGoodSell.GetRowCellValue(e.RowHandle, e.Column); // lấy ra được mã hàng

                var MatHang = gBus.getInfoGoods((string)MaHang);

                string tenDVT = gBus.getTenDonVi((string)MaHang);

                if (MaHang != null)
                {
                    grvListGoodSell.SetRowCellValue(e.RowHandle, "TenHang", MatHang.TenHang);
                    grvListGoodSell.SetRowCellValue(e.RowHandle, "ChietKhau", 0);
                    grvListGoodSell.SetRowCellValue(e.RowHandle, "DonGia", MatHang.GiabanLe);
                    grvListGoodSell.SetRowCellValue(e.RowHandle, "DonVi", tenDVT);
                    grvListGoodSell.SetRowCellValue(e.RowHandle, "CK", 0);
                    grvListGoodSell.SetRowCellValue(e.RowHandle, "SoLuong", 1);


                    soLuong = int.Parse(grvListGoodSell.GetFocusedRowCellValue(colSoLuong).ToString());
                    donGia = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colDonGia).ToString());

                    CK = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colCK).ToString());

                    tongTien = soLuong * donGia;

                    thanhTien = (float)(tongTien - (tongTien * CK * 0.01));

                    grvListGoodSell.SetFocusedRowCellValue(colChietKhau, tongTien * CK * 0.01);
                    grvListGoodSell.SetFocusedRowCellValue(colThanhTien, tongTien);
                    grvListGoodSell.SetFocusedRowCellValue(colThanhToan, thanhTien);

                }
            }

            if (e.Column == colSoLuong)
            {
                if (grvListGoodSell.GetFocusedRowCellValue(colDonGia).ToString() == "") // nếu chưa có sl thì set bằng O
                {
                    donGia = 1;
                }
                else
                {
                    donGia = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colDonGia).ToString());
                }
                if (grvListGoodSell.GetFocusedRowCellValue(colCK).ToString() == "")
                {
                    CK = 0;
                }
                else
                {

                    CK = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colCK).ToString());
                }

                soLuong = int.Parse(grvListGoodSell.GetFocusedRowCellValue(colSoLuong).ToString());

                tongTien = soLuong * donGia;

                thanhTien = (float)(tongTien - (tongTien * CK * 0.01));

                grvListGoodSell.SetFocusedRowCellValue(colChietKhau, tongTien * CK * 0.01);
                grvListGoodSell.SetFocusedRowCellValue(colThanhTien, tongTien);
                grvListGoodSell.SetFocusedRowCellValue(colThanhToan, thanhTien);

                getThueTinhTien();


            }

            if (e.Column == colDonGia)
            {

                if (grvListGoodSell.GetFocusedRowCellValue(colSoLuong).ToString() == "") // nếu chưa có sl thì set bằng O
                {
                    soLuong = 1;

                }
                else
                {
                    soLuong = int.Parse(grvListGoodSell.GetFocusedRowCellValue(colSoLuong).ToString());
                }
                if (grvListGoodSell.GetFocusedRowCellValue(colCK).ToString() == "")
                {
                    CK = 0;
                }
                else
                {

                    CK = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colCK).ToString());
                }

                donGia = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colDonGia).ToString());

                tongTien = soLuong * donGia;

                thanhTien = (float)(tongTien - (tongTien * CK * 0.01));

                grvListGoodSell.SetFocusedRowCellValue(colChietKhau, tongTien * CK * 0.01);
                grvListGoodSell.SetFocusedRowCellValue(colThanhTien, tongTien);
                grvListGoodSell.SetFocusedRowCellValue(colThanhToan, thanhTien);

                getThueTinhTien();

            }

            if (e.Column == colCK)
            {

                if (grvListGoodSell.GetFocusedRowCellValue(colSoLuong).ToString() == "") // nếu chưa có sl thì set bằng O
                {
                    soLuong = 1;

                }
                else
                {
                    soLuong = int.Parse(grvListGoodSell.GetFocusedRowCellValue(colSoLuong).ToString());
                }

                if (grvListGoodSell.GetFocusedRowCellValue(colDonGia).ToString() == "") // nếu chưa có sl thì set bằng O
                {
                    donGia = 1;

                }
                else
                {
                    donGia = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colDonGia).ToString());
                }

                CK = float.Parse(grvListGoodSell.GetFocusedRowCellValue(colCK).ToString());
                tongTien = soLuong * donGia;
                thanhTien = (float)(tongTien - (tongTien * CK * 0.01));

                grvListGoodSell.SetFocusedRowCellValue(colChietKhau, tongTien * CK * 0.01);
                grvListGoodSell.SetFocusedRowCellValue(colThanhTien, tongTien);
                grvListGoodSell.SetFocusedRowCellValue(colThanhToan, thanhTien);

                getThueTinhTien();

            }
        }

        // float TongThu = 0;

        public float getSumTien()
        {
            float tien = 0;
            int count = grvListGoodSell.RowCount;
            for (int i = 0; i < count - 1; i++) /// Chạy for để lấy ra tất cả tổng tiền
            {

                DetailSellGoods detailSell = new DetailSellGoods();
                DataRow data = grvListGoodSell.GetDataRow(i);

                tien += float.Parse(data[9].ToString());

            }
            return tien;
        }

        InforSellBUS inforSellBus = new InforSellBUS();
        TonKho tk = new TonKho();
        TonKhoBUS tkBus = new TonKhoBUS();

        private void btnLuuVaThem_Click(object sender, EventArgs e)
        {

            InforDetailSell infor = new InforDetailSell();


            string maPhieu = "";
            int sl = 0;
            bool check = true;
            // lấy thông tin infor để lưu

            // phần bắt lỗi:
            int count = grvListGoodSell.RowCount;

            if (cbKhachHang.Text == "")
            {
                XtraMessageBox.Show("Thiếu trường thông tin");
                cbKhachHang.Focus();
            }
            else if (count < 2)
            {
                XtraMessageBox.Show("Mời bạn chọn mặt hàng");
            }
            else
            {

                tk.MaKho = infor.MaKho = cbKhoNhap.EditValue != null ? cbKhoNhap.EditValue.ToString() : null;   // lấy Mã kho của măt hàng mua vào

                for (int i = 0; i < count - 1; i++) /// Chạy for để lấy ra tất cả những mặt hành nào đã bán
                {

                    DetailSellGoods detailSell = new DetailSellGoods();
                    DataRow data = grvListGoodSell.GetDataRow(i);
                    sl = detailSell.SoLuong = int.Parse(data[4].ToString());
                    tk.MaHang = detailSell.MaHang = data[1].ToString();

                    int checkMaHang = tkBus.checkMatHang(tk.MaHang, tk.MaKho);
                    int slHienTaiMH = tkBus.getSoLuong(tk);
                    slHienTaiMH -= sl;
                    // kiểm tra xem là mặt hàng nãy đã có trong kho hay chưa
                    if (checkMaHang == 1)
                    {
                        if (slHienTaiMH < 0)
                        {
                            DialogResult dr;
                            dr = XtraMessageBox.Show("Số lượng tồn kho đang ít hơn số lượng bán. Nếu thực hiện giao dịch, số lượng tồn của mặt hàng " + tk.MaHang + " sẽ là âm ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                    else // neếu mặt hang chưa có trong Kho.
                    {
                        DialogResult dr;
                        dr = XtraMessageBox.Show("Mặt hàng hiện chưa có trong kho. Nếu thực hiện giao dịch. Số lượng tồn của mặt hàng " + tk.MaHang + " sẽ là âm ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            check = false;
                            break;
                        }

                    }
                }

                if (check == false)
                {
                    XtraMessageBox.Show("Thêm Mặt hàng thất bại");
                }
                else
                {
                    infor.TongTienNhan = float.Parse(ThanhTien.Text);
                    infor.TongTienBan = getSumTien();
                    infor.CK = float.Parse(calCK.Text);
                    infor.VAT = float.Parse(calVAT.Text);
                    infor.MaPhieu = maPhieu = txtPhieu.Text;
                    infor.TenKH = cbKhachHang.Text;
                    infor.MaKH = txtMaKH.Text;
                    infor.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtNgay.Text));
                    infor.HanThanhToan = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtHanThanhToan.Text));
                    infor.MaNVLap = cbNhanVien.EditValue != null ? cbNhanVien.EditValue.ToString() : null;
                    infor.SoHoaDonVAT = txtSoHoaDonVAT.Text;
                    infor.SoPhieuNhapTay = txtSoPhieuVietTay.Text;
                    infor.DiaChi = txtDiaChi.Text;
                    infor.GhiChu = txtGhiChu.Text;
                    infor.Ma_PhuongThuc = cbHinhThucThanhToan.EditValue != null ? cbHinhThucThanhToan.EditValue.ToString() : null;
                    infor.Ma_DieuKhoan = int.Parse(cbDieuKhoanThanhToan.EditValue != null ? cbDieuKhoanThanhToan.EditValue.ToString() : null);

                    // kieemre tra xem đã  tông tại chưa. nếu chưa thò insert. có rồi thì update:
                    int checkMPhieu = inforSellBus.checkMaPhieuBan(infor.MaPhieu);

                    try
                    {
                        if(checkMPhieu == 1)
                        {
                            inforSellBus.UpdateInforSell(infor);  // Nhập thông tin bán hàng
                        }
                        else
                        {
                            inforSellBus.InsertDetailSellGoods(infor);  // Nhập thông tin bán hàng
                        }
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show("Lỗi Insert DetailSellGoods:  " + ex.Message);
                    }
                    int isDelete = 0;
                    for (int i = 0; i < count - 1; i++) /// Chạy for để lấy ra tất cả những mặt hành nào đã bán
                    {

                        DetailSellGoods detailSell = new DetailSellGoods();
                        DataRow data = grvListGoodSell.GetDataRow(i);
                        detailSell.MaPhieuXuat = maPhieu;
                        tk.MaHang = detailSell.MaHang = data[1].ToString();
                        detailSell.TenHang = detailSell.TenHang = data[2].ToString();
                        detailSell.DonVi = data[3].ToString();
                        sl = detailSell.SoLuong = int.Parse(data[4].ToString());
                        detailSell.DonGia = float.Parse(data[5].ToString());
                        detailSell.ThanhTien = float.Parse(data[6].ToString());
                        detailSell.CK = int.Parse(data[7].ToString());
                        detailSell.ThanhToan = float.Parse(data[9].ToString());
                        try
                        {
                            if (checkMPhieu == 1 && isDelete == 0) //có rồi
                            {
                                // xóa rồi thêm lại
                                detailSellBUS.DeleteDetailSell(txtPhieu.Text);
                                isDelete = 1;
                            }
                            detailSellBUS.InsertDetailSell(detailSell);
                        }
                        catch (SqlException ex)
                        {
                            XtraMessageBox.Show("Lỗi tại thêm chi tiết phiếu bán:  " + ex.Message);
                            check = false;
                        }
                        int checkMaHang = tkBus.checkMatHang(tk.MaHang, tk.MaKho);
                        int slHienTai = tkBus.getSoLuong(tk);
                        slHienTai -= sl;
                        // kiểm tra xem là mặt hàng nãy đã có trong kho hay chưa
                        if (checkMaHang == 1)
                        {

                            //slHienTai -= sl;
                            try
                            {
                                tkBus.UpdateSoLuong(tk, slHienTai);  // nếu có rồi thì chỉ cần update số luọng
                            }
                            catch (SqlException ex)
                            {
                                XtraMessageBox.Show("Lỗi tại update số luọng:  " + ex.Message);
                            }
                        }
                        else // neếu mặt hang chưa có trong Kho.
                        {
                            try
                            {
                                tkBus.insertTonKho(tk, slHienTai);
                            }
                            catch (SqlException ex)
                            {
                                XtraMessageBox.Show("Lỗi tại thêm vào tồn kho:  " + ex.Message);
                            }
                        }
                    }
                    AddNhatKy("Thêm", TenChucNang);
                    XtraMessageBox.Show("Thêm Mặt hàng thành công");
                    txtPhieu.Text = inforSellBus.IDAuto();
                    detailSellBUS.deleteChiTietHoaDonAo();
                    grcHangHoa.DataSource = detailSellBUS.getHTDetailSellBuy(); 
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcHangHoa);
            AddNhatKy("Thêm", TenChucNang);
        }

        private void calVAT_Leave(object sender, EventArgs e)
        {
            getThueTinhTien();
        }

        private void calCK_Leave(object sender, EventArgs e)
        {
            getThueTinhTien();
        }

        public void getThueTinhTien()
        {
            float tongTien = getSumTien();
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
            ThanhTien.Text = (tongTien - chietKhau + gtriGT).ToString();

        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            //detailSellBUS.deleteChiTietHoaDonAo();
            grcHangHoa.DataSource = detailSellBUS.getHTDetailSellBuy();
        }
    }
}
