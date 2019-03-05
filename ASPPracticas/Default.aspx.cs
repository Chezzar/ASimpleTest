using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace ASPPracticas
{
    public partial class _Default : Page
    {

        private int conteo = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {
                txtConteo.Text = "0";

                //creamos un dataset para guardar los datos de el xml
                DataSet data = new DataSet();


                //aqui estamos buscanco con Server:mapPath la ruta de el archivo xml y lo leemos para agregarlo
                data.ReadXml(Server.MapPath("Frutas.xml"));

                //accedemos a datasource de ddlfrutas que es un dopdown list y asigbamos el data obtenido de el xml 
                ddlfrutas.DataSource = data;

                //colocamos los valores de ddlfrutas con los campos creados en el Frutas.xml
                ddlfrutas.DataValueField = "frutaID";
                ddlfrutas.DataTextField = "frutaNombre";

                //esta funcion enlaza los datos de todo el archivo
                ddlfrutas.DataBind();

                //creamos un objecto que sera agregado a la lista de items
                ListItem Costales = new ListItem("Costales");

                //acceddmos a la lista de el objecto dropdownlist y usamos la funcion add() para meter un item a la lista
                ddlfrutas.Items.Add(Costales);

                /*using (PersonaServicio.PersonaServiceClient Client = new PersonaServicio.PersonaServiceClient()) {

                    var persona = Client.ObtenerPersonaPorId(12).Nombre;
                        //Client.ObtenerPersona("esta es la persona").Nombre;
                    //Client.ObetenerNombre(1);

                    txtConteo.Text = persona.ToString();
                }*/
            }

            //txtConteo.Text = "desire";

            Response.Write("Cantidad de aplicaciones instanciadas  " + Application["Aplicaciones"] + "<br/>");

            Response.Write("Cantidad de sesiones de usuario  " + Application["SesionesDeUsuario"] + "<br/>");

        }

        protected void btnIncremementa_Click(object sender, EventArgs e)
        {
            //si ya se ha usado el viewtate con la variable VecesDeClik
            if (ViewState["VecesDeClick"] != null) {

                //leemos el valor hacemos un cast incrementamos en 1 y asignamos a la varable conteo
                conteo = (int)ViewState["VecesDeClick"] + 1;
            }

            //asignamos el valor correspondiente
            txtConteo.Text = conteo.ToString();

            //una vez usada la guardamos de nuevo para poderla seguir usando despues
            ViewState["VecesDeClick"] = conteo;

        }

        protected void txtConteo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void TestCommand(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "desire")
                Response.Write("desire");
            else
                Response.Write("fortogen");
        }

        protected void btnPruebas_Click(object sender, EventArgs e)
        {
            Response.Write(ddlfrutas.SelectedValue);
        }
    }
}