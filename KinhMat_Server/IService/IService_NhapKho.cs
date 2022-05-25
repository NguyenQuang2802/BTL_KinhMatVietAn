using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KinhMat_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_NhapKho" in both code and config file together.
    [ServiceContract]
    public interface IService_NhapKho
    {
        [OperationContract]
        bool Insert_NhapKho(int idsp, int soluong, DateTime ngay,int tongtien);
        [OperationContract]
        bool del_nhapkho(int idsp);
        [OperationContract]
        bool check_ID(int idsp);
        [OperationContract]
        int get_soluongKho(int idsp);
        [OperationContract]
        DataTable DGV_Kho();
        [OperationContract]
        bool update_SL(int idsp,int sl);
        [OperationContract]
        int get_TongTien(int idsp);
        [OperationContract]
        bool update_TongTien(int idsp,int tongtien);
        [OperationContract]
        DataTable search_Name(string tensp);
        [OperationContract]
        DataTable search_Loai(string loaisp);
        [OperationContract]
        DataTable search_Date(DateTime fromdate,DateTime enddate);
    }
}
