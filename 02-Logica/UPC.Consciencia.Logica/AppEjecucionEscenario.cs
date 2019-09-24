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
    /// Clase que controla la lógica de la página. EjecucionEscenario
    /// </summary>
    public class AppEjecucionEscenario : Framework.DbAccess.Core.DbLogicLayerBase
    {

        public AppEjecucionEscenario()
            : base()
        {
        }

        public AppEjecucionEscenario(DbConnection conex)
            : base(conex)
        {
        }

        public DataView ListarEjecucionEscenarioTodo()
        {
            DA.EjecucionEscenario obj = new DA.EjecucionEscenario(base.Conexion);
            return obj.ListarEjecucionEscenarioTodo().DefaultView;
        }

        public DataView ListarEjecucionEscenarioPorId(Int32 intIdUsuario)
        {
            DA.EjecucionEscenario obj = new DA.EjecucionEscenario(base.Conexion);
            return obj.ListarEjecucionEscenarioPorId(intIdUsuario).DefaultView;
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarEjecucionEscenario(ENT.EjecucionEscenario ent)
        {
            DA.EjecucionEscenario obj = new DA.EjecucionEscenario(base.Conexion);
            return obj.InsertarEjecucionEscenario(ent);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarEjecucionEscenario(ENT.EjecucionEscenario ent)
        {
            DA.EjecucionEscenario obj = new DA.EjecucionEscenario(base.Conexion);
            return obj.ActualizarEjecucionEscenario(ent);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdUsuario">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarEjecucionEscenario(Int32 intIdUsuario)
        {
            DA.EjecucionEscenario obj = new DA.EjecucionEscenario(base.Conexion);
            return obj.DesactivarEjecucionEscenario(intIdUsuario);
        }

    }

}