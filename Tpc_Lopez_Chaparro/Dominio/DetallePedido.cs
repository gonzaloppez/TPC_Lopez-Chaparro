using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class DetallePedido
    {
        public Pedido NumPedido { get; set; }
        public Carta IDCarta { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
    }
}
