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
        public Pedido elementoAux = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {   
                if (listaPedido == null)
                {
                    listaPedido = new List<Carta>();
                }
                
                if(!IsPostBack)
                {
                    if (Session["listaPedido"] == null)
                    {
                        Session.Add("listaPedido", listaPedido);
                    }

                    if (Request.QueryString["IDPedido"] != null)
                    {
                        AgregarCarta(); //ver si se puede dar de baja el IDPedido dps de usarlo
                    }

                    if (Request.QueryString["IDQuitar"] != null)
                    {
                        Quitar();
                    }
                }
                
                listaPedido = (List<Carta>)Session["listaPedido"];

                if(!IsPostBack)
                { 
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
            }

            catch (Exception ex)
            {

                throw ex;
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
        public void Quitar()
        {
            IDCarta = Convert.ToInt32(Request.QueryString["IDQuitar"]);
            listaPedido = (List<Carta>)Session["listaPedido"];
            listaPedido.Remove(listaPedido.Find(id => IDCarta == id.ID)); 
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

        protected void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            if(elementoAux == null)
            {
                elementoAux = new Pedido();
            }
            PedidoNegocio negocio = new PedidoNegocio();
            List<Pedido> pedidos = new List<Pedido>();
            int IDMozo = Convert.ToInt16(txtIDMozo.Text);
            int IDMesa = Convert.ToInt16(txtIDMesa.Text);
            string numPedido = System.Guid.NewGuid().ToString();
            foreach (var elementoCarta in listaPedido)
            {
                elementoAux = new Pedido(numPedido,elementoCarta.ID,IDMozo,IDMesa,0);
                pedidos.Add(elementoAux);
                negocio.agregarPedido(elementoAux);
            }
            Session.Remove("listaPedido");
            Response.Redirect("PruebaCarta");
            
        }

       
    }
}