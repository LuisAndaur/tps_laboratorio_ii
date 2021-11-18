using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public static class ConexionDB
    {
        static SqlConnection conexion; //conecta la instancia de sql
        static SqlCommand comando; //llevar la consulta
        static SqlDataReader reader; //devolverme los datos
        private static string connStr;

        static ConexionDB()
        {
            conexion = new SqlConnection(@"Server=DESKTOP-1GT6RE5\SQLEXPRESS;Database=TorneoCSGO;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Jugador> TraerDatos(string query)
        {
            try
            {
                List<Jugador> auxLista = new List<Jugador>();

                comando.CommandText = query;
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {                    
                    Jugador auxJugador = new Jugador();

                    decimal.TryParse(reader["Id"].ToString(), out decimal auxId);
                    decimal.TryParse(reader["Edad"].ToString(), out decimal auxEdad);
                    auxJugador.NroJugador = (int)auxId;
                    auxJugador.Nombre = reader["Nombre"].ToString();
                    auxJugador.Edad = (int)auxEdad;
                    auxJugador.Genero = reader["Genero"].ToString();
                    auxJugador.Nacionalidad = reader["Nacionalidad"].ToString();
                    auxJugador.Especialidad = reader["Especialidad"].ToString();
                    auxJugador.PrimerTorneo = (bool)reader["PrimerTorneo"];

                    auxLista.Add(auxJugador);
                }

                return auxLista;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
