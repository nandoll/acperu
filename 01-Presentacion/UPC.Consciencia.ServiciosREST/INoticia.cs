using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ENT = UPC.Consciencia.Modelo;

namespace UPC.Consciencia.ServiciosREST
{

    [ServiceContract()]
    public interface INoticia
    {

        /// <summary>
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListarCatalogoNoticiaPorId/{IdNoticia}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        ENT.CatalogoNoticia ListarCatalogoNoticiaPorId(string IdNoticia);

        /// <summary>
        /// Obtiene los registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla.</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ListarCatalogoNoticia/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<ENT.CatalogoNoticia> ListarCatalogoNoticia(ENT.CatalogoNoticia Noticia);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GrabarNoticia/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<ENT.CatalogoNoticia> GrabarNoticia(List<ENT.CatalogoNoticia> Noticia);

        /// <summary>
        /// Cambia el estado de un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdNoticia">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "/CambiarSituacionCatalogoNoticia/{IdNoticia}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        ENT.CatalogoNoticia CambiarSituacionCatalogoNoticia(string IdNoticia);

    }

}