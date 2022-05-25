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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_ChiTietHoaDon" in both code and config file together.
    [ServiceContract]
    public interface IService_ChiTietHoaDon
    {
        [OperationContract]
        bool insert_CTHD(int idhd,int idsp,int soluong,int thanhtien);
        [OperationContract]
        DataTable DGV_CTHD();

    }
}
