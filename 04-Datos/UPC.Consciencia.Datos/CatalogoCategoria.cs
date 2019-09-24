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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoCategoria
    /// </summary>
    public class CatalogoCategoria : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoCategoria(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoCategoriaTodo()
        {
            return base.GetDataTable("uspCatalogoCategoriaLstTodo", "TblCatalogoCategoria");
        }

        public DataTable ListarCatalogoCategoriaPorId(Int32 intIdCategoria)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdCategoria", DbType.Int32, 10, intIdCategoria);

            return base.GetDataTable("uspCatalogoCategoriaLstPorId", dbPar, "TblCatalogoCategoria");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoCategoria(ENT.CatalogoCategoria ent)
        {
            DbParameter[] dbPar = new DbParameter[7];
            dbPar[0] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[1] = base.NewParameter("pContexto", DbType.String, 4000, ent.Contexto);
            dbPar[2] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[3] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[4] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[5] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[6] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoCategoriaIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoCategoria(ENT.CatalogoCategoria ent)
        {
            DbParameter[] dbPar = new DbParameter[8];
            dbPar[0] = base.NewParameter("pIdCategoria", DbType.Int32, 10, ent.IdCategoria);
            dbPar[1] = base.NewParameter("pDescripcion", DbType.String, 200, ent.Descripcion);
            dbPar[2] = base.NewParameter("pContexto", DbType.String, 4000, ent.Contexto);
            dbPar[3] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[4] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[5] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[6] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[7] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoCategoriaUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdCategoria">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoCategoria(Int32 intIdCategoria)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdCategoria", DbType.Int32, 10, intIdCategoria);

            return base.ExecuteProcedure("uspCatalogoCategoriaDel", dbPar);
        }

    }

}