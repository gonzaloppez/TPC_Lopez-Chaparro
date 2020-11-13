using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class CartaNegocio
    {
        public List<Carta> listar()
        {
            List<Carta> listaCarta = new List<Carta>(); //creamos lista de tipo carta
            AccesoDatos conexion = new AccesoDatos(); //creamos conexion a datos ya incluye .open()

            try
            {
                //conexion.EjecutarLector();
                string consulta = "Select c.nombre, c.precio, isnull(c.descripcion,' ') from Carta as c";//realizamos la consulta al SQL
                conexion.setearQuery(consulta); // seteamos la consulta pasandola a setQuery
                SqlDataReader lectura = conexion.leer(); //creamos una variable de tipo sqldatareader y le asignamos la funcion de leer que esta en acceso a datos 

                while (lectura.Read())
                {
                    Carta aux = new Carta(); //creamos nuevo objeto de tipo carta y leemos el valor de la DB
                    aux.Nombre = lectura.GetString(0);
                    aux.Precio = lectura.GetDecimal(1);
                    aux.Descripcion = (string)lectura.GetString(2);
                    listaCarta.Add(aux); //cada objeto lo agregamos al listado
                }

                conexion.CerrarConexion();//cerramos conexion
                return listaCarta;//retornamos la lista
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void agregar(Carta Nuevo)
        {
           
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values (@Nombre,@Precio,@IDTipo_Platos,@Descripcion)";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@Nombre", Nuevo.Nombre);
                conexion.agregarParametro("@Precio", Nuevo.Precio);
                conexion.agregarParametro("@IDTipo_Platos", Nuevo.Tipo);
                conexion.agregarParametro("@Descripcion", Nuevo.Descripcion);
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

