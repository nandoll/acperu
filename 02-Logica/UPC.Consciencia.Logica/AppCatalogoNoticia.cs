using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ENT = UPC.Consciencia.Modelo;
using DA = UPC.Consciencia.Datos;
using System.Data.Common;
using System.Data;

namespace UPC.Consciencia.Logica
{

    /// <summary>
    /// Clase que controla la lógica de la página. CatalogoNoticia
    /// </summary>
    public class AppCatalogoNoticia : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoNoticia()
            : base()
        {
        }

        public AppCatalogoNoticia(DbConnection conex)
            : base(conex)
        {
        }

        /// <summary>
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
        public ENT.CatalogoNoticia ListarCatalogoNoticiaPorId(Int32 intIdNoticia)
        {
            DA.CatalogoNoticia obj = new DA.CatalogoNoticia(base.Conexion);

            DataTable dtCatalogo = obj.ListarCatalogoNoticiaPorId(intIdNoticia);
            ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

            if (dtCatalogo.Rows.Count > 0)
            {
                entCatalogo.IdNoticia = Convert.ToInt32(dtCatalogo.Rows[0]["IdNoticia"]);
                entCatalogo.Medio = dtCatalogo.Rows[0]["Medio"].ToString();
                entCatalogo.FechaHora = Convert.ToDateTime(dtCatalogo.Rows[0]["FechaHora"]);
                entCatalogo.Titulo = dtCatalogo.Rows[0]["Titulo"].ToString();
                entCatalogo.Contenido = dtCatalogo.Rows[0]["Contenido"].ToString();
                entCatalogo.SituacionRegistro = dtCatalogo.Rows[0]["SituacionRegistro"].ToString();
                entCatalogo.UsuarioRegistro = dtCatalogo.Rows[0]["UsuarioRegistro"].ToString();
                entCatalogo.FechaRegistro = Convert.ToDateTime(dtCatalogo.Rows[0]["FechaRegistro"]);
                //entCatalogo.UsuarioCambio = dtCatalogo.Rows[0]["UsuarioCambio"].ToString();
                //entCatalogo.FechaCambio = dtCatalogo.Rows[0]["FechaCambio"].ToString();
            }

            return entCatalogo;
        }

        /// <summary>
        /// Obtiene los registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla.</param>
        /// <returns></returns>
        public List<ENT.CatalogoNoticia> ListarCatalogoNoticia(ENT.CatalogoNoticia ent)
        {
            DA.CatalogoNoticia obj = new DA.CatalogoNoticia(base.Conexion);

            DataTable dtCatalogo = obj.ListarCatalogoNoticia(ent);
            List<ENT.CatalogoNoticia> listaCatalogo = new List<ENT.CatalogoNoticia>();

            foreach (DataRow drCatalogo in dtCatalogo.Rows)
            {
                ENT.CatalogoNoticia entCatalogo = new ENT.CatalogoNoticia();

                entCatalogo.IdNoticia = Convert.ToInt32(drCatalogo["IdNoticia"]);
                entCatalogo.Medio = drCatalogo["Medio"].ToString();
                entCatalogo.FechaHora = Convert.ToDateTime(drCatalogo["FechaHora"]);
                entCatalogo.Titulo = drCatalogo["Titulo"].ToString();
                entCatalogo.Contenido = drCatalogo["Contenido"].ToString();
                entCatalogo.SituacionRegistro = drCatalogo["SituacionRegistro"].ToString();
                entCatalogo.UsuarioRegistro = drCatalogo["UsuarioRegistro"].ToString();
                entCatalogo.FechaRegistro = Convert.ToDateTime(drCatalogo["FechaRegistro"]);
                //entCatalogo.UsuarioCambio = dtCatalogo.Rows[0]["UsuarioCambio"].ToString();
                //entCatalogo.FechaCambio = dtCatalogo.Rows[0]["FechaCambio"].ToString();

                listaCatalogo.Add(entCatalogo);
            }

            return listaCatalogo;
        }

        /// <summary>
        /// Registra o actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
		public Int32 GrabarCatalogoNoticia(ENT.CatalogoNoticia ent)
        {
            DA.CatalogoNoticia obj = new DA.CatalogoNoticia(base.Conexion);
            return obj.GrabarCatalogoNoticia(ent);
        }

        /// <summary>
        /// Cambia el estado de un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdNoticia">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean CambiarSituacionCatalogoNoticia(Int32 intIdNoticia)
        {
            DA.CatalogoNoticia obj = new DA.CatalogoNoticia(base.Conexion);
            return obj.CambiarSituacionCatalogoNoticia(intIdNoticia);
        }

        /// <summary>
        /// Registra o actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public List<ENT.CatalogoNoticia> GrabarNoticia(List<ENT.CatalogoNoticia> Noticia)
        {
            DA.CatalogoNoticia obj = new DA.CatalogoNoticia(base.Conexion);
            List<ENT.CatalogoNoticia> entResponse = new List<ENT.CatalogoNoticia>();
            Int32 intIdNoticia = 0;

            if (Noticia == null)
            {
                return entResponse;
            }

            foreach (ENT.CatalogoNoticia entNoticia in Noticia)
            {
                entNoticia.SituacionRegistro = "A";
                entNoticia.UsuarioRegistro = "WS";
                entNoticia.FechaRegistro = DateTime.Now;
                entNoticia.UsuarioCambio = "WS";
                entNoticia.FechaCambio = DateTime.Now;

                intIdNoticia = obj.GrabarCatalogoNoticia(entNoticia);

                if (intIdNoticia > 0)
                {
                    entResponse.Add(this.ListarCatalogoNoticiaPorId(intIdNoticia));
                }

            }

            return entResponse;
        }

    }

}