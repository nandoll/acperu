<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/LayoutPrincipal.master" AutoEventWireup="true" CodeBehind="Noticia.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Comunidad.Noticia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <div class="col-lg-12">
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Noticias</h1>
        </div>
    </div>

    <div class="col-lg-12" id="DivNoticias" runat="server">

        <div class="card shadow mb-4 border-left-info">
            <a href="#IdCorrelativo" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                <h6 class="m-0 font-weight-bold text-primary">[[Titulo]]</h6>
            </a>
            <div class="collapse show" id="IdCorrelativo" style="">
                <div class="card-body">
                    [[Contenido]]
                </div>
            </div>
        </div>

    </div>

    <%--<div class="col-lg-12">

        <div class="card shadow mb-4 border-left-info">
            <!-- Card Header - Dropdown -->
            <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                <h6 class="m-0 font-weight-bold text-primary">Habilitan línea gratuita para denunciar actos de corrupción en sector educativo</h6>
                <div class="dropdown no-arrow">
                    <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <i class="fas fa-ellipsis-v fa-sm fa-fw text-gray-400"></i>
                    </a>
                    <div class="dropdown-menu dropdown-menu-right shadow animated--fade-in" aria-labelledby="dropdownMenuLink" x-placement="bottom-end" style="position: absolute; will-change: transform; top: 0px; left: 0px; transform: translate3d(17px, 18px, 0px);">
                        <div class="dropdown-header">Acciones:</div>
                        <a class="dropdown-item" href="#">Compartir</a>
                        <a class="dropdown-item" href="#">Compartir</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="#">Eliminar</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class="card-body">
                Minedu insta a la sociedad a denunciar cualquier hecho de corrupción que noten en el sector mediante un correo electrónico. Identidad de denunciantes se mantendrá en reserva, informaron.
                <br />
                <br />
                A fin de luchar contra la corrupción, el viceministro de Gestión Institucional del Ministerio de Educación (Minedu), Guido Rospigliosi, informó se ha habilitado una línea gratuita que acoja denuncias anónimas de hechos indebidos que puedan suceder en el sector.
            </div>
        </div>

        <div class="card shadow mb-4 border-left-info">
            <!-- Card Header - Accordion -->
            <a href="#collapseCardExample" class="d-block card-header py-3" data-toggle="collapse" role="button" aria-expanded="true" aria-controls="collapseCardExample">
                <h6 class="m-0 font-weight-bold text-primary">Desaceleración y corrupción, por Juan José Marthans</h6>
            </a>
            <!-- Card Content - Collapse -->
            <div class="collapse show" id="collapseCardExample" style="">
                <div class="card-body">
                    “El anuncio del adelanto de elecciones es una causal menor frente a las pugnas de los tres últimos años”, señala Marthans, economista del PAD-Escuela de Dirección Universidad de Piura
                    <br />
                    <br />
                    Usualmente se consideran tres elementos para explicar la desaceleración de nuestra actividad productiva e inversión: la descomposición comercial y financiera internacional, las pugnas entre nuestro Legislativo-Ejecutivo y la inadecuada pericia en materia de política económica. El tema de la corrupción se camufla o se trata tangencialmente. Permítanme compartir breves reflexiones sobre las reales causales de la desaceleración. 
                </div>
            </div>
        </div>

    </div>
        --%>

</asp:Content>