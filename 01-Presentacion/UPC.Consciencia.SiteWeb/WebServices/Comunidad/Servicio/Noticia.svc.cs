﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Xml.Serialization;

using ENT = UPC.Consciencia.Modelo;
using App = UPC.Consciencia.Logica;


namespace UPC.Consciencia.SiteWeb.WebServices.Comunidad.Servicio
{

    public class Noticia : INoticia
    {

        public Noticia()
        {

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
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
        public ENT.CatalogoNoticia ListarCatalogoNoticiaPorId(Int32 intIdNoticia)
        {
            ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticiaPorId(intIdNoticia);
            }

            return entCatalogo;
        }

        /// <summary>
        /// Obtiene los registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla.</param>
        /// <returns></returns>
        public List<ENT.CatalogoNoticia> ListarCatalogoNoticia(ENT.CatalogoNoticia ent) {
            List<ENT.CatalogoNoticia> entCatalogo = new List<ENT.CatalogoNoticia>();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticia(ent);
            }

            return entCatalogo;
        }

        /// <summary>
        /// Cambia el estado de un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdNoticia">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public ENT.CatalogoNoticia CambiarSituacionCatalogoNoticia(Int32 intIdNoticia) {
            Boolean bolCorrecto = false;
            ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                bolCorrecto = appCatalogoNoticia.CambiarSituacionCatalogoNoticia(intIdNoticia);

                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticiaPorId(intIdNoticia);
            }

            return entCatalogo;
        }

        public ENT.CatalogoNoticia LitarNoticia()
        {
            ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

            using (App.AppCatalogoNoticia appCatalogoNoticia = new App.AppCatalogoNoticia())
            {
                entCatalogo = appCatalogoNoticia.ListarCatalogoNoticiaPorId(1);
            }

            return entCatalogo;
        }

    }

}