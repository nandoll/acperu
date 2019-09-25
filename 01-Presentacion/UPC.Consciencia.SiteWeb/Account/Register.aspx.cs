using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using App = UPC.Consciencia.Logica;
using ENT = UPC.Consciencia.Modelo;
using Framework.Infrastructure.Mail;

namespace UPC.Consciencia.SiteWeb.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Json clsJson = new Json();
                //clsJson.Method = "POST";
                //clsJson.ContentType = "application/json";
                //clsJson.Accept = "application/json; charset=UTF-8";

                //StringBuilder sbCuerpo = new StringBuilder(String.Empty);

                //String strComillas = "\"";

                //sbCuerpo.AppendLine("{");
                //sbCuerpo.AppendLine(strComillas + "codigoUsuario" + strComillas + ": 0,");
                //sbCuerpo.AppendLine(strComillas + "codigoUsuarioExterno" + strComillas + ": 1,");
                //sbCuerpo.AppendLine(strComillas + "nombre" + strComillas + ": " + strComillas + "Juan2" + strComillas + ", ");
                //sbCuerpo.AppendLine(strComillas + "apellidos" + strComillas + ": " + strComillas + "Perez" + strComillas + ", ");
                //sbCuerpo.AppendLine(strComillas + "correo" + strComillas + ": " + strComillas + "jperez@gmail.com" + strComillas + ", ");
                //sbCuerpo.AppendLine(strComillas + "objetivoCumplido" + strComillas + ": 0");
                //sbCuerpo.AppendLine("}");


                //clsJson.Post("http://localhost:8888/api/usuario", sbCuerpo);
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            CrearCuenta();
        }

        private void CrearCuenta()
        {
            ENT.CatalogoUsuario entUsuario = new ENT.CatalogoUsuario();
            entUsuario.Nombres = txtNombre.Text.Trim();
            entUsuario.Apellidos = txtApellido.Text.Trim();
            entUsuario.Correo = txtEmail.Text.Trim();
            entUsuario.Clave = "AApwD5yiHpd0diAodlAEDOCqjNbKqoViIxeR2gYrriDGYUbzewWXa+J5lueYiOPHzQ==";
            entUsuario.IdBeneficio = Convert.ToInt32(ddlBeneficio.SelectedValue);
            entUsuario.Perfil = 1;
            entUsuario.UsuarioRegistro = "ADMIN";
            entUsuario.FechaRegistro = DateTime.Now;
            entUsuario.UsuarioCambio = "ADMIN";
            entUsuario.FechaCambio = DateTime.Now;

            Int32 intIdUsuario = 0;

            using (App.AppCatalogoUsuario appUsuario = new App.AppCatalogoUsuario())
            {
                intIdUsuario = appUsuario.GrabarCatalogoUsuario(entUsuario);
            }

            if (intIdUsuario > 0)
            {
                EnviarCorreoBienvenida(entUsuario.Nombres, entUsuario.Correo);

                Json clsJson = new Json();
                clsJson.Method = "POST";
                clsJson.ContentType = "application/json";
                clsJson.Accept = "application/json; charset=UTF-8";

                StringBuilder sbCuerpo = new StringBuilder(String.Empty);

                String strComillas = "\"";

                sbCuerpo.AppendLine("{");
                sbCuerpo.AppendLine(strComillas + "codigoUsuario" + strComillas + ": 0,");
                sbCuerpo.AppendLine(strComillas + "codigoUsuarioExterno" + strComillas + ": " + intIdUsuario.ToString() + ",");
                sbCuerpo.AppendLine(strComillas + "nombre" + strComillas + ": " + strComillas + entUsuario.Nombres + strComillas + ", ");
                sbCuerpo.AppendLine(strComillas + "apellidos" + strComillas + ": " + strComillas + entUsuario.Apellidos + strComillas + ", ");
                sbCuerpo.AppendLine(strComillas + "correo" + strComillas + ": " + strComillas + entUsuario.Correo + strComillas + ", ");
                sbCuerpo.AppendLine(strComillas + "objetivoCumplido" + strComillas + ": 0");
                sbCuerpo.AppendLine("}");


                clsJson.Post("http://localhost:8888/api/usuario", sbCuerpo);

                Response.Redirect("~/Account/Login.aspx");
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

    }
}