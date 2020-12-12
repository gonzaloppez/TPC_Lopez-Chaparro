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
    public partial class PruebaLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnIngresar(object sender, EventArgs e)
        {
            int auxID = 0;
            Usuario user = new Usuario();
            UserNegocio negocio = new UserNegocio();
            user.User = txtUser.Text;
            user.Pass = txtPass.Text;
            auxID = negocio.login(user);

            if (auxID != 0)
                Response.Redirect("AdministracionCocina");
                
            else
            {
                Response.Redirect("PruebaLogin.aspx");
            }
        }
    }
}