using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lIBRERIA PARA hacer la conexion utilizar ciertos objetos para este fin 
using System.Data.SqlClient;

namespace PrimeraConexionDb
{
    internal class PokemonNegocio
    {
        //Clase en la cual voy a crear los metodos de acceso a datos para los pokemon 

        public List<Pokemon> listar()
        {
            List<Pokemon> list = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            //Acciones
            SqlCommand comando = new SqlCommand();
            //Alojar el set de datos
            SqlDataReader lector;


            //Funcion para establecer la conexion
            try
            {
                //Toda la funcionalidad que pueda fallar 
                // Y configuracion de los objetos 

                //Cadena de conexion; como debe conectarse a la base de datos 
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true ";//Direcion de base de datos local;nombre de la base de datos epecifica a la que se accedera; tipo de autenticación que se usará para conectarse a SQL Server.
                //Que tipo de accion se va a realizar
                comando.CommandType = System.Data.CommandType.Text;
                //especificamos cual va a ser el texto 
                comando.CommandText = "select Numero, Nombre, P.Descripcion as DescripcionPokemons, E.Descripcion as DescripcionElementos, UrlImagen from POKEMONS P, ElEMENTOS E where P.idTipo = E.id";//Consulta Sql 
                // Ese comando lo va a ejecutar es esta conexion 
                comando.Connection = conexion;

                //Abrir la conexion 
                conexion.Open();
                //realizar la lectura
                lector = comando.ExecuteReader();//Crea un tipo de tabla virtual con un puntero 
                //ExecuteReader>leer los datos devueltos por la consulta de manera secuencial, fila por fila.

                //se lee el lector  
                while (lector.Read()) //si hay filas por leer true si no false
                {
                    // Aquí es donde accederías a las columnas de la fila actual
                    Pokemon aux =  new Pokemon(); 
                    
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["DescripcionPokemons"];
                    aux.DescripcionTipo = (string)lector["DescripcionElementos"];
                    aux.UrlImagen = (string)lector["UrlImagen"];


                    list.Add(aux);
                }

                conexion.Close();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
