﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.SaleServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SaleServiceReference.ISaleService")]
    public interface ISaleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/registerSale", ReplyAction="http://tempuri.org/ISaleService/registerSaleResponse")]
        int registerSale(int idClient, string phones, int total);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/registerSale", ReplyAction="http://tempuri.org/ISaleService/registerSaleResponse")]
        System.Threading.Tasks.Task<int> registerSaleAsync(int idClient, string phones, int total);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISaleServiceChannel : Test.SaleServiceReference.ISaleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SaleServiceClient : System.ServiceModel.ClientBase<Test.SaleServiceReference.ISaleService>, Test.SaleServiceReference.ISaleService {
        
        public SaleServiceClient() {
        }
        
        public SaleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SaleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int registerSale(int idClient, string phones, int total) {
            return base.Channel.registerSale(idClient, phones, total);
        }
        
        public System.Threading.Tasks.Task<int> registerSaleAsync(int idClient, string phones, int total) {
            return base.Channel.registerSaleAsync(idClient, phones, total);
        }
    }
}
