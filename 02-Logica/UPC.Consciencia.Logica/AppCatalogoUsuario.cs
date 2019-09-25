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
    /// Clase que controla la lógica de la página. CatalogoUsuario
    /// </summary>
    public class AppCatalogoUsuario : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoUsuario()
            : base()
        {
        }

        public AppCatalogoUsuario(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoUsuarioTodo()
        {
            DA.CatalogoUsuario obj = new DA.CatalogoUsuario(base.Conexion);
            return obj.ListarCatalogoUsuarioTodo().DefaultView;
        }

        public DataView ListarCatalogoUsuarioPorId(Int32 intIdUsuario)
        {
            DA.CatalogoUsuario obj = new DA.CatalogoUsuario(base.Conexion);
            return obj.ListarCatalogoUsuarioPorId(intIdUsuario).DefaultView;
        }


        /// <summary>
        /// Inserta o actualiza un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Int32 GrabarCatalogoUsuario(ENT.CatalogoUsuario ent)
        {
            DA.CatalogoUsuario obj = new DA.CatalogoUsuario(base.Conexion);
            return obj.GrabarCatalogoUsuario(ent);
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoUsuario(ENT.CatalogoUsuario ent)
        {
            DA.CatalogoUsuario obj = new DA.CatalogoUsuario(base.Conexion);
            return obj.InsertarCatalogoUsuario(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoUsuario(ENT.CatalogoUsuario ent)
        {
            DA.CatalogoUsuario obj = new DA.CatalogoUsuario(base.Conexion);
            return obj.ActualizarCatalogoUsuario(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdUsuario">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoUsuario(Int32 intIdUsuario)
        {
            DA.CatalogoUsuario obj = new DA.CatalogoUsuario(base.Conexion);
            return obj.DesactivarCatalogoUsuario(intIdUsuario);
        }

    }

}