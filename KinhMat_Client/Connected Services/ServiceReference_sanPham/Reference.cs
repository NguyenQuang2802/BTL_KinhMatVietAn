//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinhMat_Client.ServiceReference_sanPham {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_sanPham.IService_SanPham")]
    public interface IService_SanPham {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/Insert_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/Insert_NhapHangResponse")]
        bool Insert_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/Insert_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/Insert_NhapHangResponse")]
        System.Threading.Tasks.Task<bool> Insert_NhapHangAsync(string tensp, string maloai, int gianhap, int giaban, int soluong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/edit_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/edit_NhapHangResponse")]
        bool edit_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/edit_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/edit_NhapHangResponse")]
        System.Threading.Tasks.Task<bool> edit_NhapHangAsync(string tensp, string maloai, int gianhap, int giaban, int soluong, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/del_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/del_NhapHangResponse")]
        bool del_NhapHang(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/del_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/del_NhapHangResponse")]
        System.Threading.Tasks.Task<bool> del_NhapHangAsync(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/DGV_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/DGV_NhapHangResponse")]
        System.Data.DataTable DGV_NhapHang();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/DGV_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/DGV_NhapHangResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> DGV_NhapHangAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/Search_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/Search_NhapHangResponse")]
        System.Data.DataTable Search_NhapHang(string keysp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/Search_NhapHang", ReplyAction="http://tempuri.org/IService_SanPham/Search_NhapHangResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> Search_NhapHangAsync(string keysp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_SoLuongHang", ReplyAction="http://tempuri.org/IService_SanPham/get_SoLuongHangResponse")]
        int get_SoLuongHang(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_SoLuongHang", ReplyAction="http://tempuri.org/IService_SanPham/get_SoLuongHangResponse")]
        System.Threading.Tasks.Task<int> get_SoLuongHangAsync(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/update_SoLuongHang", ReplyAction="http://tempuri.org/IService_SanPham/update_SoLuongHangResponse")]
        bool update_SoLuongHang(int idsp, int soluong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/update_SoLuongHang", ReplyAction="http://tempuri.org/IService_SanPham/update_SoLuongHangResponse")]
        System.Threading.Tasks.Task<bool> update_SoLuongHangAsync(int idsp, int soluong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_IDHang", ReplyAction="http://tempuri.org/IService_SanPham/get_IDHangResponse")]
        int get_IDHang(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_IDHang", ReplyAction="http://tempuri.org/IService_SanPham/get_IDHangResponse")]
        System.Threading.Tasks.Task<int> get_IDHangAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_DonGiaHang", ReplyAction="http://tempuri.org/IService_SanPham/get_DonGiaHangResponse")]
        int get_DonGiaHang(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_DonGiaHang", ReplyAction="http://tempuri.org/IService_SanPham/get_DonGiaHangResponse")]
        System.Threading.Tasks.Task<int> get_DonGiaHangAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_GiaNhap", ReplyAction="http://tempuri.org/IService_SanPham/get_GiaNhapResponse")]
        int get_GiaNhap(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_GiaNhap", ReplyAction="http://tempuri.org/IService_SanPham/get_GiaNhapResponse")]
        System.Threading.Tasks.Task<int> get_GiaNhapAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_Count", ReplyAction="http://tempuri.org/IService_SanPham/get_CountResponse")]
        int get_Count();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_Count", ReplyAction="http://tempuri.org/IService_SanPham/get_CountResponse")]
        System.Threading.Tasks.Task<int> get_CountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_tenSP", ReplyAction="http://tempuri.org/IService_SanPham/get_tenSPResponse")]
        System.Data.DataTable get_tenSP();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_tenSP", ReplyAction="http://tempuri.org/IService_SanPham/get_tenSPResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> get_tenSPAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_maLoai", ReplyAction="http://tempuri.org/IService_SanPham/get_maLoaiResponse")]
        string get_maLoai(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_SanPham/get_maLoai", ReplyAction="http://tempuri.org/IService_SanPham/get_maLoaiResponse")]
        System.Threading.Tasks.Task<string> get_maLoaiAsync(int idsp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_SanPhamChannel : KinhMat_Client.ServiceReference_sanPham.IService_SanPham, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_SanPhamClient : System.ServiceModel.ClientBase<KinhMat_Client.ServiceReference_sanPham.IService_SanPham>, KinhMat_Client.ServiceReference_sanPham.IService_SanPham {
        
        public Service_SanPhamClient() {
        }
        
        public Service_SanPhamClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_SanPhamClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SanPhamClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_SanPhamClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Insert_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong) {
            return base.Channel.Insert_NhapHang(tensp, maloai, gianhap, giaban, soluong);
        }
        
        public System.Threading.Tasks.Task<bool> Insert_NhapHangAsync(string tensp, string maloai, int gianhap, int giaban, int soluong) {
            return base.Channel.Insert_NhapHangAsync(tensp, maloai, gianhap, giaban, soluong);
        }
        
        public bool edit_NhapHang(string tensp, string maloai, int gianhap, int giaban, int soluong, string id) {
            return base.Channel.edit_NhapHang(tensp, maloai, gianhap, giaban, soluong, id);
        }
        
        public System.Threading.Tasks.Task<bool> edit_NhapHangAsync(string tensp, string maloai, int gianhap, int giaban, int soluong, string id) {
            return base.Channel.edit_NhapHangAsync(tensp, maloai, gianhap, giaban, soluong, id);
        }
        
        public bool del_NhapHang(int idsp) {
            return base.Channel.del_NhapHang(idsp);
        }
        
        public System.Threading.Tasks.Task<bool> del_NhapHangAsync(int idsp) {
            return base.Channel.del_NhapHangAsync(idsp);
        }
        
        public System.Data.DataTable DGV_NhapHang() {
            return base.Channel.DGV_NhapHang();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DGV_NhapHangAsync() {
            return base.Channel.DGV_NhapHangAsync();
        }
        
        public System.Data.DataTable Search_NhapHang(string keysp) {
            return base.Channel.Search_NhapHang(keysp);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Search_NhapHangAsync(string keysp) {
            return base.Channel.Search_NhapHangAsync(keysp);
        }
        
        public int get_SoLuongHang(int idsp) {
            return base.Channel.get_SoLuongHang(idsp);
        }
        
        public System.Threading.Tasks.Task<int> get_SoLuongHangAsync(int idsp) {
            return base.Channel.get_SoLuongHangAsync(idsp);
        }
        
        public bool update_SoLuongHang(int idsp, int soluong) {
            return base.Channel.update_SoLuongHang(idsp, soluong);
        }
        
        public System.Threading.Tasks.Task<bool> update_SoLuongHangAsync(int idsp, int soluong) {
            return base.Channel.update_SoLuongHangAsync(idsp, soluong);
        }
        
        public int get_IDHang(string tensp) {
            return base.Channel.get_IDHang(tensp);
        }
        
        public System.Threading.Tasks.Task<int> get_IDHangAsync(string tensp) {
            return base.Channel.get_IDHangAsync(tensp);
        }
        
        public int get_DonGiaHang(string tensp) {
            return base.Channel.get_DonGiaHang(tensp);
        }
        
        public System.Threading.Tasks.Task<int> get_DonGiaHangAsync(string tensp) {
            return base.Channel.get_DonGiaHangAsync(tensp);
        }
        
        public int get_GiaNhap(string tensp) {
            return base.Channel.get_GiaNhap(tensp);
        }
        
        public System.Threading.Tasks.Task<int> get_GiaNhapAsync(string tensp) {
            return base.Channel.get_GiaNhapAsync(tensp);
        }
        
        public int get_Count() {
            return base.Channel.get_Count();
        }
        
        public System.Threading.Tasks.Task<int> get_CountAsync() {
            return base.Channel.get_CountAsync();
        }
        
        public System.Data.DataTable get_tenSP() {
            return base.Channel.get_tenSP();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> get_tenSPAsync() {
            return base.Channel.get_tenSPAsync();
        }
        
        public string get_maLoai(int idsp) {
            return base.Channel.get_maLoai(idsp);
        }
        
        public System.Threading.Tasks.Task<string> get_maLoaiAsync(int idsp) {
            return base.Channel.get_maLoaiAsync(idsp);
        }
    }
}
