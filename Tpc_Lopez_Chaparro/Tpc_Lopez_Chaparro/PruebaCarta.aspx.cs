﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Tpc_Lopez_Chaparro
{
    public partial class PruebaCarta : System.Web.UI.Page
    {
        public List<Carta> listaCarta { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            CartaNegocio negocio = new CartaNegocio(); //creamos objeto de tipo cartaNegocio
            try
            {
                listaCarta = negocio.listar(); //le asignamos lo que devuelve listar

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}