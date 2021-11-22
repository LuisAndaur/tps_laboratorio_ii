using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public delegate void DelegadoActualizar(int carga);
    public static class ConexionDB
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader reader;
        public static int totalColumnas = 0;
        public static event DelegadoActualizar EventoActualizar;

        static ConexionDB()
        {
            conexion = new SqlConnection(@"Server=DESKTOP-MACHMMG\SQLEXPRESS;Database=TorneoCSGO;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        /// <summary>
        /// Conecta con la base de datos y trae la query solicitada que puede ser cancelada
        /// </summary>
        /// <param name="query">solicitud</param>
        /// <param name="token">cancellation token</param>
        /// <returns>retorna lista de jugadores</returns>
        public static List<Jugador> TraerDatos(string query, CancellationToken token)
        {
            try
            {
                List<Jugador> auxLista = new List<Jugador>();


                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.CommandText = ("SELECT COUNT (*) FROM Jugadores");
                totalColumnas = (int)comando.ExecuteScalar();
                comando.CommandText = query;

                reader = comando.ExecuteReader();
                reader.Read();
                do
                {
                    Jugador auxJugador = new Jugador();

                    auxJugador.NroJugador = (int)reader["Id"];
                    auxJugador.Nombre = reader["Nombre"].ToString().Trim();
                    auxJugador.Edad = (int)reader["Edad"];
                    auxJugador.Genero = reader["Genero"].ToString().Trim();
                    auxJugador.Nacionalidad = reader["Nacionalidad"].ToString().Trim();
                    auxJugador.Especialidad = reader["Especialidad"].ToString().Trim();
                    auxJugador.PrimerTorneo = (bool)reader["PrimerTorneo"];

                    auxLista.Add(auxJugador);
                    if (EventoActualizar is not null)
                    {
                        ConexionDB.EventoActualizar.Invoke(auxLista.Count);
                    }
                    Thread.Sleep(100);
                } while (reader.Read() && !token.IsCancellationRequested);

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
