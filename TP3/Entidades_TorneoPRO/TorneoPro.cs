using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_TorneoPRO
{
    public static class TorneoPro
    {
        private static string nombreTorneo;
        private static double premio;
        private static string patrocinio;
        private static List<Jugador> listaJugadores;
        private static List<Deathmatch> mapasDeathmatch;
        private static List<Bomba> mapasBomba;
        private static List<Rehenes> mapasRehenes;

        /// <summary>
        /// Propiedad estatica de la lista de jugadores
        /// </summary>
        public static List<Jugador> ListaJugadores
        {
            get { return listaJugadores; }
            set 
            { 
                if (value != null)
                {
                   listaJugadores = value;
                }
            }
        }

        /// <summary>
        /// Propiedad estatica de la lista de mapas bomba
        /// </summary>
        public static List<Bomba> MapasBomba
        {
            get { return mapasBomba; }
            set
            {
                if (value != null)
                {
                    mapasBomba = value;
                }
            }
        }

        /// <summary>
        /// Propiedad estatica de la lista de mapas rehenes
        /// </summary>
        public static List<Rehenes> MapasRehenes
        {
            get { return mapasRehenes; }
            set
            {
                if (value != null)
                {
                    mapasRehenes = value;
                }
            }
        }

        /// <summary>
        /// Propiedad estatica de la lista de mapas deathmatch
        /// </summary>
        public static List<Deathmatch> MapasDeathmatch
        {
            get { return mapasDeathmatch; }
            set
            {
                if (value != null)
                {
                    mapasDeathmatch = value;
                }
            }
        }

        /// <summary>
        /// Propiedad estatica readonly del patrocinador del torneo
        /// </summary>
        public static string Patrocinio
        {
            get { return patrocinio; }
        }

        /// <summary>
        /// Propiedad estatica readonly del premio del torneo
        /// </summary>
        public static double Premio
        {
            get { return premio; }
        }

        /// <summary>
        /// Propiedad estatica readonly del nombre del torneo
        /// </summary>
        public static string NombreTorneo
        {
            get { return nombreTorneo; }
        }

        /// <summary>
        /// Constructor estatico de la clase TorneoPro
        /// </summary>
        static TorneoPro()
        {
            nombreTorneo = "TorneoPRO : CSGO";
            premio = 1000000;
            patrocinio = "EASport";
            listaJugadores = new List<Jugador>();
            CargarJugadores();
            CargarMapas();
        }

        /// <summary>
        /// Metodo que carga la lista de jugadores desde un archivo json
        /// </summary>
        private static void CargarJugadores()
        {
            listaJugadores = SerializacionJson<List<Jugador>>.Leer("listaJugadores.json");
            if (listaJugadores==null)
            {
                throw new Exception_SerializacionJson("No se deserializo la lista inicial");
            }
        }

        /// <summary>
        /// Metodo que carga la lista de mapas desde un archivo json
        /// </summary>
        private static void CargarMapas()
        {
            mapasDeathmatch = SerializacionJson<List<Deathmatch>>.Leer("mapasDeathmatch.json");
            mapasBomba = SerializacionJson<List<Bomba>>.Leer("mapasBomba.json");
            mapasRehenes = SerializacionJson<List<Rehenes>>.Leer("mapasRehenes.json");
            if (mapasDeathmatch == null || mapasBomba == null || mapasRehenes == null)
            {
                throw new Exception_SerializacionJson("No se deserializo la lista inicial");
            }
        }

        /// <summary>
        /// Metodo que chequea en la lista de jugadores si existe el numero de jugador
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>True si existe el numero o false si no</returns>
        public static bool ExisteJugador(int numero)
        {
            foreach (Jugador item in listaJugadores)
            {
                if (item.NroJugador == numero)
                {
                    return true;
                }
            }
            return false;
        }        

        /// <summary>
        /// Agrega un jugador a la lista si cumple las caracteristicas
        /// </summary>
        /// <param name="nroJugador">Nro del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        /// <param name="edad">Edad del jugador</param>
        /// <param name="genero">Genero del jugador</param>
        /// <param name="nacionalidad">Nacionalidad del jugador</param>
        /// <param name="especialidad">Especialidad del jugador</param>
        /// <param name="primerTorneo">False si ya jugo el torneo o true si es la primera vez</param>
        /// <exception cref="Exception_NroJugadorYaExiste">Error si el numero identificador ya existe</exception>
        /// <exception cref="Exception_ErrorAgregarJugador">Error si no se puedo cargar al jugador</exception>
        public static void AgregarJugador(string nroJugador, string nombre, string edad, string genero, string nacionalidad, string especialidad, bool primerTorneo)
        {
            if (!string.IsNullOrEmpty(nroJugador) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(edad) && !string.IsNullOrEmpty(genero) && !string.IsNullOrEmpty(nacionalidad) && !string.IsNullOrEmpty(especialidad))
            {
                int.TryParse(nroJugador, out int auxNroJugador);
                if (ExisteJugador(auxNroJugador))
                {
                    throw new Exception_NroJugadorYaExiste("Error el nro de jugador ya existe");
                }
                int.TryParse(edad, out int auxEdad);                

                listaJugadores.Add(new Jugador(auxNroJugador, nombre, auxEdad, genero, nacionalidad, especialidad, primerTorneo));
            }
            else
            {
                throw new Exception_ErrorAgregarJugador("Error al intentar agregar un jugador");
            }
        }

        /// <summary>
        /// Edita los datos de un jugador de la lista por los nuevos pasados por parametro
        /// </summary>
        /// <param name="auxJugador">Jugador personalizado</param>
        public static void EditarJugador(Jugador auxJugador)
        {
            if (auxJugador != null)
            {
                foreach (Jugador jugador in listaJugadores)
                {
                    if (jugador.NroJugador == auxJugador.NroJugador)
                    {
                        jugador.Nombre = auxJugador.Nombre;
                        jugador.Edad = auxJugador.Edad;
                        jugador.Genero = auxJugador.Genero;
                        jugador.Nacionalidad = auxJugador.Nacionalidad;
                        jugador.Especialidad = auxJugador.Especialidad;
                        jugador.PrimerTorneo = auxJugador.PrimerTorneo;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception_EditarJugador("Error al intentar editar un jugador");
            }
        }

        /// <summary>
        /// Elimina el juegador seleccionado
        /// </summary>
        /// <param name="auxJugador">Jugador a eliminar</param>
        public static void EliminarJugador(Jugador auxJugador)
        {
            if (auxJugador != null)
            {
                foreach (Jugador jugador in listaJugadores)
                {
                    if (jugador.NroJugador == auxJugador.NroJugador)
                    {
                        listaJugadores.Remove(jugador);
                        break;
                    }
                }
            }
            else
            {
                throw new Exception_EliminarJugador("Error al intentar eliminar un jugador");
            }
        }

        /// <summary>
        /// Imprime listas
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>La lista como string</returns>
        public static string Imprimir(List<Jugador> lista)
        {
            StringBuilder jugador = new StringBuilder();

            foreach (Jugador item in lista)
            {
                jugador.AppendLine(item.ToString());
            }

            return jugador.ToString();
        }


    }
}
