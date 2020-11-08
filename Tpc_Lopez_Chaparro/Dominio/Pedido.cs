using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Pedido
    {
        public int NumPedido { get; set; }
        public Carta IDCarta { get; set ; }
        public Empleados IDEmpleado { get; set; }
        public int NumMesa { get; set; }
        public int Estado { get; set; }
    }
}
