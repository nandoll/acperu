using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ENT = UPC.Consciencia.Modelo;

namespace UPC.Consciencia.ServiciosREST
{
    
    [ServiceContract]
    public interface ICalificacion
    {

        /// <summary>
        /// Obtiene la calificación del usuario
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ObtenerCalificacion/{IdUsuario}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        String ObtenerCalificacion(string IdUsuario);

    }

}