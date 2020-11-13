<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaPlatos.aspx.cs" Inherits="Tpc_Lopez_Chaparro.CargaPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <div class="row">
            <h1>Agregar platos</h1>
        </div>
    </section>

    <section>
        <div class="col-md-12">  
                <asp:Label Text="Nombre" runat="server" />
            <asp:TextBox ID="txtNombre" runat="server" />
        </div>
        <div class="col-md-12">  
                <asp:Label Text="Precio" runat="server" />
            <asp:TextBox ID="txtPrecio" runat="server" />
        </div>
        <div class="col-md-12">  
                <asp:Label Text="IDTipo" runat="server" />
            <asp:TextBox ID="txtTipo" runat="server" />
        </div>
        <div class="col-md-12">  
                <asp:Label Text="Descripcion" runat="server" />
            <asp:TextBox ID="txtDescripcion" runat="server" /><br />
            <hr />
            <asp:Button href="/Menu" CssClass="btn btn-primary" Text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" runat="server" />
        </div>
        
   
             
        </section>

    <style>

.col-md-12{
    text-align: center;
}

.btn-primary{
    text-align: center;
}

    </style>

</asp:Content>
