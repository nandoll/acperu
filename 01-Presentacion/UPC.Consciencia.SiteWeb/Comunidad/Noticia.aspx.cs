using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using App = UPC.Consciencia.Logica;
using ENT = UPC.Consciencia.Modelo;
using System.Text;

namespace UPC.Consciencia.SiteWeb.Comunidad
{

    public partial class Noticia : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {

            List<ENT.CatalogoNoticia> lstNoticia = new List<ENT.CatalogoNoticia>();
            ENT.CatalogoNoticia entFiltro = new ENT.CatalogoNoticia();

            entFiltro.IdNoticia = 0;
            entFiltro.FechaHora = null;
            entFiltro.FechaRegistro = null;
            entFiltro.SituacionRegistro = "A";
            entFiltro.FechaCambio = null;

            using (App.AppCatalogoNoticia clsNoticia = new App.AppCatalogoNoticia())
            {
                lstNoticia = clsNoticia.ListarCatalogoNoticia(entFiltro);
            }

            StringBuilder sbNoticia = new StringBuilder(String.Empty);

            foreach (ENT.CatalogoNoticia entNoticia in lstNoticia)
            {

                sbNoticia.AppendLine("<div class='card shadow mb-4 border-left-info'>");
                sbNoticia.AppendLine("    <a href='#IdCorrelativo' class='d-block card-header py-3' data-toggle='collapse' role='button' aria-expanded='true' aria-controls='collapseCardExample'>");
                sbNoticia.AppendFormat("        <h6 class='m-0 font-weight-bold text-primary'>{0}</h6>", entNoticia.Titulo);
                sbNoticia.AppendLine("    </a>");
                sbNoticia.AppendLine("    <div class='collapse show' id='IdCorrelativo' style=''>");
                sbNoticia.AppendLine("        <div class='card-body'>");
                sbNoticia.AppendFormat("            {0}", entNoticia.Contenido);
                sbNoticia.AppendLine("        </div>");
                sbNoticia.AppendLine("    </div>");
                sbNoticia.AppendLine("</div>");
            }

            DivNoticias.InnerHtml = sbNoticia.ToString();

        }

    }

}