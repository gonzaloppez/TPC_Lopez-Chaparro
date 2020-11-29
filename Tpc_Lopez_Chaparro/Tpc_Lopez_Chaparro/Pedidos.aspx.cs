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
    public partial class Pedidos : System.Web.UI.Page
    {
        private int IDCarta;
        private List<Carta> listaCarta = null;
        private Carta CartaPedido= null;
        public List<Carta> listaPedido = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (listaPedido == null)
                {
                    listaPedido = new List<Carta>();
                }

                if (Session["listaPedido"] == null)
                {
                    Session.Add("listaPedido", listaPedido);
                }

                if (Request.QueryString["IDPedido"] != null)
                {
                    AgregarCarta();
                }

                decimal total_precio = 0;
                int cant = 0;

                foreach (var item in listaPedido)
                {
                    total_precio += item.Precio;
                    cant++;
                }

                lblcant.Text = cant.ToString();
                lblTotal.Text = total_precio.ToString();


            }

            catch (Exception)
            {

                throw;
            }
        }

        public void AgregarCarta()
        {
            CartaNegocio negocio = new CartaNegocio();
            IDCarta = Convert.ToInt16(Request.QueryString["IDPedido"]);
            listaPedido = (List<Carta>)Session["listaPedido"];
            listaCarta = negocio.listar();
            CartaPedido = BuscarPedido(listaCarta, IDCarta);
            listaPedido.Add(CartaPedido);
            Session["listaPedido"] = listaPedido;
        }

        private Carta BuscarPedido(List<Carta> lista, int id)
        {
            foreach (Carta item in lista)
            {
                if (item.ID == id)
                {
                    CartaPedido = item;
                    return CartaPedido;
                }
            }
            return CartaPedido;
        }
    }
}