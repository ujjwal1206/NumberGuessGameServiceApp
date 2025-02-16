﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumberGuessGameServiceApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.INumberGameGuessService")]
    public interface INumberGameGuessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberGameGuessService/SecretNumber", ReplyAction="http://tempuri.org/INumberGameGuessService/SecretNumberResponse")]
        int SecretNumber(int lower, int upper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberGameGuessService/SecretNumber", ReplyAction="http://tempuri.org/INumberGameGuessService/SecretNumberResponse")]
        System.Threading.Tasks.Task<int> SecretNumberAsync(int lower, int upper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberGameGuessService/CheckNumber", ReplyAction="http://tempuri.org/INumberGameGuessService/CheckNumberResponse")]
        string CheckNumber(int userNum, int secretNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberGameGuessService/CheckNumber", ReplyAction="http://tempuri.org/INumberGameGuessService/CheckNumberResponse")]
        System.Threading.Tasks.Task<string> CheckNumberAsync(int userNum, int secretNum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INumberGameGuessServiceChannel : NumberGuessGameServiceApp.ServiceReference1.INumberGameGuessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NumberGameGuessServiceClient : System.ServiceModel.ClientBase<NumberGuessGameServiceApp.ServiceReference1.INumberGameGuessService>, NumberGuessGameServiceApp.ServiceReference1.INumberGameGuessService {
        
        public NumberGameGuessServiceClient() {
        }
        
        public NumberGameGuessServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NumberGameGuessServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberGameGuessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberGameGuessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SecretNumber(int lower, int upper) {
            return base.Channel.SecretNumber(lower, upper);
        }
        
        public System.Threading.Tasks.Task<int> SecretNumberAsync(int lower, int upper) {
            return base.Channel.SecretNumberAsync(lower, upper);
        }
        
        public string CheckNumber(int userNum, int secretNum) {
            return base.Channel.CheckNumber(userNum, secretNum);
        }
        
        public System.Threading.Tasks.Task<string> CheckNumberAsync(int userNum, int secretNum) {
            return base.Channel.CheckNumberAsync(userNum, secretNum);
        }
    }
}
