using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ASPPracticas
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //se crea una variable de estado de la aplicacion que puede ser leida por todas las sesiones
            Application["Aplicaciones"] = 0;//esto nos dice cuantas aplicaciones se han isntanciado
            Application["SesionesDeUsuario"] = 0;//esto nos dice el numero de sesiones usuario usadas por la aplicacion

            //incremanetamos mas uno de esta instancia que se esta ejecutando
            Application["Aplicaciones"] = (int)Application["Aplicaciones"] + 1;

        }


        //incrementamos el numero de sesiones cuando es creada una sesion
        void Session_Start(object sender, EventArgs e)
        {
            Application["SesionesDeUsuario"] = (int)Application["SesionesDeUsuario"] + 1;
        }

        //decrementamos el numero de sesiones cuando se finaliza una sesion
        void Session_End(object sender, EventArgs e)
        {
            Application["SesionesDeUsuario"] = (int)Application["SesionesDeUsuario"] - 1;

        }
    }
}