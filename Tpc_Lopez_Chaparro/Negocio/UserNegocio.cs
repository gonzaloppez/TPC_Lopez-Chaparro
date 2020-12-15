using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class UserNegocio
    {

        public string login(string usuario)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "select u.IDEmpleado, u.NombreUsuario, u.Contraseña, u.perfil from Usuario as u where u.NombreUsuario = @User";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@User", usuario);
                //conexion.agregarParametro("@pass", pass);
                SqlDataReader lectura = conexion.leer(); //creamos una variable de tipo sqldatareader y le asignamos la funcion de leer que esta en acceso a datos 
                usuario = lectura.GetString(3);
                return usuario;
              }
            catch (Exception ex)
            {
                return " ";
                throw ex;
            }
        }

        public List<Usuario> listar()
        {
            List<Usuario> ListaUser = new List<Usuario>(); //creamos lista de tipo usuario
            AccesoDatos conexion = new AccesoDatos(); //creamos conexion a datos ya incluye .open()

            try
            {
                //conexion.EjecutarLector();
                string consulta = "select u.IDEmpleado, u.NombreUsuario, u.Perfil from Usuario as u";//realizamos la consulta al SQL
                conexion.setearQuery(consulta); // seteamos la consulta pasandola a setQuery
                SqlDataReader lectura = conexion.leer(); //creamos una variable de tipo sqldatareader y le asignamos la funcion de leer que esta en acceso a datos 

                while (lectura.Read())
                {
                    Usuario aux = new Usuario(); //creamos nuevo objeto de tipo Empleado y leemos el valor de la DB

                    aux.ID = lectura.GetInt16(0);
                    aux.User = lectura.GetString(1);
                    aux.Perfil = lectura.GetString(2);


                    ListaUser.Add(aux);//cada objeto lo agregamos al listado
                }
                conexion.CerrarConexion();//cerramos conexion
                return ListaUser;//retornamos la lista
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Usuario modificado)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "update Usuario set NombreUsuario=@User, Perfil=@perfil where IDEmpleado=@ID";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@ID", modificado.ID);
                conexion.agregarParametro("@User", modificado.User);
                conexion.agregarParametro("@Perfil", modificado.Perfil);
                conexion.CerrarConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void agregar(Usuario Nuevo)
        {

            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Insert into Usuario (IDEmpleado,NombreUsuario,Contraseña,Perfil) values (@IDEmpleado,@NombreUsuario,ENCRYPTBYPASSPHRASE( 'pass' , @Contraseña),@Perfil)";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@IDEmpleado", Nuevo.ID);
                conexion.agregarParametro("@NombreUsuario", Nuevo.User);
                conexion.agregarParametro("@Contraseña", Nuevo.Pass);
                conexion.agregarParametro("@Perfil", Nuevo.Perfil);
                conexion.CerrarConexion();
                conexion.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void eliminarUser(int ID)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Delete from Usuario where IDEmpleado=@ID ";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@ID", ID);
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
