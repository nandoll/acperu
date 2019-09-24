using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ENT = UPC.Consciencia.Modelo;
using System.Data.Common;
using System.Data;

namespace UPC.Consciencia.Datos
{
    /// <summary>
    /// Clase que administrará los métodos de acceso a datos para la tabla EjecucionEscenario
    /// </summary>
    public class EjecucionEscenario : Framework.DbAccess.Core.DbBaseHelper
    {

        public EjecucionEscenario(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarEjecucionEscenarioTodo()
        {
            return base.GetDataTable("uspEjecucionEscenarioLstTodo", "TblEjecucionEscenario");
        }

        public DataTable ListarEjecucionEscenarioPorId(Int32 intIdUsuario)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, intIdUsuario);

            return base.GetDataTable("uspEjecucionEscenarioLstPorId", dbPar, "TblEjecucionEscenario");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarEjecucionEscenario(ENT.EjecucionEscenario ent)
        {
            DbParameter[] dbPar = new DbParameter[9];
            dbPar[0] = base.NewParameter("pIdRespuesta", DbType.Int32, 10, ent.IdRespuesta);
            dbPar[1] = base.NewParameter("pIdPregunta", DbType.Int32, 10, ent.IdPregunta);
            dbPar[2] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[3] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[4] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[5] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[6] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[7] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[8] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspEjecucionEscenarioIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarEjecucionEscenario(ENT.EjecucionEscenario ent)
        {
            DbParameter[] dbPar = new DbParameter[10];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, ent.IdUsuario);
            dbPar[1] = base.NewParameter("pIdRespuesta", DbType.Int32, 10, ent.IdRespuesta);
            dbPar[2] = base.NewParameter("pIdPregunta", DbType.Int32, 10, ent.IdPregunta);
            dbPar[3] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[4] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[5] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[6] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[7] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[8] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[9] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspEjecucionEscenarioUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdUsuario">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarEjecucionEscenario(Int32 intIdUsuario)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, intIdUsuario);

            return base.ExecuteProcedure("uspEjecucionEscenarioDel", dbPar);
        }

    }

}