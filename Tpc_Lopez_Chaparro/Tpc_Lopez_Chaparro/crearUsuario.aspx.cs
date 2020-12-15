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
    public partial class crearUsuario : System.Web.UI.Page
    {
        public string nombreUsuario { get; set; }

        public Empleados EmpleadoAdmin{ get; set; }
        private Usuario usuarios = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            EmpleadosNegocio empleadoAuxiliar = new EmpleadosNegocio();
            List<Empleados> listadoAux;

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

                listadoAux = empleadoAuxiliar.listar();
                int IdAux = Convert.ToInt16(Request.QueryString["IDuser"]);
                EmpleadoAdmin = listadoAux.Find(us => us.ID == IdAux);
                txtIDEmpleado.Text = Convert.ToString(IdAux);


            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnCrearUsuario(object sender, EventArgs e)
        {
            UserNegocio negocio = new UserNegocio();
            if (usuarios == null)
            {
                usuarios = new Usuario();

            }
            
            usuarios.ID = Convert.ToInt16(txtIDEmpleado.Text);
            usuarios.User = txtNombreUsuario.Text;
            usuarios.Pass = txtContraseña.Text;
            usuarios.Perfil = ddlTipo.Text;
            negocio.agregar(usuarios);
            Response.Redirect("AdministracionUsuarios");

        }

        protected void btnDesloguearse(object sender, EventArgs e)
        {
            Session["usersession"] = null;
            Response.Redirect("PruebaLogin");
        }
    }
             
    }
