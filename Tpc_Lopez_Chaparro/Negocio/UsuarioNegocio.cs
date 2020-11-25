﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class UsuarioNegocio
    {
        public List<Empleados> listar()
        {
            List<Empleados> ListaUsuario = new List<Empleados>(); //creamos lista de tipo usuario
            AccesoDatos conexion = new AccesoDatos(); //creamos conexion a datos ya incluye .open()

            try
            {
                //conexion.EjecutarLector();
                string consulta = "select e.id, e.legajo, e.nombre, e.apellido, e.DNI, e.telefono,e.mail,e.estado from Empleados as e";//realizamos la consulta al SQL
                conexion.setearQuery(consulta); // seteamos la consulta pasandola a setQuery
                SqlDataReader lectura = conexion.leer(); //creamos una variable de tipo sqldatareader y le asignamos la funcion de leer que esta en acceso a datos 

                while (lectura.Read())
                {
                    Empleados auxEm = new Empleados(); //creamos nuevo objeto de tipo Empleado y leemos el valor de la DB

                    auxEm.ID = lectura.GetInt16(0);
                    auxEm.Legajo = lectura.GetInt16(1);
                    auxEm.Nombre = lectura.GetString(2);
                    auxEm.Apellido = lectura.GetString(3);
                    auxEm.DNI = lectura.GetString(4);
                    auxEm.Telefono = lectura.GetString(5);
                    auxEm.Mail = lectura.GetString(6);
                    auxEm.estado = lectura.GetBoolean(7);
                    // aux.User = lectura.GetString(8);
                    //aux.Perfil = lectura.GetString(9);


                    ListaUsuario.Add(auxEm);//cada objeto lo agregamos al listado
                }
                conexion.CerrarConexion();//cerramos conexion
                return ListaUsuario;//retornamos la lista
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminar(int ID)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Delete from Empleados where ID=@ID";
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

        public void modificar(Empleados modificado)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "update Empleados set Legajo=@Legajo, Nombre=@Nombre, Apellido=@Apellido, DNI=@DNI, Telefono=@Telefono, mail=@Mail, estado=@Estado where ID=@ID";
                conexion.setearQuery(consulta);
                conexion.agregarParametro("@ID", modificado.ID);
                conexion.agregarParametro("@Legajo", modificado.Legajo);
                conexion.agregarParametro("@Nombre", modificado.Nombre);
                conexion.agregarParametro("@Apellido", modificado.Apellido);
                conexion.agregarParametro("@DNI", modificado.DNI);
                conexion.agregarParametro("@Telefono", modificado.Telefono);
                conexion.agregarParametro("@Mail", modificado.Mail);
                conexion.agregarParametro("@estado", modificado.estado);
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


