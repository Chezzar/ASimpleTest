using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPracticas
{
    public partial class Receiver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String text1 = Request.Form.Get("text");
            String text2 = Request.Form["text2"];

            Response.Write(text1);

            Label1.Text = text1;
            Label2.Text = text2;
        }
    }
}