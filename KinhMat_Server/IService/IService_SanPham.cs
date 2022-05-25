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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_SanPham" in both code and config file together.
    [ServiceContract]
    public interface IService_SanPham
    {
        [OperationContract]
        bool Insert_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong);
        [OperationContract]
        bool edit_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong, string id);
        [OperationContract]
        bool del_NhapHang(int idsp);
        [OperationContract]
        DataTable DGV_NhapHang();
        [OperationContract]
        DataTable Search_NhapHang(string keysp);
        [OperationContract]
        int get_SoLuongHang(int idsp);
        [OperationContract]
        bool update_SoLuongHang(int idsp, int soluong);
        [OperationContract]
        int get_IDHang(string tensp);
        [OperationContract]
        int get_DonGiaHang(string tensp);
        [OperationContract]
        int get_GiaNhap(string tensp);
        [OperationContract]
        int get_Count();
        [OperationContract]
        DataTable get_tenSP();
        [OperationContract]
        string get_maLoai(int idsp);
    }
}
