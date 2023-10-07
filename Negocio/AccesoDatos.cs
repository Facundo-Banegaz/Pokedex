using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class AccesoDatos
    {
        //comandos para realizar las operacion con la db

        private SqlConnection Conexion;

        private SqlCommand Comando;

        private SqlDataReader lector;
        
        public SqlDataReader Lector 
        {
            get { return lector; }
        }

         

        public AccesoDatos()
        { 
            Conexion = new SqlConnection("server=.\\SQLEXPRESS; database=Pokemon; integrated security=true");
            Comando = new SqlCommand();
        }

        public void SetConsulta(string Consulta)
        { 
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }


        public void EjecutarLectura()
        {
            Comando.Connection=Conexion;

            try
            {
                Comando.Connection.Open();

                lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void setearConsulta(string consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
           Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }
        public void  cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
                Conexion.Close();
            }   
        }


    }
}
