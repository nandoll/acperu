using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace UPC.Consciencia.Modelo
{

    /// <summary>
    /// Entidad para el servicio Noticia
    /// </summary>
    [DataContract(Namespace = "")]
    public class CatalogoNoticia
    {

        #region "Miembros privados"

        private Int32 m_IdNoticia;
        private String m_Medio;
        private DateTime? m_FechaHora;
        private String m_Titulo;
        private String m_Contenido;
        private String m_SituacionRegistro;
        private String m_UsuarioRegistro;
        private DateTime? m_FechaRegistro;
        private String m_UsuarioCambio;
        private DateTime? m_FechaCambio;

        #endregion

        #region "Constructor"

        public CatalogoNoticia()
        {
            m_IdNoticia = 0;
            m_Medio = String.Empty;
            m_FechaHora = new DateTime();
            m_Titulo = String.Empty;
            m_Contenido = String.Empty;
            m_SituacionRegistro = String.Empty;
            m_UsuarioRegistro = String.Empty;
            m_FechaRegistro = new DateTime();
            m_UsuarioCambio = String.Empty;
            m_FechaCambio = new DateTime();
        }

        #endregion

        #region "Propiedades"

        [DataMember(Name = "IdNoticia", Order = 0, IsRequired = true)]
        public Int32 IdNoticia
        {
            get { return m_IdNoticia; }
            set { m_IdNoticia = value; }
        }

        [DataMember(Name = "Medio", Order = 1, IsRequired = true)]
        public String Medio
        {
            get { return m_Medio; }
            set { m_Medio = value; }
        }

        [DataMember(Name = "FechaHora", Order = 2, IsRequired = true)]
        public DateTime? FechaHora
        {
            get { return m_FechaHora; }
            set { m_FechaHora = value; }
        }

        [DataMember(Name = "Titulo", Order = 3, IsRequired = true)]
        public String Titulo
        {
            get { return m_Titulo; }
            set { m_Titulo = value; }
        }

        [DataMember(Name = "Contenido", Order = 4, IsRequired = true)]
        public String Contenido
        {
            get { return m_Contenido; }
            set { m_Contenido = value; }
        }

        [DataMember(Name = "SituacionRegistro", Order = 5, IsRequired = true)]
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

        public DateTime? FechaRegistro
        {
            get { return m_FechaRegistro; }
            set { m_FechaRegistro = value; }
        }

        public String UsuarioCambio
        {
            get { return m_UsuarioCambio; }
            set { m_UsuarioCambio = value; }
        }

        public DateTime? FechaCambio
        {
            get { return m_FechaCambio; }
            set { m_FechaCambio = value; }
        }

        #endregion

    }

}