using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PedidoDetallado
    {

        public long ID { get; set; }
        public string NumPedido { get; set; }
        public string detallePedido { get; set; }
        public int IDEmpleado { get; set; }
        public int NumMesa { get; set; }
        public string Estado { get; set; }
        public string AccionARealizar { get; set; }

        public PedidoDetallado(string NumPedido, string detallePedido, int IDEmpleado, int NumMesa, string Estado, string AccionARealizar)
        {
            this.NumPedido = NumPedido;
            this.detallePedido = detallePedido;
            this.IDEmpleado = IDEmpleado;
            this.NumMesa = NumMesa;
            this.Estado = Estado;
            this.AccionARealizar = AccionARealizar;
        }

    }

}