<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Account.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>¡Crea una cuenta!</title>

    <link href="../Utilitarios/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />
    <link href="../Utilitarios/css/plantilla/sb-admin-2.min.css" rel="stylesheet" />

</head>

<body class="bg-gradient-primary">

    <div class="container">

        <div class="card o-hidden border-0 shadow-lg my-5">
            <div class="card-body p-0">
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-5 d-none d-lg-block bg-register-image"></div>
                    <div class="col-lg-7">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">¡Crea una cuenta!</h1>
                            </div>
                            <form id="frmRegister" runat="server" class="user">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control form-control-user" placeholder="Nombres" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control form-control-user" placeholder="Apellidos" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control form-control-user" placeholder="Correo electrónico" TextMode="Email" />
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txtClave" runat="server" CssClass="form-control form-control-user" placeholder="Contraseña" TextMode="Password" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtClaveRepetir" runat="server" CssClass="form-control form-control-user" placeholder="Repetir contraseña" TextMode="Password" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:DropDownList ID="ddlBeneficio" runat="server" AppendDataBoundItems="true" Width="100%">
                                        <asp:ListItem Value="0">--- Seleccione Beneficio ---</asp:ListItem>
                                        <asp:ListItem Value="1">Descuentos en restaurantes</asp:ListItem>
                                        <asp:ListItem Value="2">Entradas dobles al cine</asp:ListItem>
                                        <asp:ListItem Value="3">Combos canjeables</asp:ListItem>
                                        <asp:ListItem Value="4">Glp gratis</asp:ListItem>
                                        <asp:ListItem Value="5">Cursos / becas</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Cuenta" CssClass="btn btn-primary btn-user btn-block" OnClick="btnRegistrar_Click" />
                                <%--<a href="Login.aspx" class="btn btn-primary btn-user btn-block">Registrar Cuenta</a>--%>
                                <hr />
                                <a href="../Default.aspx" class="btn btn-google btn-user btn-block">
                                    <i class="fab fa-google fa-fw"></i>Registrar con Google</a>
                                <a href="../Default.aspx" class="btn btn-facebook btn-user btn-block">
                                    <i class="fab fa-facebook-f fa-fw"></i>Registrar con Facebook</a>
                            
    <div id="DivBienvenida" runat="server" style="display: none;">
        <div style="-moz-box-sizing: border-box; -ms-text-size-adjust: 100%; -webkit-box-sizing: border-box; -webkit-text-size-adjust: 100%; margin: 0; background: #fff!important; box-sizing: border-box; color: #0a0a0a; font-family: Helvetica,Arial,sans-serif; font-size: 16px; font-weight: 400; line-height: 1; margin: 0; min-width: 100%; padding: 0; text-align: left; width: 100%!important">
            <span class="preheader" style="color: #fff; display: none!important; font-size: 1px; line-height: 1px; max-height: 0; max-width: 0; mso-hide: all!important; opacity: 0; overflow: hidden; visibility: hidden"></span>
            <table class="body" style="margin: 0; background: #fff!important; border-collapse: collapse; border-spacing: 0; color: #0a0a0a; font-family: Helvetica,Arial,sans-serif; font-size: 16px; font-weight: 400; height: 100%; line-height: 1; margin: 0; padding: 0; text-align: left; vertical-align: top; width: 100%">
                <tr style="padding: 0; text-align: left; vertical-align: top">
                    <td class="center" align="center" valign="top" style="-moz-hyphens: auto; -webkit-hyphens: auto; margin: 0; border-collapse: collapse!important; color: #0a0a0a; font-family: Helvetica,Arial,sans-serif; font-size: 16px; font-weight: 400; hyphens: auto; line-height: 1; margin: 0; padding: 0; text-align: left; vertical-align: top; word-wrap: break-word">
                        <center data-parsed="" style="min-width: 580px; width: 100%">

                        <table align="center" class="container float-center" style="Margin:0 auto;background:#fff;border-collapse:collapse;border-spacing:0;float:none;margin:0 auto;padding:0;text-align:center;vertical-align:top;width:580px">
                            <tbody>
                                <tr style="padding:0;text-align:left;vertical-align:top">
                                    <td style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:1;margin:0;padding:0;text-align:left;vertical-align:top;word-wrap:break-word">

                                        <table class="row header" style="background:#5d59ff;border-collapse:collapse;border-spacing:0;display:table;padding:0;position:relative;text-align:left;vertical-align:top;width:100%">
                                            <tbody>
                                                <tr style="padding:0;text-align:left;vertical-align:top">
                                                    <th class="small-12 large-12 columns first last" style="Margin:0 auto;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0 auto;padding:0;padding-bottom:0;padding-left:16px;padding-right:16px;text-align:left;width:564px">
                                                        <table style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%">
                                                            <tr style="padding:0;text-align:left;vertical-align:top">
                                                                <th style="Margin:0;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0;padding:0;text-align:left">

                                                                    <table class="spacer" style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%"><tbody><tr style="padding:0;text-align:left;vertical-align:top"><td height="16px" style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:16px;margin:0;mso-line-height-rule:exactly;padding:0;text-align:left;vertical-align:top;word-wrap:break-word">&#xA0;</td></tr></tbody></table>

                                                                    <h4 class="text-center" style="Margin:0;Margin-bottom:10px;color:inherit;font-family:Helvetica,Arial,sans-serif;font-size:24px;font-weight:400;line-height:1;margin:0;margin-bottom:10px;padding:0;text-align:center;word-wrap:normal;color:#fff;">¡Atención la corrupción es algo serio!</h4>
                                                                </th>
                                                                <th class="expander" style="Margin:0;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0;padding:0!important;text-align:left;visibility:hidden;width:0"></th>
                                                            </tr>
                                                        </table>
                                                    </th>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <table class="row" style="border-collapse:collapse;border-spacing:0;display:table;padding:0;position:relative;text-align:left;vertical-align:top;width:100%">
                                            <tbody>
                                                <tr style="padding:0;text-align:left;vertical-align:top">
                                                    <th class="small-12 large-12 columns first last" style="Margin:0 auto;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0 auto;padding:0;padding-bottom:16px;padding-left:16px;padding-right:16px;text-align:left;width:564px">
                                                        <table style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%">
                                                            <tr style="padding:0;text-align:left;vertical-align:top">
                                                                <th style="Margin:0;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0;padding:0;text-align:left">

                                                                    <table class="spacer" style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%"><tbody><tr style="padding:0;text-align:left;vertical-align:top"><td height="32px" style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:32px;font-weight:400;hyphens:auto;line-height:32px;margin:0;mso-line-height-rule:exactly;padding:0;text-align:left;vertical-align:top;word-wrap:break-word">&#xA0;</td></tr></tbody></table>

                                                                    <center data-parsed="" style="min-width:532px;width:100%">
                                                                        <img src="https://i.ibb.co/F63TJrp/logo.png" align="center" class="float-center" style="-ms-interpolation-mode:bicubic;Margin:0 auto;clear:both;display:block;float:none;margin:0 auto;max-width:100%;outline:0;text-align:center;text-decoration:none;width:auto" />
                                                                    </center>

                                                                    <table class="spacer" style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%"><tbody><tr style="padding:0;text-align:left;vertical-align:top"><td height="16px" style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:16px;margin:0;mso-line-height-rule:exactly;padding:0;text-align:left;vertical-align:top;word-wrap:break-word">&#xA0;</td></tr></tbody></table>

                                                                    <h1 class="text-center" style="Margin:0;Margin-bottom:10px;color:inherit;font-family:Helvetica,Arial,sans-serif;font-size:34px;font-weight:400;line-height:1;margin:0;margin-bottom:10px;padding:0;text-align:center;word-wrap:normal; color:#5d59ff;"><b>¡Bienvenido!</b></h1>

                                                                    <table class="spacer" style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%"><tbody><tr style="padding:0;text-align:left;vertical-align:top"><td height="16px" style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:16px;margin:0;mso-line-height-rule:exactly;padding:0;text-align:left;vertical-align:top;word-wrap:break-word">&#xA0;</td></tr></tbody></table>

                                                                    <p class="text-center" style="Margin:0;Margin-bottom:10px;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0;margin-bottom:10px;padding:0;text-align:center"><b>Ya estas listo para aprender y jugar.</b> </p>
                                                                    <table class="button large expand" style="Margin:0 0 16px 0;border-collapse:collapse;border-spacing:0;margin:0 0 16px 0;padding:0;text-align:left;vertical-align:top;width:100%!important">
                                                                        <tr style="padding:0;text-align:left;vertical-align:top">
                                                                            <td style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:1;margin:0;padding:0;text-align:left;vertical-align:top;word-wrap:break-word"><table style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%"><tr style="padding:0;text-align:left;vertical-align:top"><td style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;background:#fff;border:2px solid #fff;border-collapse:collapse!important;color:#bf1a1e;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:1;margin:0;padding:0;text-align:left;vertical-align:top;word-wrap:break-word"><center data-parsed="" style="min-width:0;width:100%"><a href="#" align="center" class="float-center" style="Margin:0;border:0 solid #fff;border-radius:3px;color:#FF0000;display:inline-block;font-family:Helvetica,Arial,sans-serif;font-size:20px;font-weight:700;line-height:1;margin:0;padding:5px 25px 5px 25px;padding-left:0;padding-right:0;text-align:center;text-decoration:none;width:100%">Empezar</a></center></td></tr></table></td>
                                                                            <td class="expander" style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:1;margin:0;padding:0!important;text-align:left;vertical-align:top;visibility:hidden;width:0;word-wrap:break-word"></td>
                                                                        </tr>
                                                                    </table>

                                                                    <hr />

                                                                    <p style="Margin:0;Margin-bottom:10px;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0;margin-bottom:10px;padding:0;text-align:left"><small style="color:#cacaca;font-size:80%">Nuestro objetivo es concientizar a la sociedad acerca de los problemas que la corrupción nos ha traido a lo largo de la historia. <a href="#" style="Margin:0;color:#fff;font-family:Helvetica,Arial,sans-serif;font-weight:400;line-height:1;margin:0;padding:0;text-align:left;text-decoration:none">unsubscribe here</a>.</small></p>
                                                                </th>
                                                                <th class="expander" style="Margin:0;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1;margin:0;padding:0!important;text-align:left;visibility:hidden;width:0"></th>
                                                            </tr>
                                                        </table>
                                                    </th>
                                                </tr>
                                            </tbody>
                                        </table>

                                        <table class="spacer" style="border-collapse:collapse;border-spacing:0;padding:0;text-align:left;vertical-align:top;width:100%"><tbody><tr style="padding:0;text-align:left;vertical-align:top"><td height="16px" style="-moz-hyphens:auto;-webkit-hyphens:auto;Margin:0;border-collapse:collapse!important;color:#0a0a0a;font-family:Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;hyphens:auto;line-height:16px;margin:0;mso-line-height-rule:exactly;padding:0;text-align:left;vertical-align:top;word-wrap:break-word">&#xA0;</td></tr></tbody></table>
                                    </td>
                                </tr>
                            </tbody>
                        </table>

                    </center>
                    </td>
                </tr>
            </table>
            <!-- prevent Gmail on iOS font size manipulation -->
            <div style="display: none; white-space: nowrap; font: 15px courier; line-height: 0">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            </div>
        </div>
    </div>

                            </form>
                            <hr />
                            <div class="text-center">
                                <a class="small" href="ForgotPassword.aspx">¿Olvide la contraseña?</a>
                            </div>
                            <div class="text-center">
                                <a class="small" href="Login.aspx">¿Ya tienes una cuenta? ¡Iniciar sesión!</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <script src="../Utilitarios/jquery/jquery.min.js"></script>
    <script src="../Utilitarios/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../Utilitarios/jquery-easing/jquery.easing.min.js"></script>
    <script src="../Utilitarios/js/plantilla/sb-admin-2.min.js"></script>

</body>

</html>