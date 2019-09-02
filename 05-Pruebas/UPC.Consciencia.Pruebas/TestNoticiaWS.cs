using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UPC.Consciencia.Pruebas
{

    [TestClass]
    public class TestNoticiaWS
    {

        [TestMethod]
        public void TestGrabarNoticia()
        {
            NoticiaWS.NoticiaClient wsNoticia = new NoticiaWS.NoticiaClient();

            NoticiaWS.CatalogoNoticia[] lstNoticia = new NoticiaWS.CatalogoNoticia[1];

            NoticiaWS.CatalogoNoticia entNoticia = new NoticiaWS.CatalogoNoticia();
            entNoticia.IdNoticia = 0;
            entNoticia.Medio = "Perú 21";
            entNoticia.FechaHora = DateTime.Now;
            entNoticia.Titulo = "Habilitan línea gratuita para denunciar actos de corrupción en sector educativo";
            entNoticia.Contenido = "Minedu insta a la sociedad a denunciar cualquier hecho de corrupción que noten en el sector mediante un correo electrónico. Identidad de denunciantes se mantendrá en reserva, informaron. ";
            entNoticia.SituacionRegistro = "A";
            lstNoticia[0] = (entNoticia);

            NoticiaWS.CatalogoNoticia[] lstNoticiaRetorno = wsNoticia.GrabarNoticia(lstNoticia);

            Assert.AreEqual("Perú 21", lstNoticiaRetorno[0].Medio);
            Assert.AreEqual("A", lstNoticiaRetorno[0].SituacionRegistro);

        }

    }

}