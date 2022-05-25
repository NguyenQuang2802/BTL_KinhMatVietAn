using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace KinhMat_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_SanPham" in both code and config file together.
    public class Service_SanPham : IService_SanPham
    {
        Data da_connect = new Data();
        public bool del_NhapHang(int idsp)
        {
            string sql_del = "delete from sanpham where idsp=N'" + idsp + "'";
            try
            {
                da_connect.ExecuteNonquery(sql_del);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable DGV_NhapHang()
        {
            string sql = "select sp.idsp, sp.tensp, lh.tenloai,sp.gianhap,sp.giaban, sp.soluong, nk.tongtien from sanpham as sp inner join loaihang as lh on sp.maloai = lh.maloai inner join nhapkho as nk on sp.idsp = nk.idsp"; 
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(sql);
            return dt;
        }

        public bool edit_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong, string id)
        {
            string sql_edit = "Update sanpham set tensp=N'" + tensp + "', maloai=N'" + maloai + "', gianhap=N'" + gianhap + "', giaban=N'" + giaban + "', soluong=N'" + soluong + "' where tensp=N'" + id + "'";
            try
            {
                da_connect.ExecuteNonquery(sql_edit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int get_Count()
        {
            string query = "SELECT COUNT(*) FROM sanpham";
            int count = da_connect.ExecuteScalar_int(query);
            return count;
        }

        public int get_DonGiaHang(string tensp)
        {
            string query = "SELECT giaban FROM sanpham WHERE tensp = N'" + tensp + "'";
            int giaban = da_connect.ExecuteScalar_int(query);
            return giaban;
        }

        public int get_IDHang(string tensp)
        {
            string query = "SELECT idsp FROM sanpham WHERE tensp = N'" + tensp + "'";
            int idsp = da_connect.ExecuteScalar_int(query);
            return idsp;
        }

        public int get_SoLuongHang(int idsp)
        {
            string query = "SELECT soluong FROM sanpham WHERE idsp = N'" + idsp + "'";
            int soluong = da_connect.ExecuteScalar_int(query);
            return soluong;
        }

        public string get_maLoai(int idsp)
        {
                string sql = "select maloai from sanpham where idsp='" + idsp + "'";
                string tenloai = da_connect.ExecuteScalar(sql);
                return tenloai;
        }

        public DataTable get_tenSP()
        {
            string sql = "select tensp from sanpham";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(sql);
            return dt;
        }

        public bool Insert_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong)
        {
            string sql_add = "Insert into sanpham values (N'" + tensp + "',N'" + maloai + "','" + gianhap + "','" + giaban + "','" + soluong + "')";
            try
            {
                da_connect.ExecuteNonquery(sql_add);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable Search_NhapHang(string keysp)
        {
            string sql = "select sp.tensp, lh.tenloai,sp.gianhap,sp.giaban, sp.soluong, nk.tongtien from sanpham as sp inner join loaihang as lh on sp.maloai = lh.maloai inner join nhapkho as nk on sp.idsp = nk.idsp where sp.tensp like N'%" + keysp + "%' or lh.tenloai like N'%" + keysp + "%'";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(sql);
            return dt;
        }

        public bool update_SoLuongHang(int idsp, int soluong)
        {
            string query = "UPDATE sanpham SET soluong = N'" + soluong + "' WHERE idsp =N'" + idsp + "'";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int get_GiaNhap(string tensp)
        {
            string query = "SELECT gianhap FROM sanpham WHERE tensp = N'" + tensp + "'";
            int gianhap = da_connect.ExecuteScalar_int(query);
            return gianhap;
        }
    }
}
