using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Text;

namespace Tpc_Lopez_Chaparro
{
    public partial class PruebaLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Convert.ToString(Session["usersession"]);
            if (user == " ")
            {
                Response.Redirect("PruebaLogin.aspx");
            }
            if (user == "Administrador")
            {
                Response.Redirect("Administracion.aspx");
            }
            if (user == "Mozo" || user == "Cocina")
            {
                Response.Redirect("AdministracionCocina.aspx");
            }

        }

        protected void btnIngresar(object sender, EventArgs e)
        {
            
            Usuario usuario = new Usuario();
            UserNegocio negocio = new UserNegocio();
            string user = txtUser.Text;
            //string pass = txtPass.Text;
            user = negocio.login(user);

            if (user == "Administrador") {
                Session.Add("usersession", user);
                Response.Redirect("Administracion.aspx");
                
            }
            if (user == "Cocina" || user == "Mozo" )
            {
                Session.Add("usersession", user);
                Response.Redirect("AdministracionCocina.aspx");

            }
            else
            {
                Session["Error" + Session.SessionID] = "Usuario o pass incorrectos";
                Response.Redirect("PruebaLogin.aspx");
            }
        }
    }
}