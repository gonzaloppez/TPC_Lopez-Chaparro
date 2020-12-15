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
    public partial class CargaUsuario : System.Web.UI.Page
    {
        private Empleados empleados = null;
        public string nombreUsuario { get; set; }

        private Usuario usuario = null;

        protected void Page_Load(object sender, EventArgs e)
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

            txtLegajo.Text = BuscarUltimoLegajo();

        }
        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            EmpleadosNegocio negocio1 = new EmpleadosNegocio();
            if (empleados == null)
            {
                empleados = new Empleados();
                
            }

            empleados.Nombre = txtNombre.Text;
            empleados.Apellido = txtApellido.Text;
            empleados.DNI = txtDNI.Text;
            empleados.estado = true;
            empleados.Legajo = Convert.ToInt16(txtLegajo.Text);
            empleados.Mail = txtMail.Text;
            empleados.Telefono = txtTelefono.Text;
                               
            negocio1.agregar(empleados);
            Response.Redirect("AdministracionUsuarios");
        }

        public string BuscarUltimoLegajo()
        {
            string ultimoLegajo;
            EmpleadosNegocio negocio1 = new EmpleadosNegocio();
            ultimoLegajo = Convert.ToString(negocio1.buscar());
            return ultimoLegajo;

        }

        protected void btnDesloguearse(object sender, EventArgs e)
        {
            Session["usersession"] = null;
            Response.Redirect("PruebaLogin");
        }
    }
}