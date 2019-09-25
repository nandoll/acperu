<%@ Page Language="C#" MasterPageFile="~/MasterPage/LayoutPrincipal.master" AutoEventWireup="true" CodeBehind="Categoria1.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Educativo.Categoria1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="container-fluid py-3">
        <div class="hacks">
            
            <div class="container-sections">
                <section class="qwerty">
                    <header class="row no-gutters">
                        <div class="col d-flex flex-column justify-content-center py-2">
                            <div class="title  text-white"> <span>Lee atentamente</span></div>
                        </div>
                    </header>
                    <section class="row no-gutters">
                        <div class="col category d-flex justify-content-center carruselOfQuestions">
                            <div class="cards mid bg-white ">
                                <article class="description bold colorBlue p-2 ">
                                    Odebrecht es un conglomerado brasileño dedicado a los rubros de ingeniería y
                                    construcción, también se dedica a la manufactura de productos químicos y
                                    petroquímicos.
                                    Nació en 1944, esta compañía logró estar presente en Sudamérica, América Central,
                                    las
                                    Antillas, Norteamérica, África, Europa y el Medio Oriente.
                                </article>
                            </div>
                            <div class="cards mid bg-white ">
                                <article class="description bold colorBlue p-2 ">
                                    Durante los primeros meses de 2016, en el marco de la investigación del caso Lava
                                    Jato
                                    la justicia brasileña emitió ordenes judiciales contra varios de sus ejecutivos.
                                </article>
                            </div>
                            <div class="cards mid bg-white ">
                                <article class="description bold colorBlue p-2 ">

                                    Meses después, el 21 de diciembre, el Departamento de Justicia de Estados Unidos
                                    publicó una investigación en la que se detallaba que Odebrecht pagó coimas por 788
                                    millones de dólares a funcionarios gubernamentales en 12 países, incluyendo Perú,
                                    Venezuela, Ecuador, Angola Argentina, Colombia, Guatemala, México, Panamá y
                                    República
                                    Dominicana. La empresa reconoció esta información.
                                </article>
                            </div>
                        </div>
                    </section>

                    <nav class="row no-gutters carruselControl mb-4">
                        <div class="col d-flex justify-content-start">
                            <div class="prev"> <div class="triangle left"></div> </div> 
                        </div> 
                        <div class="col d-flex justify-content-center">
                            <span class="text-white">1/5</span>
                        </div>
                        <div class="col d-flex justify-content-end">
                            <div class="next"> <div class="triangle"></div></div>
                        </div>
                    </nav>

                    <div class="carruselOfSections">
                        <section class="Pregunta_1">
                        <header class="row no-gutters">
                            <div class="col text-center category d-flex justify-content-center ">
                                <div class="cards mid background-black noHeight">
                                    <div class="description bold text-white p-2">
                                        <span>¿Cómo así se conoce la reciente información de sobornos en el Perú?</span>
                                    </div>
                                </div>
                            </div>
                        </header>
                        <div class="answers">
                            <div class="answer">
                                <input type="radio" name="answer_1" id="1_a" value="1_a">
                                <label for="1_a">a) La información revelada por la justicia de EE.UU. es parte de un
                                    sistema de
                                    colaboración</label>
                            </div>

                            <div class="answer">
                                <input type="radio" name="answer_1" id="1_b" value="1_b">
                                <label for="1_b">b) La fiscalía realiza cuatro investigaciones sobre el Caso Lava Jato
                                </label>
                            </div>
                            <div class="answer">
                                <input type="radio" name="answer_1" id="1_c" value="1_c">
                                <label for="1_c">c) El tramo IV de la Interoceánica (2005),
                                </label>
                            </div>
                            <div class="answer">
                                <input type="radio" name="answer_1" id="1_d" value="1_d">
                                <label for="1_d">d) El gobierno peruano se ha indicado que se realizan coordinaciones
                                </label>
                            </div>
                            <div class="answer">
                                <input type="radio" name="answer_1" id="1_e" value="1_e">
                                <label for="1_e">e) El Comercio pudo conocer la Unidad de Cooperación Internacional
                                </label>
                            </div>
                        </div>
                    </section>
                    <section class="Pregunta_2">
                        <header class="row no-gutters">
                            <div class="col text-center category d-flex justify-content-center ">
                                <div class="cards mid background-black noHeight">
                                    <div class="description bold text-white p-2">
                                        <span>¿A qué casos en el Perú se refiere el informe sobre sobornos?</span>
                                    </div>
                                </div>
                            </div>
                        </header>
                        <div class="answers">
                            <div class="answer">
                                <input type="radio" name="answer_2" id="2_a" value="2_a">
                                <label for="2_a">a) El informe de la justicia estadounidense señala que Odebrecht pagó coimas</label>
                            </div>

                            <div class="answer">
                                <input type="radio" name="answer_2" id="2_b" value="2_b">
                                <label for="2_b">b) La fiscalía realiza cuatro investigaciones sobre el Caso Lava Jato
                                </label>
                            </div>
                            <div class="answer">
                                <input type="radio" name="answer_2" id="2_c" value="2_c">
                                <label for="2_c">c) c) El tramo IV de la Interoceánica (2005)</label>
                            </div>
                            <div class="answer">
                                <input type="radio" name="answer_2" id="2_d" value="2_d">
                                <label for="2_d">d) El gobierno peruano se ha indicado que se realizan coordinaciones
                                </label>
                            </div>
                            <div class="answer">
                                <input type="radio" name="answer_2" id="2_e" value="2_e">
                                <label for="2_e">e) El Comercio pudo conocer la Unidad de Cooperación Internacional </label>
                            </div>
                        </div>
                    </section>
                    </div>
                    
                </section>

                
            </div>
            
        </div>
    </div>    
</asp:Content>

