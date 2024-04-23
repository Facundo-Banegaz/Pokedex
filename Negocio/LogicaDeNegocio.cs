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
                Comando.CommandText = "Select P.Id, P.Codigo, P.Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1";

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
                    aux.Codigo = (string)lector["Codigo"];
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
                accesoDatos.setearConsulta("Insert into POKEMONS (Codigo, Nombre, Descripcion, Activo,IdTipo,IdDebilidad,UrlImagen)values(@Codigo,@Nombre,@Descripcion, 1,@IdTipo,@IdDebilidad,@UrlImagen)");
                //manera de inyectar una parametro en una consulta
                accesoDatos.setearParametro("@Codigo", nuevo.Codigo);
                accesoDatos.setearParametro("@Nombre", nuevo.Nombre);
                accesoDatos.setearParametro("@Descripcion", nuevo.Descripcion);
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
                datos.setearConsulta("update POKEMONS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, UrlImagen = @UrlImagen, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @Id");
                datos.setearParametro("@Id", modificar.Id);
                datos.setearParametro("@Codigo", modificar.Codigo);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@UrlImagen", modificar.UrlImagen);
                datos.setearParametro("@idTipo", modificar.Tipo.Id);
                datos.setearParametro("@idDebilidad", modificar.Debilidad.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Suspender(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update  pokemons set activo = 0  where Id =@Id");
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from pokemons where Id =@Id");
                datos.setearParametro("@Id",Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void MostrarDetalle(Pokemon detalle)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select P.Id, P.Codigo, P.Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 and P.Id = @Id;");
                datos.setearParametro("@Id", detalle.Id);

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
                string consulta = "Select P.Id, P.Codigo, P.Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 And ";

                if (campo == "Id")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "P.Id > " + filtro;
                            break;

                        case "Menor a":
                            consulta += "P.Id < " + filtro;
                            break;

                        default:
                            consulta += "P.Id = " + filtro;
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
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
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

