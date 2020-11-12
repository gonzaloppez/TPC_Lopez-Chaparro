<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Tpc_Lopez_Chaparro.Administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
    <div class="col-md-12 centrado">
        <h1>Secciones</h1>
        <h2>Ingrese a la sección que desee</h2>
            <hr/>
    </div>
        </div>
    
                        

    <div class="row">
        <div class="col-md-3">
            <div class="card">
                <div class="pic">
                    <a class="btn-primary" href="#">
                        <img src="Content/Platos.jpg"" class="img"/>
                    </a>
                  </div>
                <div class="content">
                    <h2>Platos</h2>
                </div>
            </div>
        </div>


        <div class="col-md-3">
            <div class="card">
                <div class="pic">
                    <a class="btn-primary" href="#"><img src="Content/Bebida.jpg" class="img" /></a>
                    <div class="content">
                        <h2>Bebidas</h2>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-md-3">
            <div class="card">
                <div class="pic">
                  <a class="btn-primary" href="#">  <img src="Content/Promociones.jpg" class="img"  alt="" /></a>
               <div class="content">
                        <h2>Promociones</h2>
                    </div>
                    </div>
            </div>
        </div>

        <div class="col-md-3">
            <div class="card">
                <div class="pic">
                  <a class="btn-primary" href="#">  <img src="Content/user.png" class="img"  alt="" /></a>
               <div class="content">
                        <h2>Usuarios</h2>
                    </div>
                    </div>
            </div>
        </div>
        </div>
    <style>

.card{
    border-style: none;
    padding:0px;
    
}

.content{
    padding: 10px;
}

.centrado{
    text-align: center;
}

.img{
    width: 250px;
    height: 250px;
    object-fit: cover;
    max-height: 200px;
    max-height: 200px;
}

    </style>

</asp:Content>
