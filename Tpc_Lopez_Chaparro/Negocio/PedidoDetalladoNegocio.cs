using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class PedidoDetalladoNegocio
    {
        public List<Pedido> listarFinalizado()
        {
            List<Pedido> listarPedido = new List<Pedido>(); //creamos lista de tipo Pedido
            AccesoDatos conexion = new AccesoDatos(); //creamos conexion a datos ya incluye .open()

            try
            {
                //conexion.EjecutarLector();
                string consulta = "select p.ID, p.NumPedido, p.IDCarta, p.IDEmpleado, p.NumeroMesa, p.estado from Pedido as p where p.estado = 4";//realizamos la consulta al SQL
                conexion.setearQuery(consulta); // seteamos la consulta pasandola a setQuery
                SqlDataReader lectura = conexion.leer(); //creamos una variable de tipo sqldatareader y le asignamos la funcion de leer que esta en acceso a datos 

                while (lectura.Read())
                {
                    Pedido aux = new Pedido(); //creamos nuevo objeto de tipo pedido y leemos el valor de la DB
                    aux.ID = lectura.GetInt64(0);
                    aux.NumPedido = lectura.GetString(1);
                    aux.IDCarta = lectura.GetInt16(2);
                    aux.IDEmpleado = lectura.GetInt16(3);
                    aux.NumMesa = lectura.GetInt16(4);
                    aux.Estado = lectura.GetInt16(5);
                    listarPedido.Add(aux); //cada objeto lo agregamos al listado
                }

                conexion.CerrarConexion();//cerramos conexion
                return listarPedido;//retornamos la lista
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
