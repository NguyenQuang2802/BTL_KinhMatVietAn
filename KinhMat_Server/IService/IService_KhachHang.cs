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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_KhachHang" in both code and config file together.
    [ServiceContract]
    public interface IService_KhachHang
    {
        [OperationContract]
        DataTable DGV_KH();
        [OperationContract]
        bool insert(string tenkh, int sdt, string diachi);
        [OperationContract]
        bool delete_KH(int idkh);
        [OperationContract]
        int get_idKH(string tenkh);
        [OperationContract]
        DataTable search_KH(string keyKH);
    }
}
