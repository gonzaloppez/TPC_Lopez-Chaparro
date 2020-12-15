using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Tpc_Lopez_Chaparro
{
    public partial class Administracion : System.Web.UI.Page
    {
        public string nombreUsuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string user = Convert.ToString(Session["usersession"]);
               if (user == " ") { 
                   Response.Redirect("PruebaLogin.aspx");
                }
               if (user != "Administrador")
               {
                   Session["Error" + Session.SessionID] = "El perfil" + user + "No tiene permisos para ver esta pagina";
                   Response.Redirect("PruebaLogin");
               }
                nombreUsuario = user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        protected void btnDesloguearse(object sender, EventArgs e)
        {
            Session["usersession"] = null;
            Response.Redirect("PruebaLogin");
        }
    }
}