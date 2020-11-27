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

        private Usuario usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            UserNegocio negocio = new UserNegocio();
            EmpleadosNegocio negocio1 = new EmpleadosNegocio();
            if (empleados == null && usuario == null)
            {
                empleados = new Empleados();
                usuario = new Usuario();
            }

            empleados.ID = Convert.ToInt16(txtIDEmpleado.Text);
            empleados.Nombre = txtNombre.Text;
            empleados.Apellido = txtApellido.Text;
            empleados.DNI = txtDNI.Text;
            empleados.estado = true;
            empleados.Legajo = Convert.ToInt16(txtLegajo.Text);
            empleados.Mail = txtMail.Text;
            empleados.Telefono = txtTelefono.Text;
            usuario.ID = Convert.ToInt16(txtID.Text);
            usuario.Perfil = txtPerfil.Text;
            usuario.User = txtUser.Text;
            usuario.Pass = Convert.ToString(txtPass.Text);

            negocio.agregar(usuario);            
            negocio1.agregar(empleados);
        }
    }
}