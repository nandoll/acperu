using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Consciencia.Modelo
{
    /// <summary>
    /// Entidad para la tabla CatalogoUsuarioBeneficio
    /// </summary>
    public class CatalogoUsuarioBeneficio
    {

        #region "Miembros privados"

        private Int32 m_IdUsuarioBeneficio;
        private Int32 m_IdUsuario;
        private Int32 m_IdBeneficio;
        private String m_SituacionRegistro;
        private String m_UsuarioRegistro;
        private DateTime m_FechaRegistro;
        private String m_UsuarioCambio;
        private DateTime m_FechaCambio;

        #endregion

        #region "Constructor"

        public CatalogoUsuarioBeneficio()
        {
            m_IdUsuarioBeneficio = 0;
            m_IdUsuario = 0;
            m_IdBeneficio = 0;
            m_SituacionRegistro = String.Empty;
            m_UsuarioRegistro = String.Empty;
            m_FechaRegistro = new DateTime();
            m_UsuarioCambio = String.Empty;
            m_FechaCambio = new DateTime();
        }

        #endregion

        #region "Propiedades"

        public Int32 IdUsuarioBeneficio
        {
            get { return m_IdUsuarioBeneficio; }
            set { m_IdUsuarioBeneficio = value; }
        }

        public Int32 IdUsuario
        {
            get { return m_IdUsuario; }
            set { m_IdUsuario = value; }
        }

        public Int32 IdBeneficio
        {
            get { return m_IdBeneficio; }
            set { m_IdBeneficio = value; }
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