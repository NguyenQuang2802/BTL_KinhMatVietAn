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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_KhachHang" in both code and config file together.
    public class Service_KhachHang : IService_KhachHang
    {
        Data da_connect = new Data();
        string query;
        public bool delete_KH(int idkh)
        {
          query = "delete khachhang where idkh=N'" + idkh + "'";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi!" + ex);
                return false;
            }
        }

        public DataTable DGV_KH()
        {
            query = "SELECT * FROM khachhang";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public int get_idKH(string tenkh)
        {
            query = "select idkh from khachhang where tenkh=N'" + tenkh + "'";
            int idkh = da_connect.ExecuteScalar_int(query);
            return idkh;
        }

        public bool insert(string tenkh, int sdt, string diachi)
        {
            query = "insert into khachhang values (N'" + tenkh + "','" + sdt + "',N'" + diachi + "')";
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

        public DataTable search_KH(string keyKH)
        {
            query = "select * from khachhang where tenkh like N'" + keyKH + "'";
            DataTable dt = new DataTable();
            dt =da_connect.Get_Table(query);
            return dt;
        }
    }
}
