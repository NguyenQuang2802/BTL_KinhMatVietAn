using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KinhMat_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_loaihang" in both code and config file together.
    [ServiceContract]
    public interface IService_loaihang
    {
        [OperationContract]
        bool Insert_LoaiHang(string maloai,string tenloai);
        [OperationContract]
        bool editLoaiHang(string maloai, string tenloai,string maL);
        [OperationContract]
        bool delLoaiHang(string maloai);
        [OperationContract]
        DataTable DGV_LoaiHang();
        [OperationContract]
        DataTable Search_loaiHang(string keyloai);
        [OperationContract]
        DataTable get_loaiHang();
        [OperationContract]
        string get_maLoai(string tenloai);
        [OperationContract]
        string get_tenLoai(string maloai);

        [OperationContract]
        DataTable tenloai();

    }
}
