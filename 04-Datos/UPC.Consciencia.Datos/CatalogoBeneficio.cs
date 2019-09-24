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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoBeneficio
    /// </summary>
    public class CatalogoBeneficio : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoBeneficio(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoBeneficioTodo()
        {
            return base.GetDataTable("uspCatalogoBeneficioLstTodo", "TblCatalogoBeneficio");
        }

        public DataTable ListarCatalogoBeneficioPorId(Int32 intIdBeneficio)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdBeneficio", DbType.Int32, 10, intIdBeneficio);

            return base.GetDataTable("uspCatalogoBeneficioLstPorId", dbPar, "TblCatalogoBeneficio");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoBeneficio(ENT.CatalogoBeneficio ent)
        {
            DbParameter[] dbPar = new DbParameter[8];
            dbPar[0] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[1] = base.NewParameter("pObservacion", DbType.String, 4000, ent.Observacion);
            dbPar[2] = base.NewParameter("pRutaCupon", DbType.String, 500, ent.RutaCupon);
            dbPar[3] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[4] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[5] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[6] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[7] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoBeneficioIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoBeneficio(ENT.CatalogoBeneficio ent)
        {
            DbParameter[] dbPar = new DbParameter[9];
            dbPar[0] = base.NewParameter("pIdBeneficio", DbType.Int32, 10, ent.IdBeneficio);
            dbPar[1] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[2] = base.NewParameter("pObservacion", DbType.String, 4000, ent.Observacion);
            dbPar[3] = base.NewParameter("pRutaCupon", DbType.String, 500, ent.RutaCupon);
            dbPar[4] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[5] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[6] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[7] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[8] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoBeneficioUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdBeneficio">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoBeneficio(Int32 intIdBeneficio)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdBeneficio", DbType.Int32, 10, intIdBeneficio);

            return base.ExecuteProcedure("uspCatalogoBeneficioDel", dbPar);
        }

    }

}