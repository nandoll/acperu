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
    /// Clase que controla la lógica de la página. CatalogoEscenario
    /// </summary>
    public class AppCatalogoEscenario : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppCatalogoEscenario()
            : base()
        {
        }

        public AppCatalogoEscenario(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarCatalogoEscenarioTodo()
        {
            DA.CatalogoEscenario obj = new DA.CatalogoEscenario(base.Conexion);
            return obj.ListarCatalogoEscenarioTodo().DefaultView;
        }

        public DataView ListarCatalogoEscenarioPorId(Int32 intIdEscenario)
        {
            DA.CatalogoEscenario obj = new DA.CatalogoEscenario(base.Conexion);
            return obj.ListarCatalogoEscenarioPorId(intIdEscenario).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoEscenario(ENT.CatalogoEscenario ent)
        {
            DA.CatalogoEscenario obj = new DA.CatalogoEscenario(base.Conexion);
            return obj.InsertarCatalogoEscenario(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoEscenario(ENT.CatalogoEscenario ent)
        {
            DA.CatalogoEscenario obj = new DA.CatalogoEscenario(base.Conexion);
            return obj.ActualizarCatalogoEscenario(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdEscenario">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoEscenario(Int32 intIdEscenario)
        {
            DA.CatalogoEscenario obj = new DA.CatalogoEscenario(base.Conexion);
            return obj.DesactivarCatalogoEscenario(intIdEscenario);
        }

    }

}