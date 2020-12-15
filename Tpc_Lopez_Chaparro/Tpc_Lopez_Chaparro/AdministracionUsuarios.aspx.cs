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
    public partial class AdministracionUsuarios : System.Web.UI.Page
    {
        public string nombreUsuario { get; set; }

        public List<Empleados> ListaUsuario { get; set; } //creamos lista de tipo carta

        protected void Page_Load(object sender, EventArgs e)
        {

            EmpleadosNegocio negocio = new EmpleadosNegocio(); //creamos objeto de tipo cartaNegocio
            try
            {
                string user = Convert.ToString(Session["usersession"]);
                if (user == " ")
                {
                    Response.Redirect("PruebaLogin.aspx");
                }
                if (user != "Administrador")
                {
                    Session["usersession"] = null;
                    Response.Redirect("PruebaLogin.aspx");
                }
                nombreUsuario = user;

                ListaUsuario = negocio.listar(); //le asignamos lo que devuelve listar

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
