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
    /// Clase que controla la lógica de la página. CatalogoCategoria
    /// </summary>
    public class AppCatalogoCategoria : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoCategoria()
            : base()
        {
        }

        public AppCatalogoCategoria(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoCategoriaTodo()
        {
            DA.CatalogoCategoria obj = new DA.CatalogoCategoria(base.Conexion);
            return obj.ListarCatalogoCategoriaTodo().DefaultView;
        }

        public DataView ListarCatalogoCategoriaPorId(Int32 intIdCategoria)
        {
            DA.CatalogoCategoria obj = new DA.CatalogoCategoria(base.Conexion);
            return obj.ListarCatalogoCategoriaPorId(intIdCategoria).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoCategoria(ENT.CatalogoCategoria ent)
        {
            DA.CatalogoCategoria obj = new DA.CatalogoCategoria(base.Conexion);
            return obj.InsertarCatalogoCategoria(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoCategoria(ENT.CatalogoCategoria ent)
        {
            DA.CatalogoCategoria obj = new DA.CatalogoCategoria(base.Conexion);
            return obj.ActualizarCatalogoCategoria(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdCategoria">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoCategoria(Int32 intIdCategoria)
        {
            DA.CatalogoCategoria obj = new DA.CatalogoCategoria(base.Conexion);
            return obj.DesactivarCatalogoCategoria(intIdCategoria);
        }

    }

}