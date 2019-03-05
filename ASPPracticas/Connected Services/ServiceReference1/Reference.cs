﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPPracticas.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EdoCivilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EdoCivil {
            get {
                return this.EdoCivilField;
            }
            set {
                if ((this.EdoCivilField.Equals(value) != true)) {
                    this.EdoCivilField = value;
                    this.RaisePropertyChanged("EdoCivil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPersonaService")]
    public interface IPersonaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObetenerNombre", ReplyAction="http://tempuri.org/IPersonaService/ObetenerNombreResponse")]
        string ObetenerNombre(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObetenerNombre", ReplyAction="http://tempuri.org/IPersonaService/ObetenerNombreResponse")]
        System.Threading.Tasks.Task<string> ObetenerNombreAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersona", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaResponse")]
        ASPPracticas.ServiceReference1.Persona ObtenerPersona(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersona", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaResponse")]
        System.Threading.Tasks.Task<ASPPracticas.ServiceReference1.Persona> ObtenerPersonaAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersonaPorId", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaPorIdResponse")]
        ASPPracticas.ServiceReference1.Persona ObtenerPersonaPorId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersonaPorId", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaPorIdResponse")]
        System.Threading.Tasks.Task<ASPPracticas.ServiceReference1.Persona> ObtenerPersonaPorIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonaServiceChannel : ASPPracticas.ServiceReference1.IPersonaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonaServiceClient : System.ServiceModel.ClientBase<ASPPracticas.ServiceReference1.IPersonaService>, ASPPracticas.ServiceReference1.IPersonaService {
        
        public PersonaServiceClient() {
        }
        
        public PersonaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObetenerNombre(int id) {
            return base.Channel.ObetenerNombre(id);
        }
        
        public System.Threading.Tasks.Task<string> ObetenerNombreAsync(int id) {
            return base.Channel.ObetenerNombreAsync(id);
        }
        
        public ASPPracticas.ServiceReference1.Persona ObtenerPersona(string nombre) {
            return base.Channel.ObtenerPersona(nombre);
        }
        
        public System.Threading.Tasks.Task<ASPPracticas.ServiceReference1.Persona> ObtenerPersonaAsync(string nombre) {
            return base.Channel.ObtenerPersonaAsync(nombre);
        }
        
        public ASPPracticas.ServiceReference1.Persona ObtenerPersonaPorId(int id) {
            return base.Channel.ObtenerPersonaPorId(id);
        }
        
        public System.Threading.Tasks.Task<ASPPracticas.ServiceReference1.Persona> ObtenerPersonaPorIdAsync(int id) {
            return base.Channel.ObtenerPersonaPorIdAsync(id);
        }
    }
}
