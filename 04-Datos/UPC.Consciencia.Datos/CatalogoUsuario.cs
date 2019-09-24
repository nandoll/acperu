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
    /// Clase que administrará los métodos de acceso a datos para la tabla CatalogoUsuario
    /// </summary>
    public class CatalogoUsuario : Framework.DbAccess.Core.DbBaseHelper
    {

        public CatalogoUsuario(DbConnection conex)
            : base(conex)
        {
        }

        public DataTable ListarCatalogoUsuarioTodo()
        {
            return base.GetDataTable("uspCatalogoUsuarioLstTodo", "TblCatalogoUsuario");
        }

        public DataTable ListarCatalogoUsuarioPorId(Int32 intIdUsuario)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, intIdUsuario);

            return base.GetDataTable("uspCatalogoUsuarioLstPorId", dbPar, "TblCatalogoUsuario");
        }

        /// <summary>
        /// Inserta un nuevo registro a la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean InsertarCatalogoUsuario(ENT.CatalogoUsuario ent)
        {
            DbParameter[] dbPar = new DbParameter[10];
            dbPar[0] = base.NewParameter("pNombres", DbType.String, 200, ent.Nombres);
            dbPar[1] = base.NewParameter("pApellidos", DbType.String, 200, ent.Apellidos);
            dbPar[2] = base.NewParameter("pCorreo", DbType.String, 200, ent.Correo);
            dbPar[3] = base.NewParameter("pClave", DbType.String, 2000, ent.Clave);
            dbPar[4] = base.NewParameter("pPerfil", DbType.Int32, 10, ent.Perfil);
            dbPar[5] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[6] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[7] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[8] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[9] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoUsuarioIns", dbPar);
        }

        /// <summary>
        /// Actualiza un registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean ActualizarCatalogoUsuario(ENT.CatalogoUsuario ent)
        {
            DbParameter[] dbPar = new DbParameter[11];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, ent.IdUsuario);
            dbPar[1] = base.NewParameter("pNombres", DbType.String, 200, ent.Nombres);
            dbPar[2] = base.NewParameter("pApellidos", DbType.String, 200, ent.Apellidos);
            dbPar[3] = base.NewParameter("pCorreo", DbType.String, 200, ent.Correo);
            dbPar[4] = base.NewParameter("pClave", DbType.String, 2000, ent.Clave);
            dbPar[5] = base.NewParameter("pPerfil", DbType.Int32, 10, ent.Perfil);
            dbPar[6] = base.NewParameter("pSituacionRegistro", DbType.String, 1, ent.SituacionRegistro);
            dbPar[7] = base.NewParameter("pUsuarioRegistro", DbType.String, 9, ent.UsuarioRegistro);
            dbPar[8] = base.NewParameter("pFechaRegistro", DbType.DateTime, 20, ent.FechaRegistro);
            dbPar[9] = base.NewParameter("pUsuarioCambio", DbType.String, 9, ent.UsuarioCambio);
            dbPar[10] = base.NewParameter("pFechaCambio", DbType.DateTime, 20, ent.FechaCambio);

            return base.ExecuteProcedure("uspCatalogoUsuarioUpd", dbPar);
        }

        /// <summary>
        /// Elimina un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdUsuario">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        public Boolean DesactivarCatalogoUsuario(Int32 intIdUsuario)
        {
            DbParameter[] dbPar = new DbParameter[1];
            dbPar[0] = base.NewParameter("pIdUsuario", DbType.Int32, 10, intIdUsuario);

            return base.ExecuteProcedure("uspCatalogoUsuarioDel", dbPar);
        }

    }

}