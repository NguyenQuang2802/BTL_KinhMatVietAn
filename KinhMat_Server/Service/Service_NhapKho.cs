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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_NhapKho" in both code and config file together.
    public class Service_NhapKho : IService_NhapKho
    {
        Data da_connect = new Data();

        public bool check_ID(int idsp)
        {
            string query = "select count(*) from nhapkho where idsp='" + idsp + "'";
            int id =da_connect.ExecuteScalar_int(query);
            if(id > 0)
            {
                return true;
            }
            return false;
        }

        public bool del_nhapkho(int idsp)
        {
            string query = "delete from nhapkho where idsp=N'"+idsp+"'";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!" + ex);
                return false;
            }
        }

        public DataTable DGV_Kho()
        {
            string query = "select sp.idsp, sp.tensp, lh.tenloai,sp.gianhap,nk.ngay, nk.sl, nk.tongtien from sanpham as sp inner join nhapkho as nk on sp.idsp = nk.idsp inner join loaihang as lh on sp.maloai=lh.maloai";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public int get_soluongKho(int idsp)
        {
            string query = "select sl from nhapkho where idsp ='" + idsp + "'";
            int soluong = da_connect.ExecuteScalar_int(query);
            return soluong;
        }

        public int get_TongTien(int idsp)
        {
            string query = "select tongtien from nhapkho where idsp ='" + idsp + "'";
            int thanhtien =da_connect.ExecuteScalar_int(query);
            return thanhtien;
        }

        public bool Insert_NhapKho(int idsp, int soluong, DateTime ngay, int tongtien)
        {

            string query = "Insert into nhapkho values (N'" + idsp + "',N'" + soluong + "',N'" + ngay.ToString("yyyy.MM.dd hh:mm:ss") + "',N'" + tongtien + "')";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi!" + ex);
                return false;
            }
        }

        public DataTable search_Date(DateTime fromdate, DateTime enddate)
        {
            string query = "select sp.idsp, sp.tensp, lh.tenloai,sp.gianhap,nk.ngay, nk.sl, nk.tongtien from sanpham as sp inner join nhapkho as nk on sp.idsp = nk.idsp inner join loaihang as lh on sp.maloai=lh.maloai WHERE nk.ngay BETWEEN CAST('" + fromdate.ToString("yyyy-MM-dd") + "' AS DATE) AND CAST('" + enddate.ToString("yyyy-MM-dd") + "' AS DATE)";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public DataTable search_Loai(string loaisp)
        {
            string query = "select sp.idsp, sp.tensp, lh.tenloai,sp.gianhap,nk.ngay, nk.sl, nk.tongtien from sanpham as sp inner join nhapkho as nk on sp.idsp = nk.idsp inner join loaihang as lh on sp.maloai=lh.maloai where lh.tenloai like N'%" + loaisp + "%'";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public DataTable search_Name(string tensp)
        {
            string query = "select sp.idsp, sp.tensp, lh.tenloai,sp.gianhap,nk.ngay, nk.sl, nk.tongtien from sanpham as sp inner join nhapkho as nk on sp.idsp = nk.idsp inner join loaihang as lh on sp.maloai=lh.maloai where sp.tensp like N'%" + tensp + "%'";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public bool update_SL(int idsp, int sl)
        {
            string query = "update nhapkho set sl=N'" + sl + "' where idsp=N'" + idsp + "' ";
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

        public bool update_TongTien(int idsp, int tongtien)
        {
            string query = "update nhapkho set tongtien=N'" + tongtien + "' where idsp=N'" + idsp + "' ";
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
    }
}
