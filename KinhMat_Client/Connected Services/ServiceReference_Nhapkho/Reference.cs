﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinhMat_Client.ServiceReference_Nhapkho {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_Nhapkho.IService_NhapKho")]
    public interface IService_NhapKho {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/Insert_NhapKho", ReplyAction="http://tempuri.org/IService_NhapKho/Insert_NhapKhoResponse")]
        bool Insert_NhapKho(int idsp, int soluong, System.DateTime ngay, int tongtien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/Insert_NhapKho", ReplyAction="http://tempuri.org/IService_NhapKho/Insert_NhapKhoResponse")]
        System.Threading.Tasks.Task<bool> Insert_NhapKhoAsync(int idsp, int soluong, System.DateTime ngay, int tongtien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/del_nhapkho", ReplyAction="http://tempuri.org/IService_NhapKho/del_nhapkhoResponse")]
        bool del_nhapkho(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/del_nhapkho", ReplyAction="http://tempuri.org/IService_NhapKho/del_nhapkhoResponse")]
        System.Threading.Tasks.Task<bool> del_nhapkhoAsync(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/check_ID", ReplyAction="http://tempuri.org/IService_NhapKho/check_IDResponse")]
        bool check_ID(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/check_ID", ReplyAction="http://tempuri.org/IService_NhapKho/check_IDResponse")]
        System.Threading.Tasks.Task<bool> check_IDAsync(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/get_soluongKho", ReplyAction="http://tempuri.org/IService_NhapKho/get_soluongKhoResponse")]
        int get_soluongKho(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/get_soluongKho", ReplyAction="http://tempuri.org/IService_NhapKho/get_soluongKhoResponse")]
        System.Threading.Tasks.Task<int> get_soluongKhoAsync(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/DGV_Kho", ReplyAction="http://tempuri.org/IService_NhapKho/DGV_KhoResponse")]
        System.Data.DataTable DGV_Kho();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/DGV_Kho", ReplyAction="http://tempuri.org/IService_NhapKho/DGV_KhoResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> DGV_KhoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/update_SL", ReplyAction="http://tempuri.org/IService_NhapKho/update_SLResponse")]
        bool update_SL(int idsp, int sl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/update_SL", ReplyAction="http://tempuri.org/IService_NhapKho/update_SLResponse")]
        System.Threading.Tasks.Task<bool> update_SLAsync(int idsp, int sl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/get_TongTien", ReplyAction="http://tempuri.org/IService_NhapKho/get_TongTienResponse")]
        int get_TongTien(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/get_TongTien", ReplyAction="http://tempuri.org/IService_NhapKho/get_TongTienResponse")]
        System.Threading.Tasks.Task<int> get_TongTienAsync(int idsp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/update_TongTien", ReplyAction="http://tempuri.org/IService_NhapKho/update_TongTienResponse")]
        bool update_TongTien(int idsp, int tongtien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/update_TongTien", ReplyAction="http://tempuri.org/IService_NhapKho/update_TongTienResponse")]
        System.Threading.Tasks.Task<bool> update_TongTienAsync(int idsp, int tongtien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/search_Name", ReplyAction="http://tempuri.org/IService_NhapKho/search_NameResponse")]
        System.Data.DataTable search_Name(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/search_Name", ReplyAction="http://tempuri.org/IService_NhapKho/search_NameResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> search_NameAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/search_Loai", ReplyAction="http://tempuri.org/IService_NhapKho/search_LoaiResponse")]
        System.Data.DataTable search_Loai(string loaisp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/search_Loai", ReplyAction="http://tempuri.org/IService_NhapKho/search_LoaiResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> search_LoaiAsync(string loaisp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/search_Date", ReplyAction="http://tempuri.org/IService_NhapKho/search_DateResponse")]
        System.Data.DataTable search_Date(System.DateTime fromdate, System.DateTime enddate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_NhapKho/search_Date", ReplyAction="http://tempuri.org/IService_NhapKho/search_DateResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> search_DateAsync(System.DateTime fromdate, System.DateTime enddate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_NhapKhoChannel : KinhMat_Client.ServiceReference_Nhapkho.IService_NhapKho, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_NhapKhoClient : System.ServiceModel.ClientBase<KinhMat_Client.ServiceReference_Nhapkho.IService_NhapKho>, KinhMat_Client.ServiceReference_Nhapkho.IService_NhapKho {
        
        public Service_NhapKhoClient() {
        }
        
        public Service_NhapKhoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_NhapKhoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_NhapKhoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_NhapKhoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Insert_NhapKho(int idsp, int soluong, System.DateTime ngay, int tongtien) {
            return base.Channel.Insert_NhapKho(idsp, soluong, ngay, tongtien);
        }
        
        public System.Threading.Tasks.Task<bool> Insert_NhapKhoAsync(int idsp, int soluong, System.DateTime ngay, int tongtien) {
            return base.Channel.Insert_NhapKhoAsync(idsp, soluong, ngay, tongtien);
        }
        
        public bool del_nhapkho(int idsp) {
            return base.Channel.del_nhapkho(idsp);
        }
        
        public System.Threading.Tasks.Task<bool> del_nhapkhoAsync(int idsp) {
            return base.Channel.del_nhapkhoAsync(idsp);
        }
        
        public bool check_ID(int idsp) {
            return base.Channel.check_ID(idsp);
        }
        
        public System.Threading.Tasks.Task<bool> check_IDAsync(int idsp) {
            return base.Channel.check_IDAsync(idsp);
        }
        
        public int get_soluongKho(int idsp) {
            return base.Channel.get_soluongKho(idsp);
        }
        
        public System.Threading.Tasks.Task<int> get_soluongKhoAsync(int idsp) {
            return base.Channel.get_soluongKhoAsync(idsp);
        }
        
        public System.Data.DataTable DGV_Kho() {
            return base.Channel.DGV_Kho();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DGV_KhoAsync() {
            return base.Channel.DGV_KhoAsync();
        }
        
        public bool update_SL(int idsp, int sl) {
            return base.Channel.update_SL(idsp, sl);
        }
        
        public System.Threading.Tasks.Task<bool> update_SLAsync(int idsp, int sl) {
            return base.Channel.update_SLAsync(idsp, sl);
        }
        
        public int get_TongTien(int idsp) {
            return base.Channel.get_TongTien(idsp);
        }
        
        public System.Threading.Tasks.Task<int> get_TongTienAsync(int idsp) {
            return base.Channel.get_TongTienAsync(idsp);
        }
        
        public bool update_TongTien(int idsp, int tongtien) {
            return base.Channel.update_TongTien(idsp, tongtien);
        }
        
        public System.Threading.Tasks.Task<bool> update_TongTienAsync(int idsp, int tongtien) {
            return base.Channel.update_TongTienAsync(idsp, tongtien);
        }
        
        public System.Data.DataTable search_Name(string tensp) {
            return base.Channel.search_Name(tensp);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> search_NameAsync(string tensp) {
            return base.Channel.search_NameAsync(tensp);
        }
        
        public System.Data.DataTable search_Loai(string loaisp) {
            return base.Channel.search_Loai(loaisp);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> search_LoaiAsync(string loaisp) {
            return base.Channel.search_LoaiAsync(loaisp);
        }
        
        public System.Data.DataTable search_Date(System.DateTime fromdate, System.DateTime enddate) {
            return base.Channel.search_Date(fromdate, enddate);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> search_DateAsync(System.DateTime fromdate, System.DateTime enddate) {
            return base.Channel.search_DateAsync(fromdate, enddate);
        }
    }
}
