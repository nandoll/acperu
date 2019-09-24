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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoRespuesta
    /// </summary>
    public class CatalogoRespuesta : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoRespuesta(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoRespuestaTodo()
        {
            return base.GetDataTable("uspCatalogoRespuestaLstTodo", "TblCatalogoRespuesta");
        }

        public DataTable ListarCatalogoRespuestaPorId(Int32 intIdRespuesta)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdRespuesta", DbType.Int32, 10, intIdRespuesta);

            return base.GetDataTable("uspCatalogoRespuestaLstPorId", dbPar, "TblCatalogoRespuesta");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoRespuesta(ENT.CatalogoRespuesta ent)
        {
            DbParameter[] dbPar = new DbParameter[11];
            dbPar[0] = base.NewParameter("pIdPregunta", DbType.Int32, 10, ent.IdPregunta);
            dbPar[1] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[2] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[3] = base.NewParameter("pOrden", DbType.Int32, 10, ent.Orden);
            dbPar[4] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[5] = base.NewParameter("pEsCorrecto", DbType.Int32, 10, ent.EsCorrecto);
            dbPar[6] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[7] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[8] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[9] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[10] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoRespuestaIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoRespuesta(ENT.CatalogoRespuesta ent)
        {
            DbParameter[] dbPar = new DbParameter[12];
            dbPar[0] = base.NewParameter("pIdRespuesta", DbType.Int32, 10, ent.IdRespuesta);
            dbPar[1] = base.NewParameter("pIdPregunta", DbType.Int32, 10, ent.IdPregunta);
            dbPar[2] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[3] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[4] = base.NewParameter("pOrden", DbType.Int32, 10, ent.Orden);
            dbPar[5] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[6] = base.NewParameter("pEsCorrecto", DbType.Int32, 10, ent.EsCorrecto);
            dbPar[7] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[8] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[9] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[10] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[11] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoRespuestaUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdRespuesta">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoRespuesta(Int32 intIdRespuesta)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdRespuesta", DbType.Int32, 10, intIdRespuesta);

            return base.ExecuteProcedure("uspCatalogoRespuestaDel", dbPar);
        }

    }

}