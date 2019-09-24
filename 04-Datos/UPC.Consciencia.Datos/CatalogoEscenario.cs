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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoEscenario
    /// </summary>
    public class CatalogoEscenario : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoEscenario(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoEscenarioTodo()
        {
            return base.GetDataTable("uspCatalogoEscenarioLstTodo", "TblCatalogoEscenario");
        }

        public DataTable ListarCatalogoEscenarioPorId(Int32 intIdEscenario)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdEscenario", DbType.Int32, 10, intIdEscenario);

            return base.GetDataTable("uspCatalogoEscenarioLstPorId", dbPar, "TblCatalogoEscenario");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoEscenario(ENT.CatalogoEscenario ent)
        {
            DbParameter[] dbPar = new DbParameter[10];
            dbPar[0] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[1] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[2] = base.NewParameter("pContexto", DbType.String, 4000, ent.Contexto);
            dbPar[3] = base.NewParameter("pReflexion", DbType.String, 4000, ent.Reflexion);
            dbPar[4] = base.NewParameter("pRutaVideo", DbType.String, 500, ent.RutaVideo);
            dbPar[5] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[6] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[7] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[8] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[9] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoEscenarioIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoEscenario(ENT.CatalogoEscenario ent)
        {
            DbParameter[] dbPar = new DbParameter[11];
            dbPar[0] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[1] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[2] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[3] = base.NewParameter("pContexto", DbType.String, 4000, ent.Contexto);
            dbPar[4] = base.NewParameter("pReflexion", DbType.String, 4000, ent.Reflexion);
            dbPar[5] = base.NewParameter("pRutaVideo", DbType.String, 500, ent.RutaVideo);
            dbPar[6] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[7] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[8] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[9] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[10] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoEscenarioUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdEscenario">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoEscenario(Int32 intIdEscenario)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdEscenario", DbType.Int32, 10, intIdEscenario);

            return base.ExecuteProcedure("uspCatalogoEscenarioDel", dbPar);
        }

    }

}