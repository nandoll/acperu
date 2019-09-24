using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Consciencia.Modelo
{
    /// <summary>
    /// Entidad para la tabla CatalogoBeneficio
    /// </summary>
    public class CatalogoBeneficio
    {

        #region "Miembros privados"

        private Int32 m_IdBeneficio;
        private String m_Descripcion;
        private String m_Observacion;
        private String m_RutaCupon;
        private String m_SituacionRegistro;
        private String m_UsuarioRegistro;
        private DateTime m_FechaRegistro;
        private String m_UsuarioCambio;
        private DateTime m_FechaCambio;

        #endregion

        #region "Constructor"

        public CatalogoBeneficio()
        {
            m_IdBeneficio = 0;
            m_Descripcion = String.Empty;
            m_Observacion = String.Empty;
            m_RutaCupon = String.Empty;
            m_SituacionRegistro = String.Empty;
            m_UsuarioRegistro = String.Empty;
            m_FechaRegistro = new DateTime();
            m_UsuarioCambio = String.Empty;
            m_FechaCambio = new DateTime();
        }

        #endregion

        #region "Propiedades"

        public Int32 IdBeneficio
        {
            get { return m_IdBeneficio; }
            set { m_IdBeneficio = value; }
        }

        public String Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }

        public String Observacion
        {
            get { return m_Observacion; }
            set { m_Observacion = value; }
        }

        public String RutaCupon
        {
            get { return m_RutaCupon; }
            set { m_RutaCupon = value; }
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