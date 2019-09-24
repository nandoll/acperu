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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoPregunta
    /// </summary>
    public class CatalogoPregunta : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoPregunta(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoPreguntaTodo()
        {
            return base.GetDataTable("uspCatalogoPreguntaLstTodo", "TblCatalogoPregunta");
        }

        public DataTable ListarCatalogoPreguntaPorId(Int32 intIdPregunta)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdPregunta", DbType.Int32, 10, intIdPregunta);

            return base.GetDataTable("uspCatalogoPreguntaLstPorId", dbPar, "TblCatalogoPregunta");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoPregunta(ENT.CatalogoPregunta ent)
        {
            DbParameter[] dbPar = new DbParameter[12];
            dbPar[0] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[1] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[2] = base.NewParameter("pTipoPregunta", DbType.String, 20, ent.TipoPregunta);
            dbPar[3] = base.NewParameter("pOrden", DbType.Int32, 10, ent.Orden);
            dbPar[4] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[5] = base.NewParameter("pContexto", DbType.String, 4000, ent.Contexto);
            dbPar[6] = base.NewParameter("pPeso", DbType.Int32, 10, ent.Peso);
            dbPar[7] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[8] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[9] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[10] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[11] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoPreguntaIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoPregunta(ENT.CatalogoPregunta ent)
        {
            DbParameter[] dbPar = new DbParameter[13];
            dbPar[0] = base.NewParameter("pIdPregunta", DbType.Int32, 10, ent.IdPregunta);
            dbPar[1] = base.NewParameter("pIdEscenario", DbType.Int32, 10, ent.IdEscenario);
            dbPar[2] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[3] = base.NewParameter("pTipoPregunta", DbType.String, 20, ent.TipoPregunta);
            dbPar[4] = base.NewParameter("pOrden", DbType.Int32, 10, ent.Orden);
            dbPar[5] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[6] = base.NewParameter("pContexto", DbType.String, 4000, ent.Contexto);
            dbPar[7] = base.NewParameter("pPeso", DbType.Int32, 10, ent.Peso);
            dbPar[8] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[9] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[10] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[11] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[12] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoPreguntaUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdPregunta">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoPregunta(Int32 intIdPregunta)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdPregunta", DbType.Int32, 10, intIdPregunta);

            return base.ExecuteProcedure("uspCatalogoPreguntaDel", dbPar);
        }

    }

}