using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public long ID { get; set; }
        public long NumPedido { get; set; }
        public int IDCarta { get; set; }
        public int IDEmpleado { get; set; }
        public int NumMesa { get; set; }
        public bool Estado { get; set; }

        public Pedido(long NumPedido, int IDCarta, int IDEmpleado, int NumMesa, bool Estado)
        {
            this.NumPedido = NumPedido;
            this.IDCarta = IDCarta;
            this.IDEmpleado = IDEmpleado;
            this.NumMesa = NumMesa;
            this.Estado = Convert.ToBoolean(Estado);
        }

        public Pedido()
        {

        }

      }

}
