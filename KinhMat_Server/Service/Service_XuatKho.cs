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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_XuatKho" in both code and config file together.
    public class Service_XuatKho : IService_XuatKho
    {
        Data da_connect = new Data();
        string query;
        public bool check_IDXuat(int idsp)
        {
            query = "SELECT COUNT(*) FROM xuatkho WHERE idsp = N'"+idsp+"'";
            int id = da_connect.ExecuteScalar_int(query);
            if(id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public DataTable DGV_xuatKho()
        {
           query = "select sp.idsp, sp.tensp, lh.tenloai,sp.giaban,xk.ngay, xk.sl, xk.thanhtien from sanpham as sp inner join xuatkho as xk on sp.idsp = xk.idsp  inner join loaihang as lh on sp.maloai = lh.maloai";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public int get_soLuongXuat(int idsp)
        {
            query = "SELECT sl FROM xuatkho WHERE idsp = '" + idsp + "'";
            int sl = da_connect.ExecuteScalar_int(query);
            return sl;
        }

        public int get_tongTienXuat(int idsp)
        {
            query = "select thanhtien from xuatkho where idsp='" + idsp + "'";
            int thanhtien = da_connect.ExecuteScalar_int(query);
            return thanhtien;
        }

        public bool insert_xuatKho(int idsp, int sl, int thanhtien, DateTime ngay)
        {
            query = "insert into xuatkho values ('" + idsp + "','" + sl + "','" + thanhtien + "','" + ngay.ToString("yyyy.MM.dd hh:mm:ss") + "')";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi xuat kho !\n" + ex);
                return false;
            }
        }
        public DataTable search_dateXK(DateTime fromdate, DateTime enddate)
        {
           query = "select sp.idsp, sp.tensp, lh.tenloai ,sp.giaban,xk.ngay, xk.sl, xk.thanhtien from sanpham as sp inner join xuatkho as xk on sp.idsp = xk.idsp  inner join loaihang as lh on sp.maloai = lh.maloai WHERE xk.ngay BETWEEN CAST('" + fromdate.ToString("yyyy-MM-dd") + "' AS DATE) AND CAST('" + enddate.ToString("yyyy-MM-dd") + "' AS DATE)";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public DataTable search_loaiXk(string loaisp)
        {
            query = "select sp.idsp, sp.tensp, lh.tenloai ,sp.giaban,xk.ngay, xk.sl, xk.thanhtien from sanpham as sp inner join xuatkho as xk on sp.idsp = xk.idsp  inner join loaihang as lh on sp.maloai = lh.maloai WHERE lh.tenloai=N'"+loaisp+"'";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public DataTable search_nameXK(string tensp)
        {
            query = "select sp.idsp, sp.tensp, lh.tenloai ,sp.giaban,xk.ngay, xk.sl, xk.thanhtien from sanpham as sp inner join xuatkho as xk on sp.idsp = xk.idsp  inner join loaihang as lh on sp.maloai = lh.maloai WHERE sp.tensp=N'"+tensp+"'";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public bool update_SLXuat(int idsp, int sl)
        {
            query = "update xuatkho set sl ='" + sl + "' where idsp='" + idsp + "'";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi xuat kho !\n" + ex);
                return false;

            }
        }

        public bool update_tongTienXuat(int idsp, int thanhtien)
        {
            query = "update xuatkho set thanhtien ='" + thanhtien + "' where idsp='" + idsp + "'";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi xuat kho !\n" + ex);
                return false;

            }
        }
    }
}
