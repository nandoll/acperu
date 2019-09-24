using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using ENT = UPC.Consciencia.Modelo;
using App = UPC.Consciencia.Logica;


namespace UPC.Consciencia.ServiciosREST
{
    
    public class Calificacion : ICalificacion
    {

        public Calificacion()
        {

        }

        /// <summary>
        /// Obtiene la calificación del usuario
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public String ObtenerCalificacion(string IdUsuario)
        {
            return "5";
        }


    }

}