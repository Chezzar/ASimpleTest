using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Serialization;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPersonaService
    {

        [OperationContract]
        string ObetenerNombre(int id);

        [OperationContract]
        Persona ObtenerPersona(String nombre);

        [OperationContract]
        Persona ObtenerPersonaPorId(int id);

        [OperationContract]
        [WebGet(UriTemplate = "/test",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        List<PersonaXML>ImprimePersonas();

        [OperationContract]
        [WebInvoke(UriTemplate = "/personainsertar/{id}/{name}/{edocivil}" ,Method = "GET")]
        string InsertPersona(string id,string name,string edocivil);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/persona",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        string ObtenerPersonaAlone();

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Persona
    {
        
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public bool EdoCivil { get; set; }

    }

    [Serializable]
    public class PersonaXML
    {
        [NonSerialized]
        public int Pid;// { get { return Pid; }  set { Pid = value; } }

        public string Pnombre;// { get { return Pnombre; } set { Pnombre = value; } }

        public bool PedoCivil;// { get { return PedoCivil; } set { PedoCivil = value; } }
    }
}
