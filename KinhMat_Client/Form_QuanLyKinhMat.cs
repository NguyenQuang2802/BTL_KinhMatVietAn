using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinhMat_Client
{
    public partial class Form_QuanLyKinhMat : Form
    {
        public Form_QuanLyKinhMat()
        {
            InitializeComponent();
        }
        ServiceReference_Nhapkho.Service_NhapKhoClient sv_nhap = new ServiceReference_Nhapkho.Service_NhapKhoClient();
        ServiceReference_loaiHang.Service_loaihangClient sv_lh = new ServiceReference_loaiHang.Service_loaihangClient();
        ServiceReference_sanPham.Service_SanPhamClient sv_sp = new ServiceReference_sanPham.Service_SanPhamClient();
        ServiceReference_khachHang.Service_KhachHangClient sv_kh = new ServiceReference_khachHang.Service_KhachHangClient();
        ServiceReference_chiTietHD.Service_ChiTietHoaDonClient sv_cthd = new ServiceReference_chiTietHD.Service_ChiTietHoaDonClient();
        ServiceReference_hoaDon.Service_HoaDonClient sv_hd = new ServiceReference_hoaDon.Service_HoaDonClient();
        ServiceReference_xuatKho.Service_XuatKhoClient sv_xuat = new ServiceReference_xuatKho.Service_XuatKhoClient();

//--------------------------------------------SẢN PHẨM---------------------------------------------------------
        string tsp;
        private void bt_Them_Click(object sender, EventArgs e)
        {
           string tensp = tb_tenSP.Text.Trim();
            if (tensp == "")
            {
                MessageBox.Show("Điền tên sản phẩm", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tb_tenSP.Focus();
                this.DialogResult = DialogResult.None;
            }
            else if (tb_giaNhap.Text == "")
            {
                MessageBox.Show("Nhập giá nhập", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                tb_giaNhap.Focus();
                this.DialogResult = DialogResult.None;
            }
            else if (tb_giaBan.Text == "")
            {
                MessageBox.Show("Nhập giá bán", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                tb_giaBan.Focus();
                this.DialogResult = DialogResult.None;
            }
            else
            {
                try
                {
                    int gianhap = int.Parse(tb_giaNhap.Text);
                    int giaban = int.Parse(tb_giaBan.Text);
                    int soluong = (int)tb_SL.Value;
                    string maloai= sv_lh.get_maLoai(this.cb_loaiSP.Text);
                    if (sv_sp.Insert_NhapHang(tensp, maloai, gianhap, giaban, soluong))
                    {
                        int idsp = sv_sp.get_IDHang(tensp);
                        int tongtien = gianhap * soluong;
                        sv_nhap.Insert_NhapKho(idsp, soluong, DateTime.Now, tongtien);
                        MessageBox.Show("Thêm thành công");
                        DGV_Kho();
                        Reset_form();
                    }
                    else
                    {
                        MessageBox.Show("lỗi!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi!"+ex);
                }
            }
        }
        public void DGV_Kho()
        {
            DataTable dt = new DataTable();
            dt = sv_sp.DGV_NhapHang();
            DGV_SP.DataSource = dt;

        }
        public void Reset_form()
        {
            tb_tenSP.Clear();
            cb_loaiSP.Text="";
            tb_keySP.Clear();
            tb_giaNhap.Clear();
            tb_giaBan.Clear();
            tb_SL.Value = 0;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tb_tenSP.Text == "")
            {
                MessageBox.Show("Chưa Nhập tên sản phẩm");
                tb_tenSP.Focus();
            }
            else if (tb_giaNhap.Text == "")
            {
                MessageBox.Show("Nhập giá nhập", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                tb_giaNhap.Focus();
                this.DialogResult = DialogResult.None;
            }
            else if (tb_giaBan.Text == "")
            {
                MessageBox.Show("Nhập giá bán", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                tb_giaBan.Focus();
                this.DialogResult = DialogResult.None;
            }
            else
            {
                try
                {
                    string tensp = tb_tenSP.Text;
                    int gianhap = int.Parse(tb_giaNhap.Text);
                    int soluong = (int)tb_SL.Value;
                    string maloai = sv_lh.get_maLoai(this.cb_loaiSP.Text);
                    sv_sp.edit_NhapHang(tensp, maloai, gianhap, Convert.ToInt32(tb_giaBan.Text), soluong, tsp);
                    int id = sv_sp.get_IDHang(tensp);
                    int get_gianhap = sv_sp.get_GiaNhap(tensp);
                    int get_sl = sv_nhap.get_soluongKho(id);
                    if ((gianhap != get_gianhap) || (soluong != get_sl))
                    {
                        sv_nhap.update_SL(id, soluong);
                        int tongtien = gianhap * soluong;
                        sv_nhap.update_TongTien(id, tongtien);
                    }
                    MessageBox.Show("Sửa thành công");
                    DGV_Kho();
                    Reset_form();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi from admin!" + ex);
                }
            }
        }

        // Hiển thị CB
        public void hienThi_CBNK()
        {
            DataTable dt = new DataTable();
            dt = sv_lh.get_loaiHang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_loaiSP.Items.Add(dt.Rows[i].Field<string>(1));
            }

        }
        public void hienThi_CBXK()
        {
            DataTable dt = new DataTable();
            dt = sv_sp.get_tenSP();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_sanpham.Items.Add(dt.Rows[i].Field<string>(0));
            }
        }
        public void hienThi_CBTK()
        {
            DataTable dt = new DataTable();
            dt = sv_lh.get_loaiHang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_keyLoaiSP.Items.Add(dt.Rows[i].Field<string>(1));
            }
            dt = sv_sp.get_tenSP();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 cb_keyTenSP.Items.Add(dt.Rows[i].Field<string>(0));
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hienThi_CBXK();
            DGV_khachHang();
        }

        private void bt_xoaSP_Click(object sender, EventArgs e)
        {
            if (tb_tenSP.Text == "")
            {
                MessageBox.Show("Chưa Nhập mã loại");
                tb_tenSP.Focus();
            }
            else
            {
                try
                {
                    int idsp = sv_sp.get_IDHang(tb_tenSP.Text);
                    sv_nhap.del_nhapkho(idsp);
                    sv_sp.del_NhapHang(idsp);
                    MessageBox.Show("Xóa thành công");
                    DGV_Kho();
                    Reset_form();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi!" + ex);
                }
            }

        }

        private void bt_addloai_Click(object sender, EventArgs e)
        {
            Form_themLoai form = new Form_themLoai();
            form.ShowDialog();
            cb_loaiSP.Items.Clear();
            hienThi_CBNK();
        }

        private void bt_ResetSP_Click(object sender, EventArgs e)
        {
            DGV_Kho();
            Reset_form();

        }

        private void DGV_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            tsp = DGV_SP.Rows[dong].Cells[1].Value.ToString();
            tb_tenSP.Text = DGV_SP.Rows[dong].Cells[1].Value.ToString();
            cb_loaiSP.Text = DGV_SP.Rows[dong].Cells[2].Value.ToString();
            tb_giaNhap.Text = DGV_SP.Rows[dong].Cells[3].Value.ToString();
            tb_giaBan.Text = DGV_SP.Rows[dong].Cells[4].Value.ToString();
            tb_SL.Text = DGV_SP.Rows[dong].Cells[5].Value.ToString();
        }

        private void bt_keysp_Click(object sender, EventArgs e)
        {
            if (tb_keySP.Text == "")
            {
                MessageBox.Show("Chưa Nhập tìm kiếm");
                tb_keySP.Focus();
                DGV_Kho();
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = sv_sp.Search_NhapHang(this.tb_keySP.Text);
                    DGV_SP.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi" + ex);
                }
            }
        }
        // chỉ cho phép nhập số
        private void tb_giaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        /*------------------------------phiếu xuất kho--------------------------------------*/
        public int mStt = 1;
        int mTong;
        int mSoluong;
        private void bt_themgio_Click(object sender, EventArgs e)
        {
            if (cb_sanpham.SelectedItem != null)
            {
                string tensp = cb_sanpham.SelectedItem.ToString();
                int masp =  sv_sp.get_IDHang(tensp);
                string maloai = sv_sp.get_maLoai(masp);
                string tenloai = sv_lh.get_tenLoai(maloai);
                int soluong = (int)tb_SLXuat.Value;
                int dongia = sv_sp.get_DonGiaHang(tensp);
                int tongtien = soluong * dongia;
                mTong += tongtien;
                mSoluong += soluong;
                //Neu san pham chua co trong listview hoa don thi them moi
                //Khong thi se tang so luong cua sp do trong listview
                if (checkSp(tensp) == -1)
                {
                    ListViewItem lvi = new ListViewItem(mStt + "");
                    lvi.SubItems.Add("MSP-" + masp);
                    lvi.SubItems.Add(tensp);
                    lvi.SubItems.Add(tenloai);
                    lvi.SubItems.Add(soluong + "");
                    lvi.SubItems.Add(dongia + "");
                    lvi.SubItems.Add(tongtien + "");

                    labelTongtien.Text = mTong + "  VND";
                    labelSoluong.Text = mSoluong + "";

                    listViewHoaDon.Items.Add(lvi);
                    mStt++;
                }
                else
                {
                    int indexItem = checkSp(tensp);
                    soluong = soluong + getSoluong(indexItem);
                    tongtien = soluong * dongia;
                    listViewHoaDon.Items[indexItem].SubItems[4].Text = soluong + "";
                    listViewHoaDon.Items[indexItem].SubItems[6].Text = tongtien + "";

                    labelTongtien.Text = mTong + "  VND";
                    labelSoluong.Text = mSoluong + "";
                }
            }
        }
        // check sp đã có chưa?
        public int checkSp(string tensp)
        {
            foreach (ListViewItem item in listViewHoaDon.Items)
            {
                if (item.SubItems[2].Text.ToString() == tensp)
                {
                    return item.Index;
                }
            }
            return -1;
        }
        //Lay ra so luong cua san pham da mua
        public int getSoluong(int index)
        {
            return int.Parse(listViewHoaDon.Items[index].SubItems[4].Text);
        }
        // Sửa kích thước của listview
        private void listViewHoaDon_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewHoaDon.Columns[e.ColumnIndex].Width;
        }

        //Reset lai phieu 
        public void clearPhieuXuatKho()
        {
            labelSoluong.Text = 0 + "";
            labelTongtien.Text = "0 VND";
            tb_SLXuat.Value = 1;
            tb_tenKH.Text = "";
            tb_sdt.Text = "";
            tb_diachi.Text = "";
            cb_sanpham.SelectedItem = null;
            listViewHoaDon.Clear();
        }
        //chỉ nhập số trong dt
        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //Xoa san pham khoi listview
        private void ctx_Xoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewHoaDon.SelectedItems)
            {
                if (item.Selected)
                {
                    item.Remove();
                    int sl = int.Parse(item.SubItems[4].Text);
                    int tong = int.Parse(item.SubItems[6].Text);
                    updatePhieu(sl, tong);
                }
            }
        }
        //Update lai thong tin phieu khi xoa san pham
        public void updatePhieu(int sl, int tongtien)
        {
            int solg = int.Parse(labelSoluong.Text);
            int tong = int.Parse(labelTongtien.Text.ToString().Replace("  VND", ""));

            --mStt;
            mTong = tong - tongtien;
            mSoluong = solg - sl;

            labelTongtien.Text = mTong + "  VND";
            labelSoluong.Text = mSoluong + "";
        }
        
        //Hien thi context menu khi click chuotphai vao list item
        private void listViewHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (ListViewItem item in listViewHoaDon.SelectedItems)
                {
                    if (item.Selected)
                    {
                        contextMenuList.Show(listViewHoaDon, new Point(e.X, e.Y));
                    }
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;

        private void bt_inHD_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, graphics);
            Graphics mg = Graphics.FromImage(bitmap);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void bt_thanhToan_Click(object sender, EventArgs e)
        {
            string tenkh = tb_tenKH.Text.Trim();
            int sdt =int.Parse(tb_sdt.Text);
            string diachi = tb_diachi.Text.Trim();

            if (tenkh == "")
            {
                MessageBox.Show("Vui lòng điền tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (diachi == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bt_thanhToan.Enabled = false;
                //Them moi khac hang
                sv_kh.insert(tenkh, sdt, diachi);
                int idkh = sv_kh.get_idKH(tenkh);
                //check xem đã có sản phẩm nào chưa thì mới tạo hóa đơn
                if (listViewHoaDon.Items.Count > 0)
                {
                    try
                    {
                        sv_hd.insert_hoaDon(idkh, DateTime.Now, mTong);
                        MessageBox.Show("Thanh Toán Thành Công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi!" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thêm sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                int idhd = sv_hd.get_idHD(idkh);
                //Them cac san pham da chon vao chitiethoadon
                foreach (ListViewItem item in listViewHoaDon.Items)
                {
                    int idsp = int.Parse(item.SubItems[1].Text.Replace("MSP-", ""));
                    int sl = int.Parse(item.SubItems[4].Text);
                    int thanhtien = int.Parse(item.SubItems[6].Text);
                    sv_cthd.insert_CTHD(idhd, idsp, sl, thanhtien);

                    addXuatKho(idsp, sl, thanhtien);

                    truSoluong(idsp, sv_sp.get_SoLuongHang(idsp) - sl);
                }
            }
        }

        //Them vao bang xuat kho
        public void addXuatKho(int idsp, int sl, int thanhtien)
        {

            if (sv_xuat.check_IDXuat(idsp ))
            {
                sl += sv_xuat.get_soLuongXuat(idsp);
                thanhtien += sv_xuat.get_tongTienXuat(idsp);
                sv_xuat.update_SLXuat(idsp, sl);
                sv_xuat.update_tongTienXuat(idsp, thanhtien);
            }
            else
            {
                sv_xuat.insert_xuatKho(idsp, sl, thanhtien, DateTime.Now);
            }
        }
        public void truSoluong(int idsp, int sl)
        {
            sv_sp.update_SoLuongHang(idsp, sl);
        }

        //Click huy tao hoa don
        private void bt_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy hóa đơn không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                clearPhieuXuatKho();
            }
        }


        /*--------------------------------Khách Hàng-----------------------------------------*/
        public void DGV_khachHang()
        {
            dgvKhachHang.DataSource = sv_kh.DGV_KH();
            int stt = 1;
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                
                row.Cells[0].Value =stt;
                stt++;
                string idkh = row.Cells[2].Value.ToString();
                row.Cells[1].Value = "MKH " + idkh;

            }

        }

        private void bt_TKKhachHang_Click(object sender, EventArgs e)
        {
            string key = tb_keyKH.Text.Trim();
            if (key != "")
            {
                dgvKhachHang.DataSource = sv_kh.search_KH(key);
                dgvKhachHang.ClearSelection();
            }
        }

        /*--------------------------------Thống Kê Nhập Xuất-----------------------------------------*/
        //Xu li thong tin nhap hang
        public void nhapHang()
        {
            //Lay du lieu bang nhap kho
            dgvNhapKho.DataSource = sv_nhap.DGV_Kho();
            setSTT(dgvNhapKho);
        }

        //Xu li thong tin xuat hang
        public void xuatHang()
        {
            //lay du lieu trong bang xuat kho
            dgvXuathang.DataSource = sv_xuat.DGV_xuatKho();
            setSTT(dgvXuathang);
        }

        //Danh stt, masp
        public void setSTT(DataGridView dataGrid)
        {
            int tong = 0;
            int sl = 0;
            int stt = 1;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
               
                row.Cells[0].Value = stt;
                stt++;
                string idsp = row.Cells[2].Value.ToString();
                row.Cells[1].Value = "MSP-" + idsp;
               

                tong += (int)row.Cells[8].Value;
                sl += (int)row.Cells[7].Value;

                dataGrid.ClearSelection();
            }
            if (dataGrid == dgvNhapKho)
            {
                labelTongNhap.Text = tong + " VND";
                labelSlNhap.Text = sl.ToString();
            }
            else
            {
                labelTongXuat.Text = tong + " VND";
                labelSlXuat.Text = sl.ToString();
            }
        }

        private void bt_tkTenSP_Click(object sender, EventArgs e)
        {
            string tensp = cb_keyTenSP.Text;
            if (tensp != "")
            {
                dgvNhapKho.DataSource = sv_nhap.search_Name(tensp);
                dgvXuathang.DataSource = sv_xuat.search_nameXK(tensp);

                setSTT(dgvXuathang);
                setSTT(dgvNhapKho);
            }
        }

        private void bt_timDate_Click(object sender, EventArgs e)
        {
         
            DateTime fromdate = dateFrom.Value;
            DateTime enddate = dateTo.Value;
            dgvNhapKho.DataSource = sv_nhap.search_Date(fromdate, enddate);
            dgvXuathang.DataSource = sv_xuat.search_dateXK(fromdate, enddate);
            setSTT(dgvXuathang);
            setSTT(dgvNhapKho);
        }

        private void bt_tkLoaiSP_Click(object sender, EventArgs e)
        {
            string loai = cb_keyLoaiSP.Text;
            if (loai != "")
            {
                dgvNhapKho.DataSource = sv_nhap.search_Loai(loai);
                dgvXuathang.DataSource = sv_xuat.search_loaiXk(loai);

                setSTT(dgvXuathang);
                setSTT(dgvNhapKho);
            }
        }


        /*-----------------------------------Chuyển tap---------------------------------*/
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvKhachHang.ClearSelection();
            dgvNhapKho.ClearSelection();
            DGV_SP.ClearSelection();
            dgvXuathang.ClearSelection();

            //Tab phieu xuat kho
            if (tabControl1.SelectedIndex == 0)
            {
                cb_sanpham.Items.Clear();
                mStt = 1;
                mTong = 0;
                mSoluong = 0;
                bt_thanhToan.Enabled = true;
                hienThi_CBXK();
                
            }
            else
            {
                clearPhieuXuatKho();
                listViewHoaDon.Columns.Add("STT", 50);
                listViewHoaDon.Columns.Add("Mã sản phẩm", 120);
                listViewHoaDon.Columns.Add("Tên sản phẩm", 400);
                listViewHoaDon.Columns.Add("Số lượng", 100);
                listViewHoaDon.Columns.Add("Đơn giá", 180);
                listViewHoaDon.Columns.Add("Tổng tiền", 360);
            }

            //Tab khach hang
            if (tabControl1.SelectedIndex == 1)
            {
                DGV_khachHang();
                dgvKhachHang.ClearSelection();
            }

            //Tab quan li kho
            if (tabControl1.SelectedIndex == 2)
            {
                cb_loaiSP.Items.Clear();
                DGV_Kho();
                DGV_SP.ClearSelection();
                hienthi();
            }

            //Tab thong ke nhap xuat
            if (tabControl1.SelectedIndex == 3)
            {
                cb_keyLoaiSP.Items.Clear();
                cb_keyTenSP.Items.Clear();
                xuatHang();
                nhapHang();
                hienThi_CBTK();
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_tenKH.Clear();
            tb_sdt.Clear();
            tb_diachi.Clear();
            cb_sanpham.Text = "";
            tb_SLXuat.Value = 1;
        }

          public void hienthi()
        {
            DataTable dt = new DataTable();
            dt = sv_lh.tenloai();
            for (int i = 0; i< dt.Rows.Count; i++)
            {
                cb_loaiSP.Items.Add(dt.Rows[i].Field<string>(0));
            }
        }
    }
}
