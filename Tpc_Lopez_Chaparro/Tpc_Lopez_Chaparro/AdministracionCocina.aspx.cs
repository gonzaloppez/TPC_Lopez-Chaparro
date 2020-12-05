using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Tpc_Lopez_Chaparro
{
    public partial class AdministracionCocina : System.Web.UI.Page
    {
        public List<Pedido> listarPedidos { get; set; } //creamos lista de tipo carta

        protected void Page_Load(object sender, EventArgs e)
        {
            PedidoNegocio negocio = new PedidoNegocio(); //creamos objeto de tipo cartaNegocio
            try
            {
                listarPedidos = negocio.listar(); //le asignamos lo que devuelve listar
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}