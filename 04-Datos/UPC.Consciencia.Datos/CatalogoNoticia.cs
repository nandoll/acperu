using System;

using ENT = UPC.Consciencia.Modelo;
using System.Data.Common;
using System.Data;

namespace UPC.Consciencia.Datos
{
    /// <summary>
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoNoticia
    /// </summary>
    public class CatalogoNoticia : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoNoticia(DbConnection conex)
            : base(conex)
        {
        }

        /// <summary>
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
		public DataTable ListarCatalogoNoticiaPorId(Int32 intIdNoticia)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdNoticia", DbType.Int32, 10, intIdNoticia);

            return base.GetDataTable("uspCatalogoNoticiaLstPorId", dbPar, "TblCatalogoNoticia");
        }

        /// <summary>
        /// Obtiene los registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla.</param>
        /// <returns></returns>
        public DataTable ListarCatalogoNoticia(ENT.CatalogoNoticia ent)
        {
            DbParameter[] dbPar = new DbParameter[10];
            dbPar[0] = base.NewParameter("pIdNoticia", DbType.Int32, 10, ent.IdNoticia);
            dbPar[1] = base.NewParameter("pMedio", DbType.String, 200, ent.Medio);
            dbPar[2] = base.NewParameter("pFechaHora", DbType.DateTime, 20, ent.FechaHora);
            dbPar[3] = base.NewParameter("pTitulo", DbType.String, 1000, ent.Titulo);
            dbPar[4] = base.NewParameter("pContenido", DbType.String);
            dbPar[4].Value = ent.Contenido;
            dbPar[5] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[6] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[7] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[8] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[9] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.GetDataTable("uspCatalogoNoticiaLst", dbPar, "TblCatalogoNoticia");
        }

        /// <summary>
        /// Registra o actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Int32 GrabarCatalogoNoticia(ENT.CatalogoNoticia ent)
        {
            DbParameter[] dbPar = new DbParameter[10];
            dbPar[0] = base.NewParameter("pIdNoticia", DbType.Int32, 10, ent.IdNoticia);
            dbPar[0].Direction = ParameterDirection.InputOutput;
            dbPar[1] = base.NewParameter("pMedio", DbType.String, 200, ent.Medio);
            dbPar[2] = base.NewParameter("pFechaHora", DbType.DateTime, 20, ent.FechaHora);
            dbPar[3] = base.NewParameter("pTitulo", DbType.String, 1000, ent.Titulo);
            dbPar[4] = base.NewParameter("pContenido", DbType.String);
            dbPar[4].Value = ent.Contenido;
            dbPar[5] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[6] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[7] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[8] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[9] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            Boolean bolCorrecto = base.ExecuteProcedure("uspCatalogoNoticiaGrabar", dbPar);
            Int32 intIdNoticia = 0;

            if (bolCorrecto == true) {
                if (dbPar[0].Value != DBNull.Value)
                {
                    Int32.TryParse(dbPar[0].Value.ToString().Trim(), out intIdNoticia);
                }
            }

            return intIdNoticia;
        }

        /// <summary>
        /// Cambia el estado de un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdNoticia">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean CambiarSituacionCatalogoNoticia(Int32 intIdNoticia)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdNoticia", DbType.Int32, 10, intIdNoticia);

            return base.ExecuteProcedure("uspCatalogoNoticiaUpdSituacion", dbPar);
        }

    }

}