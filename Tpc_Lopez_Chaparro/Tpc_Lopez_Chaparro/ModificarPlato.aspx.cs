﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Tpc_Lopez_Chaparro
{
    public partial class ModificarPlato : System.Web.UI.Page
    {
        public string nombreUsuario { get; set; }

        public Carta PlatoModificar = null;
        public Carta PlatoEliminar = null;
        public Carta CartaModificar { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CartaNegocio cartaAux = new CartaNegocio();
            List<Carta> listaAux;

            if (!IsPostBack) { 
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


                    listaAux = cartaAux.listar();
                int IdAux = Convert.ToInt16(Request.QueryString["ID"]);
                CartaModificar = listaAux.Find(Pla => Pla.ID == IdAux);
                //Precarga los datos de los platos en los textboxs 
                txtnombre.Text = CartaModificar.Nombre;
                txtprecio.Text = Convert.ToString(CartaModificar.Precio);
                txtdescripcion.Text = CartaModificar.Descripcion;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            CartaNegocio negocio = new CartaNegocio();
            if(PlatoModificar == null)
            {
                PlatoModificar = new Carta();
            }
                PlatoModificar.ID = Convert.ToInt16(Request.QueryString["ID"]);
                PlatoModificar.Nombre = txtnombre.Text;
                PlatoModificar.Precio = Convert.ToDecimal(txtprecio.Text);
                PlatoModificar.Descripcion = txtdescripcion.Text;
                negocio.modificar(PlatoModificar);
                Response.Redirect("AdministracionPlatos");
            }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            CartaNegocio negocio = new CartaNegocio();
            if (PlatoEliminar == null)
            {
                PlatoEliminar = new Carta();
            }
            PlatoEliminar.ID = Convert.ToInt16(Request.QueryString["ID"]);
            negocio.eliminar(PlatoEliminar.ID);
            Response.Redirect("AdministracionPlatos");
        }
    }
}