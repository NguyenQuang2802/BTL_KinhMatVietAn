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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_ChiTietHoaDon" in both code and config file together.
    public class Service_ChiTietHoaDon : IService_ChiTietHoaDon
    {
        Data da_connect = new Data();
        string query;
        public DataTable DGV_CTHD()
        {
            query = "select sp.idsp, sp.tensp, lh.tenloai, ct.soluong, ct.thanhtien from sanpham as sp inner join chitiethoadon as ct on ct.idsp = sp.idsp  inner join hoadon as hd on hd.idhd = ct.idhd  inner join loaihang as lh on sp.maloai = lh.maloai where hd.ngay = CONVERT(date, GETDATE())";
            DataTable dt = new DataTable();
            dt =da_connect.Get_Table(query);
            return dt;
        }

        public bool insert_CTHD(int idhd, int idsp, int soluong, int thanhtien)
        {
            query = "insert into chitiethoadon values ('" + idhd + "','" + idsp + "','" + soluong + "','" + thanhtien + "')";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi CTHD!\n" + ex);
                return false;
            }
        }
    }
}
