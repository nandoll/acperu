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
    /// Clase que controla la lógica de la página. CatalogoPregunta
    /// </summary>
    public class AppCatalogoPregunta : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoPregunta()
            : base()
        {
        }

        public AppCatalogoPregunta(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoPreguntaTodo()
        {
            DA.CatalogoPregunta obj = new DA.CatalogoPregunta(base.Conexion);
            return obj.ListarCatalogoPreguntaTodo().DefaultView;
        }

        public DataView ListarCatalogoPreguntaPorId(Int32 intIdPregunta)
        {
            DA.CatalogoPregunta obj = new DA.CatalogoPregunta(base.Conexion);
            return obj.ListarCatalogoPreguntaPorId(intIdPregunta).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoPregunta(ENT.CatalogoPregunta ent)
        {
            DA.CatalogoPregunta obj = new DA.CatalogoPregunta(base.Conexion);
            return obj.InsertarCatalogoPregunta(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoPregunta(ENT.CatalogoPregunta ent)
        {
            DA.CatalogoPregunta obj = new DA.CatalogoPregunta(base.Conexion);
            return obj.ActualizarCatalogoPregunta(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdPregunta">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoPregunta(Int32 intIdPregunta)
        {
            DA.CatalogoPregunta obj = new DA.CatalogoPregunta(base.Conexion);
            return obj.DesactivarCatalogoPregunta(intIdPregunta);
        }

    }

}