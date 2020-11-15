<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarPlato.aspx.cs" Inherits="Tpc_Lopez_Chaparro.ModificarPlato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<html lang="en" >

<head>
  <meta charset="UTF-8">
  <title>Login</title>
	<link href='https://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
	<link rel="stylesheet" href="css/style.css">

  </head>

<body>
<header>
	<img  class="logo" src="Content/Logo.png"> 
	    <div class="col-md-12">
			<div class="container">
			    <div class="jumbotron-fluid">
				    <h1 class="display-4"><% = CartaModificar.Nombre%></h1>
			        <p class="lead">Precio Unitario: <% = CartaModificar.Precio %></p>
			        <p class="lead">Descripcion: <% = CartaModificar.Descripcion%></p>
					<asp:Button href="" Text="EliminarPlato" ID="Button2" OnClick="btnEliminar_Click" runat="server" />
					<hr class="my-4">
			        <p class="lead">
			        </p>
			    </div>
			</div>
		</div>


    <div class="row">
        <div class="col-md-12">  
                <asp:Label Text="Nombre" runat="server" />
            <asp:TextBox ID="txtnombre" runat="server" />
        </div>
		
		<div class="col-md-12">  
                <asp:Label Text="Precio" runat="server" />
            <asp:TextBox ID="txtprecio" runat="server" />
        </div>

		<div class="col-md-12">  
                <asp:Label Text="Descripcion" runat="server" />
            <asp:TextBox ID="txtdescripcion" runat="server" />
        </div>

        <asp:Button href="" Text="Modificar" ID="btnModificar" OnClick="btnModificar_Click" runat="server" />

		</div>
		
        
                

	<div class="nav-modal">
		<div class="blob"></div>

		<nav>
			<ul>
				<li><a href="/Prueba">HOME</a>
					
				</li>
				<li><a href="/PruebaCarta">Carta</a>
					
				</li>
				<li><a href="#">Nosotros</a></li>
				<li><a href="#">Contacto</a>
				</li>
				<li><a href="/pruebaLogin">Log In</a></li>
				
			</ul>

		</nav>
	</div>


	<div class="head">
		<a href="#" class="tile socialmedia"><i class="fa fa-facebook-official"></i></a>
		<a href="#" class="tile socialmedia"><i class="fa fa-instagram"></i></a>
		<a href="#" class="tile socialmedia"><i class="fa fa-twitter-square"></i></a>

		<div class="tile burger">

			<div class="meat">
				<div class="line one"></div>
				<div class="line two"></div>
				<div class="line three"></div>


			</div>

		</div>
	</div>

	 

</header>

  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

<br />
	
           

</body>

</html>


<style>


.container{

	text-align:center;
}

.body {
    margin: 0;
    padding: 0;
    font-family: sans-serif;
    background: white;
	
}

.card{
	border: none;
}

.box {
    width: 500px;
    padding: 40px;
    position: absolute;
    top: 100%;
    left: 55%;
    background: ;
    text-align: center;
    transition: 0.25s;
    margin-top: 10px
}

.btn-primary{
    border-radius: 24px;
    color: white;
}

.btn-primary:hover{
    background: white;
    border-radius: 24px;
    color: black;
}

.box input[type="text"],
.box input[type="password"] {
    border: 0;
    background: none;
    display: block;
    margin: 20px auto;
    text-align: center;
    border: 2px solid #3498db;
    padding: 10px 10px;
    width: 250px;
    outline: none;
    color: black;
    border-radius: 24px;
    transition: 0.25s
}

.box h1 {
    color: black;
    text-transform: uppercase;
    font-weight: 500
}

.box input[type="text"]:focus,
.box input[type="password"]:focus {
    width: 300px;
    border-color: #2ecc71
}

.box input[type="submit"] {
    border: 0;
    background: none;
    display: block;
    margin: 20px auto;
    text-align: center;
    border: 2px solid #2ecc71;
    padding: 14px 40px;
    outline: none;
    color: black;
    border-radius: 24px;
    transition: 0.25s;
    cursor: pointer
}

.box input[type="submit"]:hover {
    background: #2ecc71;
    color: white;
}

.forgot {
    text-decoration: underline
}

ul.social-network {
    list-style: none;
    display: inline;
    margin-left: 0 !important;
    padding: 0
}

ul.social-network li {
    display: inline;
    margin: 0 5px
}

.social-network a.icoFacebook:hover {
    background-color: #3B5998
}

.social-network a.icoTwitter:hover {
    background-color: #33ccff
}

.social-network a.icoGoogle:hover {
    background-color: #BD3518
}

.social-network a.icoFacebook:hover i,
.social-network a.icoTwitter:hover i,
.social-network a.icoGoogle:hover i {
    color: #fff
}

a.socialIcon:hover,
.socialHoverClass {
    color: #44BCDD
}

.social-circle li a {
    display: inline-block;
    position: relative;
    margin: 0 auto 0 auto;
    border-radius: 50%;
    text-align: center;
    width: 50px;
    height: 50px;
    font-size: 20px
}

.social-circle li i {
    margin: 0;
    line-height: 50px;
    text-align: center
}

.social-circle li a:hover i,
.triggeredHover {
    transform: rotate(360deg);
    transition: all 0.2s
}

.social-circle i {
    color: #fff;
    transition: all 0.8s;
    transition: all 0.8s
}
    
header *{
	box-sizing: border-box;
	margin: 0;
	padding: 0;
}

header{
	height: 120px;
	width: 100%;
	position: relative;
	background-color: white;
	box-shadow: 0px 2px 5px rgba(0,0,0,.4);
}
.logo{
	width: 170px;
	display: block;
	margin: 0 auto;
	object-fit: cover;
	padding-top: 1px;
	
}
.head{
	position: absolute;
	top: 35px;
	right: 50px;
}
.head .tile{
	display: inline-block;
	height: 50px;
	width: 50px;
	margin-left: 5px;
	transition: all .3s ease-in;
	-webkit-transition: all .3s ease-in;
}
.head .tile.socialmedia{
	color: #0b253e;
	font-size: 50px;
	text-align: center;
	line-height: 50px;
	position: relative;
	top: -6px;
}
header.clicked .head .tile.socialmedia{
	color: white;
}
.head .burger{
	margin-left: 25px;
	padding: 5px;
	cursor: pointer;
	background-color: transparent;
}
.meat{
	height: 40px;
	width: 40px;
	position: relative;
	transition: all .3s ease-in;
	-webkit-transition: all .3s ease-in;
}
header.clicked .head .burger .meat{
	transform: rotate(180deg);
	-webkit-transform: rotate(180deg);
}
.meat .line{
	height: 4px;
	width: 40px;
	background-color: #0b253e;
	border-radius: 3px;
	position: absolute;
	transition: all .3s ease-in;
	-webkit-transition: all .3s ease-in;
}
.meat .line.one{top: 5px; left: 0px;}
.meat .line.two{top: 18px; left: 0px;}
.meat .line.three{top: 31px; left: 0px;}

header.clicked .burger .line{
	background-color: white;
}
header.clicked .burger .line.one{
	transform: rotate(45deg);
	-webkit-transform: rotate(45deg);
	top: 18px;
}
header.clicked .burger .line.two{
	transform: rotate(-45deg);
	-webkit-transform: rotate(-45deg);
	top: 18px;
}
header.clicked .burger .line.three{
	opacity: 0;
}
header.clicked .burger:hover .meat{
	transform: rotate(270deg);
	-webkit-transform: rotate(270deg);
}

.nav-modal{
	position: fixed;
	top: 0px;
	left: 0px;
	width: 100%;
	height: 100vh;
	visibility: hidden;
	opacity: 0;
	transition: all .3s ease-in;
	-webkit-transition: all .3s ease-in;
	pointer-events: none;
}
header.clicked .nav-modal{
	visibility: visible;
	opacity: 1;
	pointer-events: initial;
}


.nav-modal .blob{
	display: block;
	width: 10px;
	height: 10px;
	border-radius: 100%;
	margin: 0 auto;
	background-color: #0b253e;
	position: absolute;
	top: 50%;
	transform: translateY(-50%);
	-webkit-transform: translateY(-50%);
	transition: all .3s ease-in;
	
}
header.clicked .nav-modal .blob{
	width: 100vw;
	height: 100vh;
	border-radius: 0px;
}

nav{
	position: fixed;
	left: 20%;
	top: 30%;
	color: white;
}
nav a{
	color: white;
	text-decoration: none;
	font-family: sans-serif;
	font-family: 'Oswald', sans-serif;
	font-size: 30px;
}
nav ul li{
	list-style: none;
	text-align: right;
	border-right: 6px solid white;
	padding-bottom: 10px;
	padding-right: 10px;
	position: relative;
}
nav{
	opacity: 0;
	transition: all .3s ease-in;
	-webkit-transition: all .3s ease-in;
	-webkit-transition-delay: .3s;
	-moz-transition-delay: .3s;
	-o-transition-delay: .3s;
	transition-delay: .3s;
}
header.clicked nav{
	opacity: 1;
}

nav ul li ul{
	position: absolute;
	right: -300px;
	top: -4px;
	display: none;
}
nav ul li ul li{
	border: none;
	padding-bottom: 10px;
	padding-left: 10px;
	height: 50px;
	width: 300px;
}
nav ul li ul li a{
	display: block;
	height: 50px;
	font-size: 20px;
	text-align: left;
	padding: 10px;
}
nav ul li.selected ul{
	display: block;
}

nav ul li.notselected a{
	opacity: .5;
}
nav ul li.selected ul li a{
	opacity: 1;
}

@media screen and (max-width:820px){
	.logo{margin-left: 50px;}
}
@media screen and (max-width:580px){
	.logo{width: 130px; padding-top: 30px;}
	nav ul li a{
		font-size: 16px;
	}
	nav ul li ul{
		top: -9px;
	}
	nav ul li ul li{
		height: 40px;
	}
	nav ul li ul li a{
		font-size: 16px;
		height: 40px;
	}
}

}
@media screen and (max-width:320px){
	header .head .tile.socialmedia{
		display: none;
	}
}

</style>

<script>

    $(document).ready(function () {

        $('.burger').click(function () {
            $('header').toggleClass('clicked');
        });

        $('nav ul li').click(function () {
            $('nav ul li').removeClass('selected');
            $('nav ul li').addClass('notselected');
            $(this).toggleClass('selected');
            $(this).removeClass('notselected');
        });

    });
</script>

	</asp:Content>
