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
    /// Clase que controla la lógica de la página. CatalogoUsuarioBeneficio
    /// </summary>
    public class AppCatalogoUsuarioBeneficio : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoUsuarioBeneficio()
            : base()
        {
        }

        public AppCatalogoUsuarioBeneficio(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoUsuarioBeneficioTodo()
        {
            DA.CatalogoUsuarioBeneficio obj = new DA.CatalogoUsuarioBeneficio(base.Conexion);
            return obj.ListarCatalogoUsuarioBeneficioTodo().DefaultView;
        }

        public DataView ListarCatalogoUsuarioBeneficioPorId(Int32 intIdUsuarioBeneficio)
        {
            DA.CatalogoUsuarioBeneficio obj = new DA.CatalogoUsuarioBeneficio(base.Conexion);
            return obj.ListarCatalogoUsuarioBeneficioPorId(intIdUsuarioBeneficio).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoUsuarioBeneficio(ENT.CatalogoUsuarioBeneficio ent)
        {
            DA.CatalogoUsuarioBeneficio obj = new DA.CatalogoUsuarioBeneficio(base.Conexion);
            return obj.InsertarCatalogoUsuarioBeneficio(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoUsuarioBeneficio(ENT.CatalogoUsuarioBeneficio ent)
        {
            DA.CatalogoUsuarioBeneficio obj = new DA.CatalogoUsuarioBeneficio(base.Conexion);
            return obj.ActualizarCatalogoUsuarioBeneficio(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdUsuarioBeneficio">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoUsuarioBeneficio(Int32 intIdUsuarioBeneficio)
        {
            DA.CatalogoUsuarioBeneficio obj = new DA.CatalogoUsuarioBeneficio(base.Conexion);
            return obj.DesactivarCatalogoUsuarioBeneficio(intIdUsuarioBeneficio);
        }

    }

}