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

            if (!IsPostBack)
            {
                try
                {
                    listadoAux = empleadoAuxiliar.listar();
                    int IdAux = Convert.ToInt16(Request.QueryString["IDuser"]);
                    EmpleadoAdmin = listadoAux.Find(us => us.ID == IdAux);
                    //Precarga los datos de los platos en los textboxs 
                    txtLegajo.Text = Convert.ToString(EmpleadoAdmin.Legajo);
                    txtNombre.Text = EmpleadoAdmin.Nombre;
                    txtApellido.Text = EmpleadoAdmin.Apellido;
                    txtDni.Text = Convert.ToString(EmpleadoAdmin.DNI);
                    txtTelefono.Text = Convert.ToString(EmpleadoAdmin.Telefono);
                    txtMail.Text = EmpleadoAdmin.Mail;

                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

        }
        protected void btn_bajaLogicaEmpleado_Click(object sender, EventArgs e)
        {
                UserNegocio negocio1 = new UserNegocio();
                EmpleadosNegocio negocio = new EmpleadosNegocio();
                if (EmpleadoEliminar == null)
                {
                    EmpleadoEliminar = new Empleados();
                    UsuarioEliminar = new Usuario();
                }
                EmpleadoEliminar.ID = Convert.ToInt16(Request.QueryString["IDuser"]);
                UsuarioEliminar.ID = Convert.ToInt16(Request.QueryString["IDuser"]);
                negocio.BajaLogica(EmpleadoEliminar.ID);
                negocio1.eliminarUser(UsuarioEliminar.ID);
                Response.Redirect("Administracion");
            }

        

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            EmpleadosNegocio negocio = new EmpleadosNegocio();
            if (EmpleadoModificar == null)
            {
                EmpleadoModificar = new Empleados();
                
            }
            EmpleadoModificar.ID = Convert.ToInt16(Request.QueryString["IDuser"]);
            EmpleadoModificar.Legajo = Convert.ToInt16(txtLegajo.Text);
            EmpleadoModificar.Nombre = txtNombre.Text;
            EmpleadoModificar.Apellido = txtApellido.Text;
            EmpleadoModificar.DNI = txtDni.Text;
            EmpleadoModificar.Telefono = txtTelefono.Text;
            EmpleadoModificar.Mail = txtMail.Text;      
            negocio.modificar(EmpleadoModificar);
            Response.Redirect("AdministracionUsuarios");
        }
    }
}