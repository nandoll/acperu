using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ENT = UPC.Consciencia.Modelo;

namespace UPC.Consciencia.SiteWeb.WebServices.Comunidad.Servicio
{

    //[ServiceContract(Namespace = "http://upc.svc/Service/")]
    [ServiceContract()]
    public interface INoticia
    {

        [OperationContract(Name = "GrabarNoticia")]
        [WebInvoke()]
        List<ENT.CatalogoNoticia> GrabarNoticia(List<ENT.CatalogoNoticia> Noticia);

        /// <summary>
        /// Obtiene el registro por su código
        /// </summary>
        /// <param name="intIdNoticia"></param>
        /// <returns></returns>
        [OperationContract(Name = "ListarCatalogoNoticiaPorId")]
        [WebInvoke()]
        ENT.CatalogoNoticia ListarCatalogoNoticiaPorId(Int32 intIdNoticia);

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
        [OperationContract(Name = "CambiarSituacionCatalogoNoticia")]
        [WebInvoke()]
        ENT.CatalogoNoticia CambiarSituacionCatalogoNoticia(Int32 intIdNoticia);

    }

}