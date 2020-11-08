<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Tpc_Lopez_Chaparro.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <section>
            <div>       
            
                <% foreach (Dominio.Carta item in listaCarta)
            { %>
                    <div class="col-md-12">
                        <div class="card">
                            
                            <div class="content">
                                <h3><% = item.Nombre %></h3>
                                <h4><% = "Precio: $" + item.Precio %></h4>
                                <h5><% = "Descripcion:" + item.Descripcion  %></h5>
                                <hr />
                                
                            </div>
                                
                           
                        </div>
                         </div>                      
            
           <%  } %>
                    
                </div>
           </section>




</asp:Content>

        