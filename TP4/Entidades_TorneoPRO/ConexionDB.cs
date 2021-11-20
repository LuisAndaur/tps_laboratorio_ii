﻿using System;
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

        static ConexionDB()
        {
            //conexion = new SqlConnection(@"Server=DESKTOP-1GT6RE5\SQLEXPRESS;Database=TorneoCSGO;Trusted_Connection=True;");
            conexion = new SqlConnection(@"Server=DESKTOP-59VIUUI\SQLEXPRESS;Database=TorneoCSGO;Trusted_Connection=True;");
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

                    decimal.TryParse(reader["Id"].ToString().Trim(), out decimal auxId);
                    decimal.TryParse(reader["Edad"].ToString().Trim(), out decimal auxEdad);
                    auxJugador.NroJugador = (int)auxId;
                    auxJugador.Nombre = reader["Nombre"].ToString().Trim();
                    auxJugador.Edad = (int)auxEdad;
                    auxJugador.Genero = reader["Genero"].ToString().Trim();
                    auxJugador.Nacionalidad = reader["Nacionalidad"].ToString().Trim();
                    auxJugador.Especialidad = reader["Especialidad"].ToString().Trim();
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
