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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoUsuarioBeneficio
    /// </summary>
    public class CatalogoUsuarioBeneficio : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoUsuarioBeneficio(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoUsuarioBeneficioTodo()
        {
            return base.GetDataTable("uspCatalogoUsuarioBeneficioLstTodo", "TblCatalogoUsuarioBeneficio");
        }

        public DataTable ListarCatalogoUsuarioBeneficioPorId(Int32 intIdUsuarioBeneficio)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdUsuarioBeneficio", DbType.Int32, 10, intIdUsuarioBeneficio);

            return base.GetDataTable("uspCatalogoUsuarioBeneficioLstPorId", dbPar, "TblCatalogoUsuarioBeneficio");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoUsuarioBeneficio(ENT.CatalogoUsuarioBeneficio ent)
        {
            DbParameter[] dbPar = new DbParameter[7];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, ent.IdUsuario);
            dbPar[1] = base.NewParameter("pIdBeneficio", DbType.Int32, 10, ent.IdBeneficio);
            dbPar[2] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[3] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[4] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[5] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[6] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoUsuarioBeneficioIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoUsuarioBeneficio(ENT.CatalogoUsuarioBeneficio ent)
        {
            DbParameter[] dbPar = new DbParameter[8];
            dbPar[0] = base.NewParameter("pIdUsuarioBeneficio", DbType.Int32, 10, ent.IdUsuarioBeneficio);
            dbPar[1] = base.NewParameter("pIdUsuario", DbType.Int32, 10, ent.IdUsuario);
            dbPar[2] = base.NewParameter("pIdBeneficio", DbType.Int32, 10, ent.IdBeneficio);
            dbPar[3] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[4] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[5] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[6] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[7] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoUsuarioBeneficioUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdUsuarioBeneficio">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoUsuarioBeneficio(Int32 intIdUsuarioBeneficio)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdUsuarioBeneficio", DbType.Int32, 10, intIdUsuarioBeneficio);

            return base.ExecuteProcedure("uspCatalogoUsuarioBeneficioDel", dbPar);
        }

    }

}