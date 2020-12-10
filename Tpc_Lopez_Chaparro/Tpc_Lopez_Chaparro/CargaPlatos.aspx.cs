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
    public partial class CargaPlatos : System.Web.UI.Page
    {
        private Carta carta = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            CartaNegocio negocio = new CartaNegocio();
            if (carta == null)
            {
                carta = new Carta();
            }

            carta.Nombre = txtNombre.Text;
            carta.Precio = Convert.ToDecimal(txtPrecio.Text);
            carta.Tipo = txtTipo.Text;
            carta.Descripcion = txtDescripcion.Text;
            negocio.agregar(carta);
            Response.Redirect("AdministracionPlatos");
        }
    }
}