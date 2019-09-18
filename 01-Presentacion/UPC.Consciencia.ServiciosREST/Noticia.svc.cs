using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Xml.Serialization;

using ENT = UPC.Consciencia.Modelo;
using App = UPC.Consciencia.Logica;

namespace UPC.Consciencia.ServiciosREST
{

    public class Noticia : INoticia
    {

        public Noticia()
        {

        }

        /// <summary>
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
        public ENT.CatalogoNoticia ListarCatalogoNoticiaPorId(string IdNoticia)
        {
            ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticiaPorId(Convert.ToInt32(IdNoticia));
            }

            return entCatalogo;
        }

        /// <summary>
        /// Obtiene los registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla.</param>
        /// <returns></returns>
        public List<ENT.CatalogoNoticia> ListarCatalogoNoticia(ENT.CatalogoNoticia Noticia)
        {
            List<ENT.CatalogoNoticia> entCatalogo = new List<ENT.CatalogoNoticia>();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticia(Noticia);
            }

            return entCatalogo;
        }

        public List<ENT.CatalogoNoticia> GrabarNoticia(List<ENT.CatalogoNoticia> Noticia)
        {
            List<ENT.CatalogoNoticia> entResponse = new List<ENT.CatalogoNoticia>();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                entResponse = appCatalogoNoticia.GrabarNoticia(Noticia);
            }

            return entResponse;
        }

        /// <summary>
        /// Cambia el estado de un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdNoticia">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public ENT.CatalogoNoticia CambiarSituacionCatalogoNoticia(string IdNoticia)
        {
            Boolean bolCorrecto = false;
            ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                bolCorrecto = appCatalogoNoticia.CambiarSituacionCatalogoNoticia(Convert.ToInt32(IdNoticia));

                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticiaPorId(Convert.ToInt32(IdNoticia));
            }

            return entCatalogo;
        }

    }

}