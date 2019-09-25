<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/LayoutPrincipal.master" AutoEventWireup="true" CodeBehind="EjecutarCaso.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Educativo.EjecutarCaso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

       <div class="container-fluid py-3 h-100">
        <div class="hacks">
            <div class="row no-gutters arrows">
                <div class="col d-flex justify-content-start">
                    <div class="action back-arrow text-left">
                        <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg"
                            xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 31.494 31.494"
                            style="enable-background:new 0 0 31.494 31.494;" xml:space="preserve">
                            <path style="fill:#fff;"
                                d="M10.273,5.009c0.444-0.444,1.143-0.444,1.587,0c0.429,0.429,0.429,1.143,0,1.571l-8.047,8.047h26.554
                           c0.619,0,1.127,0.492,1.127,1.111c0,0.619-0.508,1.127-1.127,1.127H3.813l8.047,8.032c0.429,0.444,0.429,1.159,0,1.587
                           c-0.444,0.444-1.143,0.444-1.587,0l-9.952-9.952c-0.429-0.429-0.429-1.143,0-1.571L10.273,5.009z" />
                            <g>
                        </svg>

                    </div>
                </div>
                <div class="col d-flex justify-content-center d-none">
                    <div class="action back-arrow text-left d-none">
                        <span class="text-white">1/5</span>
                    </div>
                </div>
                <div class="col d-flex justify-content-end">
                    <div class="action close-arrow text-right">
                        <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg"
                            xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 22.88 22.88"
                            style="enable-background:new 0 0 22.88 22.88;" xml:space="preserve">
                            <path style="fill:#fff;" d="M0.324,1.909c-0.429-0.429-0.429-1.143,0-1.587c0.444-0.429,1.143-0.429,1.587,0l9.523,9.539
                           l9.539-9.539c0.429-0.429,1.143-0.429,1.571,0c0.444,0.444,0.444,1.159,0,1.587l-9.523,9.524l9.523,9.539
                           c0.444,0.429,0.444,1.143,0,1.587c-0.429,0.429-1.143,0.429-1.571,0l-9.539-9.539l-9.523,9.539c-0.444,0.429-1.143,0.429-1.587,0
                           c-0.429-0.444-0.429-1.159,0-1.587l9.523-9.539L0.324,1.909z" />
                            <g>
                        </svg>

                    </div>
                </div>
            </div>
            <!-- Row 1 -->
            <div class="row no-gutters">
                <div class="col d-flex flex-column justify-content-center py-3">
                    <div class="title  text-white"> <span>¡Bien! ahora escoge una categoria</span></div>
                </div>
            </div>
            <div class="row no-gutters">
                <div class="col text-center category d-flex justify-content-center px-1">
                    <div class="cards mid bg-white">
                        <div class="description bold colorBlue p-2">
                            <a href="../Educativo/Categoria1.aspx"><span>Caso Odebretch</span></a>
                            
                        </div>
                    </div>
                </div>
                <div class="col text-center category d-flex justify-content-center px-1">
                    <div class="cards mid bg-white">
                        <div class="description bold colorBlue p-2">
                            <a href="../Educativo/Categoria2.aspx"><span>Caso Lava Jato </span></a>
                            
                        </div>
                    </div>
                </div>
            </div>
            <!-- Row 2 -->
            <div class="row no-gutters">
                <div class="col text-center category d-flex justify-content-center px-1">
                    <div class="cards mid bg-white">
                        <div class="description bold colorBlue p-2">
                            <a href="../Educativo/Categoria3.aspx"><span>Caso Lava Jato </span></a>
                        </div>
                    </div>
                </div>
                <div class="col text-center category d-flex justify-content-center px-1">
                    <div class="cards mid bg-white">
                        <div class="description bold colorBlue p-2">
                            <a href="../Educativo/Categoria4.aspx"><span>Caso Lava Jato </span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>