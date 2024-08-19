<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Facun2._0.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!doctype html>
<html lang="en">
  <head>
  	<title>Login 05</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
	
	<link rel="stylesheet" href="EstilosLogin/css/Login.css">

	</head>
	<body style="paddin=0px">
	<section class="ftco-section">
		<div class="container">
        		<div class="row justify-content-center">
				<div class="col-md-6 text-center mb-5">
					<h2 class="heading-section">Login #05</h2>
				</div>
			</div>
			<div class="row justify-content-center">
				<div class="col-md-7 col-lg-5">
					<div class="wrap">
						<div class="img" style="background-image: url(Estilos/images/inst.png); "></div>
						<div class="login-wrap p-4 p-md-5">
			      	<div class="d-flex">
			      		<div class="w-100">
			      			<h3 class="mb-4">Sign In</h3>
			      		</div>
								<div class="w-100">
									<p class="social-media d-flex justify-content-end">
										<a href="#" class="social-icon d-flex align-items-center justify-content-center"><span class="fa fa-facebook"></span></a>
										<a href="#" class="social-icon d-flex align-items-center justify-content-center"><span class="fa fa-twitter"></span></a>
									</p>
								</div>
			      	</div>
							<form action="#" class="signin-form" runat="server">
			      		<div class="form-group mt-3">
                            <asp:Label ID="LabelUsuario" runat="server" Text="Usuario"></asp:Label>
			      			<%--<input type="text" class="form-control" required>--%>
                             <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
			      			<%--<label class="form-control-placeholder" for="username">Username</label>--%>
                            <asp:RequiredFieldValidator ID="rfvusuario" ControlToValidate="txtUsuario" runat="server"
                                 ErrorMessage="Debe ingresar nombre de usuario" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>

			      		</div>
		            <div class="form-group">
                     <asp:Label ID="LabelContraseña" runat="server" Text="Contraseña"></asp:Label>
		             <%-- <input id="password-field" type="password" class="form-control" required>--%>
		              <asp:TextBox ID="txtContraseña" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                      <asp:TextBox ID="txtContraseña2" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                      <%--<label class="form-control-placeholder" for="password">Contraseña</label>--%>
		              <span toggle="#password-field" class="fa fa-fw fa-eye field-icon toggle-password"></span>
                      <asp:RequiredFieldValidator ID="rfvContraseña" ErrorMessage="Debe ingresar Contraseña" 
                           ControlToValidate="txtContraseña" runat="server" Text="*" ForeColor="Red"/>
                      <asp:RequiredFieldValidator ID="rfvContraseña2" ErrorMessage="Debe repetir Contraseña" 
                           ControlToValidate="txtContraseña2" runat="server" Text="*" ForeColor="Red"/>
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas deben ser iguales"
                           ControlToValidate="txtContraseña" ControlToCompare="txtContraseña2" Text="*" ForeColor="Red"></asp:CompareValidator>
		            </div>

                    <div class="form-group">
                     <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
		             <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="form-control" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfvEmail" ErrorMessage="Debe ingresar Email" 
                           ControlToValidate="txtEmail" runat="server" Text="*" ForeColor="Red"/>
		            </div>

                    <div class="form-group">
                     <asp:Label ID="LabelDNI" runat="server" Text="DNI"></asp:Label>
		             <asp:TextBox ID="txtDNI" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfvDNI" ErrorMessage="Debe ingresar DNI" 
                           ControlToValidate="txtDNI" runat="server" Text="*" ForeColor="Red"/>
                     <asp:RangeValidator ID="rvDNI" MinimumValue="11111111" MaximumValue="99999999" Type="Integer" 
                     ControlToValidate="txtDNI" runat="server" ErrorMessage="Debe ingresar un DNI valido" Text="*" ForeColor="Red"></asp:RangeValidator>
		            </div>
                    
                    <div class="form-group">
		            	<%--<button type="submit" class="form-control btn btn-primary rounded submit px-3">Sign In</button>--%>
                        <asp:Button ID="btnLogin" CssClass="form-control btn btn-primary rounded submit px-3" runat="server" 
                            Text="Login" onclick="btnLogin_Click"></asp:Button>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
		            </div>
		            <div class="form-group d-md-flex">
		            	<div class="w-50 text-left">
			            	<label class="checkbox-wrap checkbox-primary mb-0">Remember Me
									  <input type="checkbox" checked>
									  <span class="checkmark"></span>
										</label>
									</div>
									<div class="w-50 text-md-right">
										<a href="#">Forgot Password</a>
									</div>
		            </div>
                    <asp:Label ID="lblTexto" runat="server" Text=""></asp:Label>
		          </form>
		          <p class="text-center">Not a member? <a data-toggle="tab" href="#signup">Sign Up</a></p>
		        </div>
		      </div>
				</div>
			</div>
		</div>
	</section>

	<script src="Estilos/js/jquery.min.js"></script>
  <script src="Estilos/js/popper.js"></script>
  <script src="Estilos/js/bootstrap.min.js"></script>
  <script src="Estilos/js/main.js"></script>

	</body>
</html>

