using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class PedidoNegocio
    {
        public List<Pedido> listar()
        {
            List<Pedido> listarPedido = new List<Pedido>(); //creamos lista de tipo Pedido
            AccesoDatos conexion = new AccesoDatos(); //creamos conexion a datos ya incluye .open()

            try
            {
                //conexion.EjecutarLector();
                string consulta = "select p.ID, p.NumPedido, p.IDCarta, p.IDEmpleado, p.NumeroMesa, p.estado from Pedido as p where p.Estado = 0 order by p.NumPedido";//realizamos la consulta al SQL
                conexion.setearQuery(consulta); // seteamos la consulta pasandola a setQuery
                SqlDataReader lectura = conexion.leer(); //creamos una variable de tipo sqldatareader y le asignamos la funcion de leer que esta en acceso a datos 

                while (lectura.Read())
                {
                    Pedido aux = new Pedido(); //creamos nuevo objeto de tipo carta y leemos el valor de la DB
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

        public void agregarPedido(Pedido Nuevo)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Insert into Pedido (NumPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (@NumPedido,@IDCarta,@IDEmpleado,@NumeroMesa,@Estado)";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@NumPedido", Nuevo.NumPedido);
                conexion.agregarParametro("@IDCarta", Nuevo.IDCarta);
                conexion.agregarParametro("@IDEmpleado", Nuevo.IDEmpleado);
                conexion.agregarParametro("@NumeroMesa", Nuevo.NumMesa);
                conexion.agregarParametro("@Estado", Nuevo.Estado);
                conexion.CerrarConexion();
                conexion.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
