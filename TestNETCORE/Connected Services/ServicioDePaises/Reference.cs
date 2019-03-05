//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServicioDePaises
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    public partial class Persona : object
    {
        
        private bool EdoCivilField;
        
        private int IdField;
        
        private string NombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EdoCivil
        {
            get
            {
                return this.EdoCivilField;
            }
            set
            {
                this.EdoCivilField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonaXML", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    public partial class PersonaXML : object
    {
        
        private bool PedoCivilField;
        
        private string PnombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool PedoCivil
        {
            get
            {
                return this.PedoCivilField;
            }
            set
            {
                this.PedoCivilField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Pnombre
        {
            get
            {
                return this.PnombreField;
            }
            set
            {
                this.PnombreField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDePaises.IPersonaService")]
    public interface IPersonaService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObetenerNombre", ReplyAction="http://tempuri.org/IPersonaService/ObetenerNombreResponse")]
        System.Threading.Tasks.Task<string> ObetenerNombreAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersona", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaResponse")]
        System.Threading.Tasks.Task<ServicioDePaises.Persona> ObtenerPersonaAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersonaPorId", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaPorIdResponse")]
        System.Threading.Tasks.Task<ServicioDePaises.Persona> ObtenerPersonaPorIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ImprimePersonas", ReplyAction="http://tempuri.org/IPersonaService/ImprimePersonasResponse")]
        System.Threading.Tasks.Task<ServicioDePaises.PersonaXML[]> ImprimePersonasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/InsertPersona", ReplyAction="http://tempuri.org/IPersonaService/InsertPersonaResponse")]
        System.Threading.Tasks.Task<string> InsertPersonaAsync(string id, string name, string edocivil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonaService/ObtenerPersonaAlone", ReplyAction="http://tempuri.org/IPersonaService/ObtenerPersonaAloneResponse")]
        System.Threading.Tasks.Task<string> ObtenerPersonaAloneAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IPersonaServiceChannel : ServicioDePaises.IPersonaService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PersonaServiceClient : System.ServiceModel.ClientBase<ServicioDePaises.IPersonaService>, ServicioDePaises.IPersonaService
    {
        
        public PersonaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> ObetenerNombreAsync(int id)
        {
            return base.Channel.ObetenerNombreAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServicioDePaises.Persona> ObtenerPersonaAsync(string nombre)
        {
            return base.Channel.ObtenerPersonaAsync(nombre);
        }
        
        public System.Threading.Tasks.Task<ServicioDePaises.Persona> ObtenerPersonaPorIdAsync(int id)
        {
            return base.Channel.ObtenerPersonaPorIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServicioDePaises.PersonaXML[]> ImprimePersonasAsync()
        {
            return base.Channel.ImprimePersonasAsync();
        }
        
        public System.Threading.Tasks.Task<string> InsertPersonaAsync(string id, string name, string edocivil)
        {
            return base.Channel.InsertPersonaAsync(id, name, edocivil);
        }
        
        public System.Threading.Tasks.Task<string> ObtenerPersonaAloneAsync()
        {
            return base.Channel.ObtenerPersonaAloneAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
