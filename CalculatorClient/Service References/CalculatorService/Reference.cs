﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorClient.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="CalculatorService.ICalculatorSession", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICalculatorSession {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Clear")]
        void Clear();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/AddTo")]
        void AddTo(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/SubtractFrom")]
        void SubtractFrom(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/MultiplyBy")]
        void MultiplyBy(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/DivideBy")]
        void DivideBy(double n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Equals", ReplyAction="http://Microsoft.ServiceModel.Samples/ICalculatorSession/EqualsResponse")]
        double Equals();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorSessionChannel : CalculatorClient.CalculatorService.ICalculatorSession, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSessionClient : System.ServiceModel.ClientBase<CalculatorClient.CalculatorService.ICalculatorSession>, CalculatorClient.CalculatorService.ICalculatorSession {
        
        public CalculatorSessionClient() {
        }
        
        public CalculatorSessionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSessionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSessionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSessionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Clear() {
            base.Channel.Clear();
        }
        
        public void AddTo(double n) {
            base.Channel.AddTo(n);
        }
        
        public void SubtractFrom(double n) {
            base.Channel.SubtractFrom(n);
        }
        
        public void MultiplyBy(double n) {
            base.Channel.MultiplyBy(n);
        }
        
        public void DivideBy(double n) {
            base.Channel.DivideBy(n);
        }
        
        public double Equals() {
            return base.Channel.Equals();
        }
    }
}
