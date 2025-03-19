﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1Smit {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1Smit.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather5day", ReplyAction="http://tempuri.org/IService1/Weather5dayResponse")]
        string[] Weather5day(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather5day", ReplyAction="http://tempuri.org/IService1/Weather5dayResponse")]
        System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SolarIntensity", ReplyAction="http://tempuri.org/IService1/SolarIntensityResponse")]
        decimal SolarIntensity(decimal latitude, decimal longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SolarIntensity", ReplyAction="http://tempuri.org/IService1/SolarIntensityResponse")]
        System.Threading.Tasks.Task<decimal> SolarIntensityAsync(decimal latitude, decimal longitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference1Smit.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1Smit.IService1>, WebApplication1.ServiceReference1Smit.IService1 {
        
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
        
        public string[] Weather5day(string zipcode) {
            return base.Channel.Weather5day(zipcode);
        }
        
        public System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode) {
            return base.Channel.Weather5dayAsync(zipcode);
        }
        
        public decimal SolarIntensity(decimal latitude, decimal longitude) {
            return base.Channel.SolarIntensity(latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<decimal> SolarIntensityAsync(decimal latitude, decimal longitude) {
            return base.Channel.SolarIntensityAsync(latitude, longitude);
        }
    }
}
