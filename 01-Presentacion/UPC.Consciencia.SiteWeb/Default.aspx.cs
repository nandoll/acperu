using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Framework.Infrastructure.Mail;

namespace UPC.Consciencia.SiteWeb
{

    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //EnviarCorreoBienvenida("Jorge", "acperu.noreply@gmail.com");
                if (Session["Nombre"] != null) {
                    EnviarCorreoCumplimiento(Session["Nombre"].ToString(), Session["Correo"].ToString());
                }
                
            }
        }

        private void EnviarCorreoBienvenida(String strNombre, String strCorreo)
        {
            Message clsCorreo = new Message();
            clsCorreo.Para = strCorreo;
            clsCorreo.Asunto = strNombre + ", te damos la bienvenida a tu nueva cuenta de ACPERÚ.";
            clsCorreo.CuerpoMensaje = new System.Text.StringBuilder(DivBienvenida.InnerHtml);
            clsCorreo.Send();
        }

        private void EnviarCorreoCumplimiento(String strNombre, String strCorreo)
        {
            Message clsCorreo = new Message();
            clsCorreo.Para = strCorreo;
            clsCorreo.Asunto = strNombre + ", gracias por apoyarnos en esta batalla junto a ACPERÚ.";
            clsCorreo.CuerpoMensaje = new System.Text.StringBuilder(DivCumplimiento.InnerHtml);
            clsCorreo.Send();
        }

    }

}