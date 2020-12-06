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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UserNegocio negocio = new UserNegocio();
            user.User = txtUser.Text;
            user.Pass = txtPass.Text;

            user = negocio.login(user);

            if (user.ID != 0)
                Response.Redirect("");
            else
            {
                Response.Redirect("login.aspx");
            }                
        }
    }
}