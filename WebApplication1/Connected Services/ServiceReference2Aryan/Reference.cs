﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference2Aryan {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2Aryan.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NaturalHazards", ReplyAction="http://tempuri.org/IService1/NaturalHazardsResponse")]
        decimal NaturalHazards(int minLatitude, int minLongitude, int maxLatitude, int maxLongitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NaturalHazards", ReplyAction="http://tempuri.org/IService1/NaturalHazardsResponse")]
        System.Threading.Tasks.Task<decimal> NaturalHazardsAsync(int minLatitude, int minLongitude, int maxLatitude, int maxLongitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWindintensity", ReplyAction="http://tempuri.org/IService1/GetWindintensityResponse")]
        double GetWindintensity(int lattitude, int longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWindintensity", ReplyAction="http://tempuri.org/IService1/GetWindintensityResponse")]
        System.Threading.Tasks.Task<double> GetWindintensityAsync(int lattitude, int longitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference2Aryan.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference2Aryan.IService1>, WebApplication1.ServiceReference2Aryan.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal NaturalHazards(int minLatitude, int minLongitude, int maxLatitude, int maxLongitude) {
            return base.Channel.NaturalHazards(minLatitude, minLongitude, maxLatitude, maxLongitude);
        }
        
        public System.Threading.Tasks.Task<decimal> NaturalHazardsAsync(int minLatitude, int minLongitude, int maxLatitude, int maxLongitude) {
            return base.Channel.NaturalHazardsAsync(minLatitude, minLongitude, maxLatitude, maxLongitude);
        }
        
        public double GetWindintensity(int lattitude, int longitude) {
            return base.Channel.GetWindintensity(lattitude, longitude);
        }
        
        public System.Threading.Tasks.Task<double> GetWindintensityAsync(int lattitude, int longitude) {
            return base.Channel.GetWindintensityAsync(lattitude, longitude);
        }
    }
}
