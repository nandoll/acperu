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
    /// Clase que controla la lógica de la página. CatalogoRespuesta
    /// </summary>
    public class AppCatalogoRespuesta : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoRespuesta()
            : base()
        {
        }

        public AppCatalogoRespuesta(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoRespuestaTodo()
        {
            DA.CatalogoRespuesta obj = new DA.CatalogoRespuesta(base.Conexion);
            return obj.ListarCatalogoRespuestaTodo().DefaultView;
        }

        public DataView ListarCatalogoRespuestaPorId(Int32 intIdRespuesta)
        {
            DA.CatalogoRespuesta obj = new DA.CatalogoRespuesta(base.Conexion);
            return obj.ListarCatalogoRespuestaPorId(intIdRespuesta).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoRespuesta(ENT.CatalogoRespuesta ent)
        {
            DA.CatalogoRespuesta obj = new DA.CatalogoRespuesta(base.Conexion);
            return obj.InsertarCatalogoRespuesta(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoRespuesta(ENT.CatalogoRespuesta ent)
        {
            DA.CatalogoRespuesta obj = new DA.CatalogoRespuesta(base.Conexion);
            return obj.ActualizarCatalogoRespuesta(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdRespuesta">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoRespuesta(Int32 intIdRespuesta)
        {
            DA.CatalogoRespuesta obj = new DA.CatalogoRespuesta(base.Conexion);
            return obj.DesactivarCatalogoRespuesta(intIdRespuesta);
        }

    }

}