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
    public partial class Form_themLoai : Form
    {
        public Form_themLoai()
        {
            InitializeComponent();
        }
        string mal;
        ServiceReference_loaiHang.Service_loaihangClient sv_lh = new ServiceReference_loaiHang.Service_loaihangClient();
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_maLoai.Text == "")
            {
                MessageBox.Show("Chưa Nhập mã loại");
                tb_maLoai.Focus();
            }
            else
            {
                try
                {
                    sv_lh.Insert_LoaiHang(this.tb_maLoai.Text, this.tb_tenLoai.Text);
                    MessageBox.Show("Thêm thành công");
                    HienThi_DGV();
                    Reset_form();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi!");
                }
            }
        }
        public void HienThi_DGV()
        {
            DataTable dt = new DataTable();
            dt = sv_lh.DGV_LoaiHang();
            DGV_Loai.DataSource = dt;

        }
        public void Reset_form()
        {
            tb_maLoai.Clear();
            tb_tenLoai.Clear();
            tb_keyLoai.Clear();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tb_maLoai.Text == "")
            {
                MessageBox.Show("Chưa Nhập mã loại");
                tb_maLoai.Focus();
            }
            else
            {
                try
                {
                    sv_lh.editLoaiHang(this.tb_maLoai.Text, this.tb_tenLoai.Text, this.mal);
                    MessageBox.Show("Sửa thành công");
                    HienThi_DGV();
                    Reset_form();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi!" + ex);
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tb_maLoai.Text == "")
            {
                MessageBox.Show("Chưa nhập mã loại");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    sv_lh.delLoaiHang(this.tb_maLoai.Text);
                    MessageBox.Show("Xóa thành công");
                    HienThi_DGV();
                    Reset_form();
                }
            }
        }

        private void Form_themLoai_Load(object sender, EventArgs e)
        {
            HienThi_DGV();
        }

        private void bt_keyLoai_Click(object sender, EventArgs e)
        {
            if (tb_keyLoai.Text == "")
            {
                MessageBox.Show("Chưa Nhập tìm kiếm");
                tb_keyLoai.Focus();
                HienThi_DGV();
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = sv_lh.Search_loaiHang(this.tb_keyLoai.Text);
                    DGV_Loai.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi" + ex);
                }
            }
        }

        private void DGV_Loai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mal = DGV_Loai.Rows[dong].Cells[0].Value.ToString();
            tb_maLoai.Text = DGV_Loai.Rows[dong].Cells[0].Value.ToString();
            tb_tenLoai.Text = DGV_Loai.Rows[dong].Cells[1].Value.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
