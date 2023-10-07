using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class LogicaDeNegocio
    {
        // en esta clase se hace la conexion a la base de datos

        //Metodo

        public List<Pokemon> ListarPokemon()
        {
            List<Pokemon> listPokemons = new List<Pokemon>();

            SqlConnection Conexion = new SqlConnection();

            SqlCommand Comando = new SqlCommand();

            SqlDataReader lector;


            try
            {
                //direccion del motor de la base de datos
                Conexion.ConnectionString = "server=.\\SQLEXPRESS; database=Pokemon; integrated security=true";

                Comando.CommandType= System.Data.CommandType.Text;
                Comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1";

                Comando.Connection = Conexion;

                //abro la conexion
                Conexion.Open();

                //realizo lectura
                lector = Comando.ExecuteReader();

                while( lector.Read() ) 
                {
                    Pokemon aux = new Pokemon();

                    //existe varias manera de obtener los datos

                    //aux.Numero = lector.GetInt32(0);
                    //aux.Nombre = lector.GetString(1);
                    //aux.Descripcion = lector.GetString(2);


                    //esta es la manera mas recomendable ya que no que ver la posicion del indice ej
                    //                      "select Numero, Nombre, Descripcion from POKEMONS";
                    //                              0       1         2

                    aux.Id = (int)lector["Id"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //validar que el dato no sea vacio
                    //primera forma
                    //  if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))

                    //segunda forma y mas facil

                    if (!(lector["UrlImagen"] is DBNull))
                    
                        aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elemento();

                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion= (string)lector["Tipo"];


                    aux.Debilidad = new Elemento();

                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    listPokemons.Add(aux);
                }

                Conexion.Close();

                return listPokemons;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Agregar(Pokemon nuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo,IdTipo,IdDebilidad,UrlImagen)values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1,@IdTipo,@IdDebilidad,@UrlImagen)");
                //manera de inyectar una parametro en una consulta
                accesoDatos.setearParametro("@IdTipo",nuevo.Tipo.Id);
                accesoDatos.setearParametro("@IdDebilidad", nuevo.Debilidad.Id);
                accesoDatos.setearParametro("@UrlImagen", nuevo.UrlImagen);
                accesoDatos.ejecutarAccion();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void Modificar(Pokemon modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");
                datos.setearParametro("@numero", modificar.Numero);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@desc", modificar.Descripcion);
                datos.setearParametro("@img", modificar.UrlImagen);
                datos.setearParametro("@idTipo", modificar.Tipo.Id);
                datos.setearParametro("@idDebilidad", modificar.Debilidad.Id);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Suspender(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update  pokemons set activo = 0  where id =@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from pokemons where id =@id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void MostrarDetalle(Pokemon detalle)
        {
            /*
             Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 and p.Numero = @Numero;"
             */

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 and p.Numero = @Numero;");
                datos.setearParametro("@numero", detalle.Numero);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Pokemon> Filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> listPokemons = new List<Pokemon>();
            AccesoDatos accesoDatos = new AccesoDatos();




            try
            {
                string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 And ";

                if (campo == "Número")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Numero > " + filtro;
                            break;

                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;

                        default:
                            consulta += "Numero = " + filtro;
                            break;
                    }


                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;

                        case "Termina con":
                            consulta += "Nombre like  '%" + filtro + "' ";
                            break;

                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;

                    }
                }
                else 
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "P.descripcion like '" + filtro +"%' ";
                            break;

                        case "Termina con":
                            consulta += "P.descripcion like  '%" + filtro+"' " ;
                            break;

                        default:
                            consulta += "P.descripcion like '%" + filtro+"%'" ;
                            break;

                    }

                }

                    accesoDatos.setearConsulta(consulta);
                    accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();

                       

                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Numero = (int)accesoDatos.Lector["Numero"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];


                    if (!(accesoDatos.Lector["UrlImagen"] is DBNull))

                        aux.UrlImagen = (string)accesoDatos.Lector["UrlImagen"];

                    aux.Tipo = new Elemento();

                    aux.Tipo.Id = (int)accesoDatos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)accesoDatos.Lector["Tipo"];


                    aux.Debilidad = new Elemento();

                    aux.Debilidad.Id = (int)accesoDatos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)accesoDatos.Lector["Debilidad"];

                    listPokemons.Add(aux);
                }



                return listPokemons;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

