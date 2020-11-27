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
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        public Empleados EmpleadoEliminar = null;
        public Usuario UsuarioEliminar = null;
        public Empleados EmpleadoModificar = null;
        public Usuario UserModificar = null;

        public Empleados EmpleadoAdmin { get; set; }
        public Usuario UserAdmin { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UserNegocio userAux = new UserNegocio();
            EmpleadosNegocio empleadoAuxiliar = new EmpleadosNegocio();
            List<Empleados> listadoAux;
            List<Usuario> listaUser;

            try
            {
                listaUser = userAux.listar();
                listadoAux = empleadoAuxiliar.listar();
                int IduserAux = Convert.ToInt16(Request.QueryString["IDuser"]);
                int IdAux = Convert.ToInt16(Request.QueryString["IDuser"]);
                UserAdmin = listaUser.Find(us => us.ID == IduserAux);
                EmpleadoAdmin = listadoAux.Find(us => us.ID == IdAux);
                //Precarga los datos de los platos en los textboxs 
                txtNombre.Text = EmpleadoAdmin.Nombre;
                txtApellido.Text = EmpleadoAdmin.Apellido;
                txtLegajo.Text = Convert.ToString(EmpleadoAdmin.Legajo);
                txtDni.Text = Convert.ToString(EmpleadoAdmin.DNI);
                txtTelefono.Text = Convert.ToString(EmpleadoAdmin.Telefono);
                txtMail.Text = EmpleadoAdmin.Mail;
                txtEstado.Text = Convert.ToString(EmpleadoAdmin.estado);
                txtUsuario.Text = UserAdmin.User;
                txtPerfil.Text = UserAdmin.Perfil;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btn_EliminarUser_Click(object sender, EventArgs e)
        {

            EmpleadosNegocio negocio = new EmpleadosNegocio();
            if (EmpleadoEliminar == null && UsuarioEliminar == null)
            {
                EmpleadoEliminar = new Empleados();
                UsuarioEliminar = new Usuario();
            }
            EmpleadoEliminar.ID = Convert.ToInt16(Request.QueryString["IDUser"]);
            UsuarioEliminar.ID = Convert.ToInt16(Request.QueryString["IDUser"]);
            negocio.eliminarUser(UsuarioEliminar.ID);
            negocio.eliminar(EmpleadoEliminar.ID);
            

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            EmpleadosNegocio negocio = new EmpleadosNegocio();
            UserNegocio negocio1 = new UserNegocio();
            if (EmpleadoModificar == null)
            {
                EmpleadoModificar = new Empleados();
                UserModificar = new Usuario();
            }
            EmpleadoModificar.ID = Convert.ToInt16(Request.QueryString["ID"]);
            EmpleadoModificar.Legajo = Convert.ToInt16(txtLegajo.Text);
            EmpleadoModificar.Nombre = txtNombre.Text;
            EmpleadoModificar.Apellido = txtApellido.Text;
            EmpleadoModificar.DNI = txtDni.Text;
            EmpleadoModificar.Telefono = txtTelefono.Text;
            EmpleadoModificar.Mail = txtMail.Text;
            EmpleadoModificar.estado = Convert.ToBoolean(txtEstado.Text);
            UserModificar.ID = Convert.ToInt16(Request.QueryString["IDUser"]);
            UserModificar.User = txtUsuario.Text;
            UserModificar.Perfil = txtPerfil.Text;
            negocio.modificar(EmpleadoModificar);
            negocio1.modificar(UserModificar);
        }
    }
}