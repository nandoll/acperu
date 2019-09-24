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
    /// Clase que controla la lógica de la página. CatalogoBeneficio
    /// </summary>
    public class AppCatalogoBeneficio : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoBeneficio()
            : base()
        {
        }

        public AppCatalogoBeneficio(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoBeneficioTodo()
        {
            DA.CatalogoBeneficio obj = new DA.CatalogoBeneficio(base.Conexion);
            return obj.ListarCatalogoBeneficioTodo().DefaultView;
        }

        public DataView ListarCatalogoBeneficioPorId(Int32 intIdBeneficio)
        {
            DA.CatalogoBeneficio obj = new DA.CatalogoBeneficio(base.Conexion);
            return obj.ListarCatalogoBeneficioPorId(intIdBeneficio).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoBeneficio(ENT.CatalogoBeneficio ent)
        {
            DA.CatalogoBeneficio obj = new DA.CatalogoBeneficio(base.Conexion);
            return obj.InsertarCatalogoBeneficio(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoBeneficio(ENT.CatalogoBeneficio ent)
        {
            DA.CatalogoBeneficio obj = new DA.CatalogoBeneficio(base.Conexion);
            return obj.ActualizarCatalogoBeneficio(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdBeneficio">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoBeneficio(Int32 intIdBeneficio)
        {
            DA.CatalogoBeneficio obj = new DA.CatalogoBeneficio(base.Conexion);
            return obj.DesactivarCatalogoBeneficio(intIdBeneficio);
        }

    }

}