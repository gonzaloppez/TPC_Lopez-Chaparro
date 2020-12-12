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
        public List<Pedido> listaPedidos { get; set; }
        public List<PedidoDetallado> pedidosAgrupadosDetallados { get; set; }
        
        private string numPedido;

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
            PedidoNegocio negocio = new PedidoNegocio(); //creamos objeto de tipo cartaNegocio
            try
            {
                listaPedidos = negocio.listar(); //le asignamos lo que devuelve listar
                pedidosAgrupadosDetallados = agrupar(listaPedidos);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            if (Request.QueryString["NumPedido"] != null)
            {
                CambiarEstadoPedido();
            }
        }

        private List<PedidoDetallado> agrupar(List<Pedido> listaPedido)
        {
            List<List<Pedido>> pedidosAgrupados = listaPedido
                .GroupBy(Pedido => Pedido.NumPedido)
                .Select(grupo => grupo.ToList())
                .ToList();

            CartaNegocio negocio = new CartaNegocio();
            List<Carta> carta = negocio.listar();
            List<PedidoDetallado> agrupados = new List<PedidoDetallado>();
            foreach (var pedidoAgrupado in pedidosAgrupados)
            {
                Pedido first = pedidoAgrupado.First();
                string descripcionPedido = obtenerDescripcionPedido(pedidoAgrupado, carta);
                PedidoDetallado pedidoDetallado = new PedidoDetallado(first.NumPedido, descripcionPedido, first.IDEmpleado, first.NumMesa, detalleEstado(first.Estado), detalleEstado(first.Estado + 1));
                agrupados.Add(pedidoDetallado);
            
           }
            return agrupados;
        }

        private string obtenerDescripcionPedido (List<Pedido> pedidoAgrupado, List<Carta> carta)
        {
            List<string> listaDetalle = pedidoAgrupado
                .ConvertAll(pedido => BuscarNombreCarta(carta, pedido.IDCarta));

            return string.Join(", ", listaDetalle);
        }
         private string BuscarNombreCarta(List<Carta> lista, int id)
        {
            foreach (Carta item in lista)
            {
                if (item.ID == id)
                {
                    return item.Nombre;
                }
            }
            return "";
        }

        private string detalleEstado(int estado)
        {
            switch (estado)
            {
                case 0:
                    return "Pagado";
                case 1:
                    return "En preparacion";
                case 2:
                    return "Para retirar";
                case 3:
                    return "Entregado";
                case 4:
                    return "Finalizado";
                default:
                    return "";
            }
                
        }

        public void CambiarEstadoPedido()
        {
            numPedido = Request.QueryString["NumPedido"];
            PedidoNegocio negocio1 = new PedidoNegocio();
            negocio1.CambiarEstado(numPedido);
            Response.Redirect("administracionCocina");
        }


    }
}