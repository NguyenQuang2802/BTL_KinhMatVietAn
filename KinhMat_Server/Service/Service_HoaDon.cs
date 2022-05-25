using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace KinhMat_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_HoaDon" in both code and config file together.
    public class Service_HoaDon : IService_HoaDon
    {
        Data da_connect = new Data();
        string query;
        public bool del_hoaDon(int idhd)
        {
            query = "delete hoadon where idhd='" + idhd + "'";
            try
            {
                da_connect.ExecuteNonquery(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi hoadon!" + ex);
                return false;
            }
        }

        public DataTable DGV_HoaDon()
        {
            query = "SELECT * FROM hoadon";
            DataTable dt = new DataTable();
            dt = da_connect.Get_Table(query);
            return dt;
        }

        public int get_idHD(int idkh)
        {
            query = "select idhd from hoadon where idkh='" + idkh + "'";
            int idhd = da_connect.ExecuteScalar_int(query);
            return idhd;
        }

        public bool insert_hoaDon(int idkh, DateTime ngay, int tongtien)
        {
            query = "insert into hoadon values ('" + idkh + "',N'" + ngay.ToString("yyyy-MM-dd") + "','" + tongtien + "')";
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
