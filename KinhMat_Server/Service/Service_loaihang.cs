using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KinhMat_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_loaihang" in both code and config file together.
    public class Service_loaihang : IService_loaihang
    {
        Data da_connect = new Data();
        public bool delLoaiHang(string maloai)
        {
            string sql_del = "delete from loaihang where maloai=N'" + maloai + "'";
            try
            {
                da_connect.ExecuteNonquery(sql_del);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi loai hang!" + ex);
                return false;
            }
        }

        public DataTable DGV_LoaiHang()
        {
            string sql = "select * from loaihang ";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(sql);
            return dt;
        }

        public bool editLoaiHang(string maloai, string tenloai,string mal)
        {
            string sql_edit = "Update loaihang set maloai=N'" + maloai + "', tenloai=N'" + tenloai + "' where maloai=N'" + mal + "'";
            try
            {
                da_connect.ExecuteNonquery(sql_edit);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi loai hang!" + ex);
                return false;
            }
        }

        public DataTable get_loaiHang()
        {
            string sql = "select * from loaihang";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(sql);
            return dt;
        }

        public string get_maLoai(string tenloai)
        {
            string sql = "select maloai from loaihang where tenloai=N'" + tenloai + "'";
            string maloai = da_connect.ExecuteScalar(sql);
            return maloai;

        }
        public string get_tenLoai(string maloai)
        {
            string sql = "select tenloai from loaihang where maloai=N'" + maloai + "'";
            string tenloai = da_connect.ExecuteScalar(sql);
            return tenloai;
        }


        public bool Insert_LoaiHang(string maloai,string tenloai)
        {
            string sql_add = "Insert into loaihang values(N'" + maloai + "',N'" + tenloai + "')";
            try
            {
                da_connect.ExecuteNonquery(sql_add);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi loai hang!" + ex);
                return false;
            }
        }

        public DataTable Search_loaiHang(string keyloai)
        {
            string sql = "select * from loaihang where maloai=N'" + keyloai + "'or tenloai=N'" + keyloai + "'";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(sql);
            return dt;
        }

        public DataTable tenloai()
        {
            DataTable dt = new DataTable();
            string sql = "select tenloai from loaihang";
            dt = da_connect.Get_Table(sql);
            return dt;
        }
    }
}
