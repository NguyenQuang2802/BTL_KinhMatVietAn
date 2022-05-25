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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_HoaDon" in both code and config file together.
    [ServiceContract]
    public interface IService_HoaDon
    {
        [OperationContract]
        DataTable DGV_HoaDon();
        [OperationContract]
        bool insert_hoaDon(int idkh, DateTime ngay, int tongtien);
        [OperationContract]
        bool del_hoaDon(int idhd);
        [OperationContract]
        int get_idHD(int idkh);
    }
}
