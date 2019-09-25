using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UPC.Consciencia.SiteWeb.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
        }

        private void ValidarIngreso()
        {

            Session["IdUsuario"] = 1;
            Session["Nombre"] = "Carhuancho";
            Session["Correo"] = "acperu.noreply@gmail.com";

            Response.Redirect("~/Default.aspx");

        }
    }
}