﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinhMat_Client.ServiceReference_hoaDon {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_hoaDon.IService_HoaDon")]
    public interface IService_HoaDon {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/DGV_HoaDon", ReplyAction="http://tempuri.org/IService_HoaDon/DGV_HoaDonResponse")]
        System.Data.DataTable DGV_HoaDon();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/DGV_HoaDon", ReplyAction="http://tempuri.org/IService_HoaDon/DGV_HoaDonResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> DGV_HoaDonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/insert_hoaDon", ReplyAction="http://tempuri.org/IService_HoaDon/insert_hoaDonResponse")]
        bool insert_hoaDon(int idkh, System.DateTime ngay, int tongtien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/insert_hoaDon", ReplyAction="http://tempuri.org/IService_HoaDon/insert_hoaDonResponse")]
        System.Threading.Tasks.Task<bool> insert_hoaDonAsync(int idkh, System.DateTime ngay, int tongtien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/del_hoaDon", ReplyAction="http://tempuri.org/IService_HoaDon/del_hoaDonResponse")]
        bool del_hoaDon(int idhd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/del_hoaDon", ReplyAction="http://tempuri.org/IService_HoaDon/del_hoaDonResponse")]
        System.Threading.Tasks.Task<bool> del_hoaDonAsync(int idhd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/get_idHD", ReplyAction="http://tempuri.org/IService_HoaDon/get_idHDResponse")]
        int get_idHD(int idkh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDon/get_idHD", ReplyAction="http://tempuri.org/IService_HoaDon/get_idHDResponse")]
        System.Threading.Tasks.Task<int> get_idHDAsync(int idkh);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_HoaDonChannel : KinhMat_Client.ServiceReference_hoaDon.IService_HoaDon, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_HoaDonClient : System.ServiceModel.ClientBase<KinhMat_Client.ServiceReference_hoaDon.IService_HoaDon>, KinhMat_Client.ServiceReference_hoaDon.IService_HoaDon {
        
        public Service_HoaDonClient() {
        }
        
        public Service_HoaDonClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_HoaDonClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_HoaDonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_HoaDonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable DGV_HoaDon() {
            return base.Channel.DGV_HoaDon();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DGV_HoaDonAsync() {
            return base.Channel.DGV_HoaDonAsync();
        }
        
        public bool insert_hoaDon(int idkh, System.DateTime ngay, int tongtien) {
            return base.Channel.insert_hoaDon(idkh, ngay, tongtien);
        }
        
        public System.Threading.Tasks.Task<bool> insert_hoaDonAsync(int idkh, System.DateTime ngay, int tongtien) {
            return base.Channel.insert_hoaDonAsync(idkh, ngay, tongtien);
        }
        
        public bool del_hoaDon(int idhd) {
            return base.Channel.del_hoaDon(idhd);
        }
        
        public System.Threading.Tasks.Task<bool> del_hoaDonAsync(int idhd) {
            return base.Channel.del_hoaDonAsync(idhd);
        }
        
        public int get_idHD(int idkh) {
            return base.Channel.get_idHD(idkh);
        }
        
        public System.Threading.Tasks.Task<int> get_idHDAsync(int idkh) {
            return base.Channel.get_idHDAsync(idkh);
        }
    }
}