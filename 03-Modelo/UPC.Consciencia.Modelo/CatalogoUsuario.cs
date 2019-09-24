using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Consciencia.Modelo
{
    /// <summary>
    /// Entidad para la tabla CatalogoUsuario
    /// </summary>
    public class CatalogoUsuario
    {

        #region "Miembros privados"

        private Int32 m_IdUsuario;
        private String m_Nombres;
        private String m_Apellidos;
        private String m_Correo;
        private String m_Clave;
        private Int32 m_Perfil;
        private String m_SituacionRegistro;
        private String m_UsuarioRegistro;
        private DateTime m_FechaRegistro;
        private String m_UsuarioCambio;
        private DateTime m_FechaCambio;

        #endregion

        #region "Constructor"

        public CatalogoUsuario()
        {
            m_IdUsuario = 0;
            m_Nombres = String.Empty;
            m_Apellidos = String.Empty;
            m_Correo = String.Empty;
            m_Clave = String.Empty;
            m_Perfil = 0;
            m_SituacionRegistro = String.Empty;
            m_UsuarioRegistro = String.Empty;
            m_FechaRegistro = new DateTime();
            m_UsuarioCambio = String.Empty;
            m_FechaCambio = new DateTime();
        }

        #endregion

        #region "Propiedades"

        public Int32 IdUsuario
        {
            get { return m_IdUsuario; }
            set { m_IdUsuario = value; }
        }

        public String Nombres
        {
            get { return m_Nombres; }
            set { m_Nombres = value; }
        }

        public String Apellidos
        {
            get { return m_Apellidos; }
            set { m_Apellidos = value; }
        }

        public String Correo
        {
            get { return m_Correo; }
            set { m_Correo = value; }
        }

        public String Clave
        {
            get { return m_Clave; }
            set { m_Clave = value; }
        }

        public Int32 Perfil
        {
            get { return m_Perfil; }
            set { m_Perfil = value; }
        }

        public String SituacionRegistro
        {
            get { return m_SituacionRegistro; }
            set { m_SituacionRegistro = value; }
        }

        public String UsuarioRegistro
        {
            get { return m_UsuarioRegistro; }
            set { m_UsuarioRegistro = value; }
        }

        public DateTime FechaRegistro
        {
            get { return m_FechaRegistro; }
            set { m_FechaRegistro = value; }
        }

        public String UsuarioCambio
        {
            get { return m_UsuarioCambio; }
            set { m_UsuarioCambio = value; }
        }

        public DateTime FechaCambio
        {
            get { return m_FechaCambio; }
            set { m_FechaCambio = value; }
        }

        #endregion

    }

}