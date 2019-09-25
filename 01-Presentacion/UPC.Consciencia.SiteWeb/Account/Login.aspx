<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>Bienvenido !!!</title>

    <link href="../Utilitarios/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />
    <link href="../Utilitarios/css/plantilla/sb-admin-2.min.css" rel="stylesheet" />
    
</head>

<body class="bg-gradient-primary">

    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Bienvenido!</h1>
                                    </div>
                                    <form id="frmLogin" runat="server" class="user">
                                        <div class="form-group">
                                            <input type="email" class="form-control form-control-user" id="exampleInputEmail" aria-describedby="emailHelp" placeholder="Correo electrónico" />
                                        </div>
                                        <div class="form-group">
                                            <input type="password" class="form-control form-control-user" id="exampleInputPassword" placeholder="Contraseña" />
                                        </div>
                                        <%--<div class="form-group">
                                            <div class="custom-control custom-checkbox small">
                                                <input type="checkbox" class="custom-control-input" id="customCheck" />
                                                <label class="custom-control-label" for="customCheck">Remember Me</label>
                                            </div>
                                        </div>--%>
                                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary btn-user btn-block" OnClick="btnIngresar_Click" />
                                        <hr />
                                        <a href="index.html" class="btn btn-google btn-user btn-block">
                                            <i class="fab fa-google fa-fw"></i>Ingresar con Google</a>
                                        <a href="index.html" class="btn btn-facebook btn-user btn-block">
                                            <i class="fab fa-facebook-f fa-fw"></i>Ingresar con Facebook</a>
                                    </form>
                                    <hr />
                                    <div class="text-center">
                                        <a class="small" href="ForgotPassword.aspx">¿Olvide la contraseña?</a>
                                    </div>
                                    <div class="text-center">
                                        <a class="small" href="Register.aspx">¡Crea una cuenta!</a>
                                    </div>
                                </div>
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