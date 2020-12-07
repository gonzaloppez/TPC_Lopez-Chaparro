﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public long ID { get; set; }
        public string NumPedido { get; set; }
        public int IDCarta { get; set; }
        public int IDEmpleado { get; set; }
        public int NumMesa { get; set; }
        public int Estado { get; set; }

        public Pedido(string NumPedido, int IDCarta, int IDEmpleado, int NumMesa, int Estado)
        {
            this.NumPedido = NumPedido;
            this.IDCarta = IDCarta;
            this.IDEmpleado = IDEmpleado;
            this.NumMesa = NumMesa;
            this.Estado = Estado;
        }

        public Pedido()
        {

        }

      }

}
