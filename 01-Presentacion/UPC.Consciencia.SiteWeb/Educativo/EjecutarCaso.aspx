<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/LayoutPrincipal.master" AutoEventWireup="true" CodeBehind="EjecutarCaso.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Educativo.EjecutarCaso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <div class="col-sm-12">
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Caso: Odebrecht</h1>
        </div>
    </div>

    <div class="col-lg-12">
        <center>
            <%-- --%>
            <%--<iframe width="560" height="315" src="https://www.youtube.com/watch?v=MmQSuSawMHE" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen>

            </iframe>--%>
            <iframe class="col-lg-8 col-sm-12" height="315" src="https://www.youtube.com/embed/MmQSuSawMHE" frameborder="0" allow="autoplay" allowfullscreen >

            </iframe>
            <%--<img src="../Content/imgOdebrecht.png" alt="" />--%>
        </center>
    </div>
    <div class="col-lg-12">

        <div class="card shadow mb-4 border-left-info">
            <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                <h6 class="m-0 font-weight-bold text-primary">1.- ¿COMO DENOMINO LA PRENSA INTERNACIONAL A LA CONFESION QUE HIZO MARCELO ODEBRETCH?</h6>
            </a>
            <div class="collapse show" id="collapseCardExample" style="">
                <div class="card-body">
                    <input type="radio" id="prg1" value="asd" name="rbprg1" />a- LA CONFESION CAOTICA
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg1" />b- LA CONFESION DEL ESCANDALO
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg1" />c- LA CONFESION DEL FIN DEL MUNDO
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg1" />d- LA CONFESION DE LOS BRASILEÑOS
                </div>
            </div>
        </div>

        <div class="card shadow mb-4 border-left-info">
            <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                <h6 class="m-0 font-weight-bold text-primary">2.- ¿CUAL ES EL NEGOCIO PRINCIPAL DE ODEBRETCH?</h6>
            </a>
            <div class="collapse show" id="collapseCardExample" style="">
                <div class="card-body">
                    <input type="radio" id="prg1" value="asd" name="rbprg2" />a- LA AGRICULTORA
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg2" />b- CONSTRUCCION
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg2" />c- PESCA
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg2" />d- VENTA DE INMUEBLES
                </div>
            </div>
        </div>

        <div class="card shadow mb-4 border-left-info">
            <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                <h6 class="m-0 font-weight-bold text-primary">3.- ¿COMO CORRUMPIO ODEBRETCH A LOS JEFES DE ESTADOS?</h6>
            </a>
            <div class="collapse show" id="collapseCardExample" style="">
                <div class="card-body">
                    <input type="radio" id="prg1" value="asd" name="rbprg3" />a- A TRAVES DE PUBLICIDAD
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg3" />b- CON PROYECTOS SOCIALES
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg3" />c- OFRECIENDO SOBORNOS POR LICITACIONES DE CONSTRUCCIONES IMPORTANTES
                    <br />
                    <input type="radio" id="prg1" value="asd" name="rbprg3" />d- OFRECIENDO DESARROLLO E INVESTIGACION A LAS UNIVERSIDADES DEL PAIS
                </div>
            </div>
        </div>

    </div>

    <div class="col-lg-12">
        <center>
            <a href="CategoriaCasos.aspx" class="btn btn-success btn-circle btn-lg" title="Guardar">
                    <i class="fas fa-check"></i>
            </a>
            <a href="CategoriaCasos.aspx" class="btn btn-danger btn-circle btn-lg" title="Cancelar">
                    <i class="fas fa-trash"></i>
                  </a>
        </center>
    </div>
</asp:Content>