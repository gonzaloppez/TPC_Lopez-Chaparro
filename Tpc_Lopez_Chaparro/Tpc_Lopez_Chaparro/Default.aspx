<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tpc_Lopez_Chaparro._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container-fluid" style="color: black" >
            <h1 style="font-size: 30px">TU CARTILLA ONLINE</h1>
            <p class="lead">Un sitio donde te sentás, seleccionas tu menú, pagás y esperás.... fácil y sin contacto</p>
            <p><a href="Menu" class="btn btn-primary btn-lg">Ir a Menu &raquo;</a></p>
        </div>
    
    


    <style>
        body {
             background-image: url(https://raw.githubusercontent.com/ChaparroAgustin/imagenes/main/online-res-18.png);
            width: 100%;
            height: 100vh;
             background-size:contain;
                }
        footer{
            margin-top: 50%;
            float: right;
            font-weight: bold;
        }
        
        h1{
            margin-top: 90px;
            font-size: 50px;
            font-weight: bold;    
        }

       
        
    </style>
    

</asp:Content>
