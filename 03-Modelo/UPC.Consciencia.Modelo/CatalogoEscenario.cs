using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Consciencia.Modelo
{
    /// <summary>
    /// Entidad para la tabla CatalogoEscenario
    /// </summary>
    public class CatalogoEscenario
    {

        #region "Miembros privados"

        private Int32 m_IdEscenario;
        private Int32 m_IdCategoria;
        private String m_Descripcion;
        private String m_Contexto;
        private String m_Reflexion;
        private String m_RutaVideo;
        private String m_SituacionRegistro;
        private String m_UsuarioRegistro;
        private DateTime m_FechaRegistro;
        private String m_UsuarioCambio;
        private DateTime m_FechaCambio;

        #endregion

        #region "Constructor"

        public CatalogoEscenario()
        {
            m_IdEscenario = 0;
            m_IdCategoria = 0;
            m_Descripcion = String.Empty;
            m_Contexto = String.Empty;
            m_Reflexion = String.Empty;
            m_RutaVideo = String.Empty;
            m_SituacionRegistro = String.Empty;
            m_UsuarioRegistro = String.Empty;
            m_FechaRegistro = new DateTime();
            m_UsuarioCambio = String.Empty;
            m_FechaCambio = new DateTime();
        }

        #endregion

        #region "Propiedades"

        public Int32 IdEscenario
        {
            get { return m_IdEscenario; }
            set { m_IdEscenario = value; }
        }

        public Int32 IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }

        public String Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }

        public String Contexto
        {
            get { return m_Contexto; }
            set { m_Contexto = value; }
        }

        public String Reflexion
        {
            get { return m_Reflexion; }
            set { m_Reflexion = value; }
        }

        public String RutaVideo
        {
            get { return m_RutaVideo; }
            set { m_RutaVideo = value; }
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