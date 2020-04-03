using System;
using System.Data;
using System.Windows.Forms;
using static QLBH_ProductManagement.GUI.frmGlobalVariable;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.DTO;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QLBH_ProductManagement.GUI.WarehouseTranferAction
{
    public partial class ucWT_PhieuChuyenKho : DevExpress.XtraEditors.XtraUserControl
    {
        BienToanCuc bienToanCuc = new BienToanCuc();
        WarehouseBUS wareHouseBUS = new WarehouseBUS();
        EmployeesBUS emloyeesBus = new EmployeesBUS();
        DetailBuyGoodsBUS detailBuyBus = new DetailBuyGoodsBUS();
        GoodBUS gBus = new GoodBUS();
        DetailTransWarehouseBUS ckBUS = new DetailTransWarehouseBUS();
        TonKhoBUS tkBUS = new TonKhoBUS();

       
        public ucWT_PhieuChuyenKho()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            bienToanCuc.In(grcChuyenKho);
        }

        // load kho

        public void LoadKhoHang()
        {
            cbKhoXuatHang.Properties.DataSource = wareHouseBUS.LoadKhoHang();
            cbKhoXuatHang.Properties.DisplayMember = "TenKho";
            cbKhoXuatHang.Properties.ValueMember = "MaKho";
            cbKhoXuatHang.ItemIndex = 0;


            cbKhoNhanHang.Properties.DataSource = wareHouseBUS.LoadKhoHang();
            cbKhoNhanHang.Properties.DisplayMember = "TenKho";
            cbKhoNhanHang.Properties.ValueMember = "MaKho";
            cbKhoNhanHang.ItemIndex = 1;
        }

        // Load nhan vien

        public void LoadNhanVien()
        {
            cbNguoiChuyen.Properties.DataSource = emloyeesBus.getEmployeesDataTable();
            cbNguoiChuyen.Properties.DisplayMember = "TenNV";
            cbNguoiChuyen.Properties.ValueMember = "MaNV";
            cbNguoiChuyen.ItemIndex = 0;


            cbNguoiNhan.Properties.DataSource = emloyeesBus.getEmployeesDataTable();
            cbNguoiNhan.Properties.DisplayMember = "TenNV";
            cbNguoiNhan.Properties.ValueMember = "MaNV";
            cbNguoiNhan.ItemIndex = 1;
        }


        // Load Hang để chuyển

        public void LoadHang()
        {

            DataTable data = gBus.getListGoodsDaoDichChuyenKho();

            repositoryItems.DataSource = data;
            repositoryItems.ValueMember = "MaHang";
            repositoryItems.DisplayMember = "MaHang";
            repositoryItems.NullText = "Chọn mặt hàng";
            colMaHang.ColumnEdit = repositoryItems;
        }

        private void grvChuyenKho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            float tongTien = 0;
            int soLuong = 0;
            float donGia = 0;

            if (e.Column.FieldName == "MaHang")
            {
                var MaHang = grvChuyenKho.GetRowCellValue(e.RowHandle, e.Column); // lấy ra được mã hàng

                var MatHang = gBus.getInfoGoods((string)MaHang);

                string tenDVT = gBus.getTenDonVi((string)MaHang);

                if (MaHang != null)
                {
                    grvChuyenKho.SetRowCellValue(e.RowHandle, "TenHang", MatHang.TenHang);
                    grvChuyenKho.SetRowCellValue(e.RowHandle, "DonGia", MatHang.GiaMua);
                    grvChuyenKho.SetRowCellValue(e.RowHandle, "DonVi", tenDVT);
                    grvChuyenKho.SetRowCellValue(e.RowHandle, "SoLuong", 1);


                    if (grvChuyenKho.GetFocusedRowCellValue(colSLuong).ToString() == "") // nếu chưa có sl thì set bằng O
                    {
                        soLuong = 1;
                    }
                    else
                    {
                        soLuong = int.Parse(grvChuyenKho.GetFocusedRowCellValue(colSLuong).ToString());
                        donGia = float.Parse(grvChuyenKho.GetFocusedRowCellValue(colGia).ToString());
                        tongTien = soLuong * donGia;
                        grvChuyenKho.SetFocusedRowCellValue(colTien, tongTien);

                    }
                }

            }
            // Nếu thay đổi ô SL
            if (e.Column == colSLuong)
            {
                if (grvChuyenKho.GetFocusedRowCellValue(colGia).ToString() == "")
                {
                    donGia = 1;
                }
                else
                {
                    donGia = float.Parse(grvChuyenKho.GetFocusedRowCellValue(colGia).ToString());
                }
                soLuong = int.Parse(grvChuyenKho.GetFocusedRowCellValue(colSLuong).ToString());
                tongTien = soLuong * donGia;
                grvChuyenKho.SetFocusedRowCellValue(colTien, tongTien);
            }
            // Nếu thay đổi cột đơn giá

            if (e.Column == colGia)
            {
                if (grvChuyenKho.GetFocusedRowCellValue(colSLuong).ToString() == "") // nếu chưa có sl thì set bằng O
                {
                    soLuong = 1;
                }
                else
                {
                    soLuong = int.Parse(grvChuyenKho.GetFocusedRowCellValue(colSLuong).ToString());
                }
                donGia = float.Parse(grvChuyenKho.GetFocusedRowCellValue(colGia).ToString());
                tongTien = soLuong * donGia;
                grvChuyenKho.SetFocusedRowCellValue(colTien, tongTien);
            }
        }

        public void getDuLieu(InforTransWarehouseDTO infor, List<DetailTransWarehouseDTO> listDetail)
        {
            txtPhieuCK.Text = infor.MaPhieuChuyen;

            cbKhoXuatHang.EditValue = infor.MaKhoXuat;
                cbKhoNhanHang.EditValue = infor.MaKhoNhan;

            cbNguoiChuyen.EditValue = infor.MaNVXuat;
            cbNguoiNhan.EditValue = infor.MaNVNhan;
            dtNgayChuyen.Text = infor.NgayLap.ToString();
            

            foreach (DetailTransWarehouseDTO x in listDetail)
            {
               detailBuyBus.InsertChiTietHoaDonMuaHang_Ao(x.MaPhieuChuyen, x.MaHang, x.TenHang, x.DonVi, x.SoLuong, x.DonGia, x.ThanhTien);
            }
            grcChuyenKho.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();

        }

        private void grcChuyenKho_Load(object sender, EventArgs e)
        {
            LoadKhoHang();
            LoadNhanVien();
            dtNgayChuyen.Text = DateTime.Now.ToString("M/d/yyyy");
// load bảng ảo:


            detailBuyBus.deleteChiTietHoaDonAo();

            grcChuyenKho.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();

            LoadHang();

            txtPhieuCK.Text = inforTransBUS.IDAuto();
        }

        InforTransWarehouseBUS inforTransBUS = new InforTransWarehouseBUS();
        InforTransWarehouseDTO inforTrans = new InforTransWarehouseDTO();
        DetailTransWarehouseDTO detailTrans = new DetailTransWarehouseDTO();
        private void btnLuuVaThem_Click(object sender, EventArgs e)
        {
            // lấy những mặt hàng từ kho xuất vào kho nhận:
            bool check = true;
            int count = grvChuyenKho.RowCount;
            string maKhoXuat = "";
            string maKhoNhan = "";
            if (count < 2)
            {
                XtraMessageBox.Show("Mời bạn chọn các mặt hàng cần chuyền");
                check = false;
            }
            else // khi có các mặt hàng:
            {
                // Lấy thông tin chuyển kho để insert:

                maKhoXuat = inforTrans.MaKhoXuat = cbKhoXuatHang.EditValue != null ? cbKhoXuatHang.EditValue.ToString() : null;
                maKhoNhan = inforTrans.MaKhoNhan = cbKhoNhanHang.EditValue != null ? cbKhoNhanHang.EditValue.ToString() : null;

                for (int i = 0; i < count - 1; i++)
                {
                    TonKho tkXuat = new TonKho();
                    TonKho tkNhan = new TonKho();
                    DataRow data = grvChuyenKho.GetDataRow(i);
                    tkNhan.MaHang = tkXuat.MaHang = detailTrans.MaHang = data[1].ToString();
                    detailTrans.SoLuong = int.Parse(data[4].ToString());
                    // Check kho xuất
                    tkXuat.MaKho = maKhoXuat;
                    int slTon;
                    int slHienTai = slTon = tkBUS.getSoLuong(tkXuat);
                    slHienTai = slHienTai - detailTrans.SoLuong;
                    int checkMaHangXuat = tkBUS.checkMatHang(detailTrans.MaHang, maKhoXuat);

                    if(checkMaHangXuat != 1) // chưa có
                    {
                        DialogResult dr;
                        dr = XtraMessageBox.Show("Mặt hàng " + detailTrans.TenHang + " Hiện chưa có trong kho: " + maKhoXuat + " Nếu bạn thực hiện. Số lượng tồn sẽ bị âm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            check = false;
                            break;
                        }
                    }
                    else // có rồi
                    {
                        if(slHienTai <= 0)
                        {
                            DialogResult dr;
                            dr = XtraMessageBox.Show("Mặt hàng " + detailTrans.TenHang + " Hiện có " + slTon + " trong kho: " + maKhoXuat + " Nếu bạn thực hiện. Số lượng tồn sẽ bị âm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {
                                check = false;
                                break;
                            }
                        }
                        
                    }
                }
            }
            if(check)
            {

                inforTrans.MaNVXuat = cbNguoiChuyen.EditValue != null ? cbNguoiChuyen.EditValue.ToString() : null;
                inforTrans.MaNVNhan = cbNguoiNhan.EditValue != null ? cbNguoiNhan.EditValue.ToString() : null;
                inforTrans.NgayLap = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", dtNgayChuyen.Text));
                inforTrans.GhiChu = txtGhiChu.Text;
                detailTrans.MaPhieuChuyen = inforTrans.MaPhieuChuyen = txtPhieuCK.Text;
                inforTrans.SoPhieuChuyenTay = txtPhieuChuyenTay.Text;
                inforTrans.TongTienChuyen = getTongTien();

                int checkMPhieu = inforTransBUS.checkMaPhieuChuyenKho(txtPhieuCK.Text);

                try   // kiểm tra xem đã có phiếu hay chưa. neeuc có rồi thì upate else: insert
                {
                    if(checkMPhieu == 1 )
                    {
                        inforTransBUS.UpdateInforTranWarehouse(inforTrans);
                    }
                    else
                    {
                        inforTransBUS.InsertInforTranWarehouse(inforTrans);
                    }
                   
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Lỗi tại thêm thông tin chuyển kho: " + ex.Message);
                }
                //Insert Chi Tiết chuyển kho:

                int isDelete = 0;

                for (int i = 0; i < count - 1; i++)
                {

                    TonKho tkXuat = new TonKho();
                    TonKho tkNhan = new TonKho();
                    DataRow data = grvChuyenKho.GetDataRow(i);
                    tkNhan.MaHang = tkXuat.MaHang = detailTrans.MaHang = data[1].ToString();
                    detailTrans.TenHang = data[2].ToString();
                    detailTrans.DonVi = data[3].ToString();
                    detailTrans.SoLuong = int.Parse(data[4].ToString());
                    detailTrans.DonGia = float.Parse(data[5].ToString());
                    detailTrans.ThanhTien = float.Parse(data[6].ToString());
                    try
                    {
                        if(checkMPhieu == 1 && isDelete == 0)
                        {
                            ckBUS.DeleteDetailTransWarehouse(txtPhieuCK.Text);
                            isDelete = 1;
                        }
                        ckBUS.InsertDetailTransWarehouse(detailTrans);
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show("Lỗi thêm chi tiết chuyển kho: " + ex.Message);
                      
                    }

                    // Xử lý về tồn kho:

                    // Lấy từ KHO A chuyển Sang Kho B:
                    // Lấy số lượng mặt hàng chuyển và kho chuyển:
                    // Nếu mặt hàng chưa có trong KHO mà vẫn chuyển thì mặt hàng đó bị âm
                    // Lấy bên này cộng vào bên kia

                    // Check kho xuất
                    tkXuat.MaKho = maKhoXuat;
                    int slTon;
                    int slHienTai = slTon = tkBUS.getSoLuong(tkXuat);
                    slHienTai = slHienTai - detailTrans.SoLuong;
                    int checkMaHangXuat = tkBUS.checkMatHang(detailTrans.MaHang, maKhoXuat);

                    if (checkMaHangXuat != 1) // chưa có
                    {  
                            try
                            {
                                int checkInsert = tkBUS.insertTonKho(tkXuat, slHienTai);
                            }
                            catch (SqlException ex)
                            {
                                XtraMessageBox.Show("Lỗi khi update số lượng kho nhận:  " + ex.Message);
                               
                            }
                    }
                    else // có rồi
                    {
                        try
                        {
                            tkBUS.UpdateSoLuong(tkXuat, slHienTai);  // nếu có rồi thì chỉ cần update số luọng
                        }
                        catch (SqlException ex)
                        {
                            XtraMessageBox.Show("Lỗi khi update số lượng kho nhận:  " + ex.Message);
                           
                        }

                    }
                    // check kho nhận
                    int checkMaHangNhan = tkBUS.checkMatHang(detailTrans.MaHang, maKhoNhan);
                    tkNhan.MaKho = maKhoNhan;
                    int slTonNhan;
                    int slHienTaiNhan = slTonNhan = tkBUS.getSoLuong(tkNhan);
                    slHienTaiNhan = slHienTaiNhan + detailTrans.SoLuong;
                    if (checkMaHangNhan == 1) // nếu có rồi
                    {
                        try
                        {
                            tkBUS.UpdateSoLuong(tkNhan, slHienTaiNhan);
                        }
                        catch (SqlException ex)
                        {
                            XtraMessageBox.Show("Lỗi khi update số lượng kho nhận:  " + ex.Message);
                        }
                    }
                    else // chưa có thì thêm vào
                    {
                        try
                        {
                            tkBUS.insertTonKho(tkNhan, slHienTaiNhan);
                        }
                        catch (SqlException ex)
                        {
                            XtraMessageBox.Show("Lỗi khi thêm mặt hàng vô kho nhận:  " + ex.Message);
                        }

                    }
                }
                XtraMessageBox.Show("Giao dịch thành công");
                txtPhieuCK.Text = inforTransBUS.IDAuto();
                grcChuyenKho.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();
            }
            else
            {
                XtraMessageBox.Show("Giao dịch thất bại");
            }
        }

        public float getTongTien()  // lay duocj tong tien
        {
            int count = grvChuyenKho.RowCount;
            float tongTien = 0;
            for (int i = 0; i < count - 1; i++)
            {
                DetailBuyGoods detailBuy = new DetailBuyGoods();
                DataRow data = grvChuyenKho.GetDataRow(i);
                tongTien += float.Parse(data[6].ToString());
            }
            return tongTien;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            detailBuyBus.deleteChiTietHoaDonAo();

            grcChuyenKho.DataSource = detailBuyBus.getChiTietHoaDonMuaHang();
        }
    }
}
