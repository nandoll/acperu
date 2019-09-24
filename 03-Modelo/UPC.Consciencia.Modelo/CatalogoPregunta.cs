using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Consciencia.Modelo
{
    /// <summary>
    /// Entidad para la tabla CatalogoPregunta
    /// </summary>
    public class CatalogoPregunta
    {

        #region "Miembros privados"

        private Int32 m_IdPregunta;
        private Int32 m_IdEscenario;
        private Int32 m_IdCategoria;
        private String m_TipoPregunta;
        private Int32 m_Orden;
        private String m_Descripcion;
        private String m_Contexto;
        private Int32 m_Peso;
        private String m_SituacionRegistro;
        private String m_UsuarioRegistro;
        private DateTime m_FechaRegistro;
        private String m_UsuarioCambio;
        private DateTime m_FechaCambio;

        #endregion

        #region "Constructor"

        public CatalogoPregunta()
        {
            m_IdPregunta = 0;
            m_IdEscenario = 0;
            m_IdCategoria = 0;
            m_TipoPregunta = String.Empty;
            m_Orden = 0;
            m_Descripcion = String.Empty;
            m_Contexto = String.Empty;
            m_Peso = 0;
            m_SituacionRegistro = String.Empty;
            m_UsuarioRegistro = String.Empty;
            m_FechaRegistro = new DateTime();
            m_UsuarioCambio = String.Empty;
            m_FechaCambio = new DateTime();
        }

        #endregion

        #region "Propiedades"

        public Int32 IdPregunta
        {
            get { return m_IdPregunta; }
            set { m_IdPregunta = value; }
        }

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

        public String TipoPregunta
        {
            get { return m_TipoPregunta; }
            set { m_TipoPregunta = value; }
        }

        public Int32 Orden
        {
            get { return m_Orden; }
            set { m_Orden = value; }
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

        public Int32 Peso
        {
            get { return m_Peso; }
            set { m_Peso = value; }
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