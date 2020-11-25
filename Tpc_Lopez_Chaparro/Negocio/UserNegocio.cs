﻿using System;
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

        
    }
}
