using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KinhMat_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_XuatKho" in both code and config file together.
    [ServiceContract]
    public interface IService_XuatKho
    {
        [OperationContract]
        DataTable DGV_xuatKho();
        [OperationContract]
        bool insert_xuatKho(int idsp,int sl,int thanhtien, DateTime ngay);
        [OperationContract]
        bool check_IDXuat(int idsp);
        [OperationContract]
        int get_soLuongXuat(int idsp);
        [OperationContract]
        bool update_SLXuat(int idsp, int sl);
        [OperationContract]
        int get_tongTienXuat(int idsp);
        [OperationContract]
        bool update_tongTienXuat(int idsp, int thanhtien);
        [OperationContract]
        DataTable search_loaiXk(string loaisp);
        [OperationContract]
        DataTable search_dateXK(DateTime fromdate, DateTime enddate);
        [OperationContract]
        DataTable search_nameXK(string tensp);
    }
}
