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

        [OperationContract]
        [WebInvoke(UriTemplate = "/GrabarNoticia", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<ENT.CatalogoNoticia> GrabarNoticia(List<ENT.CatalogoNoticia> Noticia);

        /// <summary>
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/ListarCatalogoNoticiaPorId/{intIdNoticia}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        ENT.CatalogoNoticia ListarCatalogoNoticiaPorId(string intIdNoticia);

        /// <summary>
        /// Obtiene los registro de la tabla.
        /// </summary>
        /// <param name="ent">Entidad que representa la tabla.</param>
        /// <returns></returns>
        [OperationContract(Name = "ListarCatalogoNoticia")]
        [WebInvoke()]
        List<ENT.CatalogoNoticia> ListarCatalogoNoticia(ENT.CatalogoNoticia ent);

        /// <summary>
        /// Cambia el estado de un registro logicamente de la tabla.
        /// </summary>
        /// <param name="intIdNoticia">Código identificador de la tabla. </param>
        /// <returns>Valor de exito.</returns>
        /// <remarks></remarks>
        [OperationContract()]
        [WebInvoke(UriTemplate = "/CambiarSituacionCatalogoNoticia", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
        ENT.CatalogoNoticia CambiarSituacionCatalogoNoticia(string intIdNoticia);

    }

}