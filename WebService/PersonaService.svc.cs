using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using WebService.Datos;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PersonaService : IPersonaService
    {
        public string ObetenerNombre(int id) {


            return "namers de la vida yeso";
        }

        public Persona ObtenerPersona(string Pnombre)
        {

            return new Persona() { Nombre = Pnombre, Id = 2, EdoCivil = false };

        }

        public Persona ObtenerPersonaPorId(int Pid) {

            return new Persona(){Nombre = "erick",Id = Pid,EdoCivil = false};

        }

        //insertamos a la persona
        public string InsertPersona(string id, string name, string edocivil) {

            Conexion conexion = new Conexion();

            Persona nuevo = new Persona() { Id = int.Parse(id),Nombre = name,EdoCivil = false};

            try {

                conexion.insertar(nuevo);

                return "todo OKAS";

            } catch {

                return "ha ocurrido algun error";
            }
            
        }

        //comvertimos un tipo para wcf a xml para poderla imrpimir
        private List<PersonaXML> PersonaAXML(List<Persona> person) {

            List<PersonaXML> entrega = new List<PersonaXML>();

            foreach (Persona ps in person) {
                PersonaXML p = new PersonaXML() { Pid = ps.Id, Pnombre = ps.Nombre, PedoCivil = ps.EdoCivil};

                entrega.Add(p);
            }

            return entrega;
        }

        public List<PersonaXML> ImprimePersonas() {

            Conexion conexion = new Conexion();

            List<PersonaXML> per = PersonaAXML(conexion.resultado_select());

            //serializamos el documento
           // XmlSerializer serializador = new XmlSerializer(per.GetType());

            //codigo para serializar dentro de los archivos locales
            //FileStream archivo = new FileStream("Personas.xml",FileMode.Create,FileAccess.Write);

            //serializador.Serialize(archivo,per);

            //archivo.Close();

            try
            {
                return per;

            }
            catch (Exception e)
            {

                return null;

            }

            

           // var des = new Persona() { Nombre = "úes ya workea rrope", Id = 3, EdoCivil = false };

//            return des.Nombre;

        }


        public string ObtenerPersonaAlone()
        {

            Conexion conexion = new Conexion();

            try
            {
                //aqui podemos imprimir la info de las personas
                return conexion.soloUnaPersona();

            }
            catch (Exception e)
            {

                return "conexion fallida";

            }



            // var des = new Persona() { Nombre = "úes ya workea rrope", Id = 3, EdoCivil = false };

            //            return des.Nombre;

        }

    }
}
