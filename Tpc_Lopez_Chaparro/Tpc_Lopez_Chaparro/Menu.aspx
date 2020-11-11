<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Tpc_Lopez_Chaparro.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <section>
            <div>       
                <div class="row row-cols-1 row-cols-md-3">
                    <% foreach (Dominio.Carta item in listaCarta)
                        { %>
                    <div class="col mb-4">
                        <div class="card" style="width: 18rem;">
                            <div class="card">

                                <div class="card-body">
                                    <img src="https://gastromarketing.org/wp-content/uploads/2019/11/ingenieria-de-menus.jpg" class="card-img-top" alt="...">
                                    <h3 class="card-title"><% = item.Nombre %></h3>
                                    <h4 class="card-subtitle mb-2 text-muted"><% = "Precio: $" + item.Precio %></h4>
                                    <p class="card-text" ><% = "Descripcion:" + item.Descripcion %></p>
                                    <hr />

                                </div>


                            </div>
                        </div>
                    </div>

                    <%  } %>
                </div>
                </div>
           </section>




</asp:Content>

        