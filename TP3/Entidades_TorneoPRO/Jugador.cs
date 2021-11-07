using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Jugador
    {
        private int nroJugador;
        private string nombre;
        private int edad;
        private string genero;
        private string nacionalidad;
        private string especialidad;
        private bool primerTorneo;
        private Estadistica eJugador;

        /// <summary>
        /// Propiedad numero identificador del jugador
        /// </summary>
        public int NroJugador
        {
            get { return nroJugador; }
            set
            {
                if (value > 0)
                {
                    nroJugador = value;
                }
            }
        }

        /// <summary>
        /// Propiedad nombre del jugador
        /// </summary>
        /// <exception cref="Exception_StringNullOrEmpty">Error si el nombre viene vacio o null</exception>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception_StringNullOrEmpty("Error campo vacío o null");
                }
            }
        }

        /// <summary>
        /// Propiedad edad del jugador
        /// </summary>
        /// <exception cref="Exception_EdadInvalida">Error si la edad esta fuera de rango</exception>
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 11 && value < 80)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception_EdadInvalida("Error la edad esta fuera de rango");
                }
            }
        }

        /// <summary>
        /// Propiedad genero del jugador
        /// </summary>
        /// <exception cref="Exception_GeneroInvalido">Error si el genero es incorrecto</exception>
        public string Genero
        {
            get { return genero; }
            set
            {
                if (value.Trim() == "Female" || value.Trim() == "Male")
                {
                    genero = value;
                }
                else
                {
                    throw new Exception_GeneroInvalido("Error genero incorrecto");
                }
            }
        }

        /// <summary>
        /// Propiedad nacionalidad del jugador
        /// </summary>
        /// <exception cref="Exception_StringNullOrEmpty">Error si la nacionalidad viene vacio o null</exception>
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nacionalidad = value;
                }
                else
                {
                    throw new Exception_StringNullOrEmpty("Error campo vacío o null");
                }
            }
        }

        /// <summary>
        /// Propiedad Especialidad del jugador
        /// </summary>
        /// <exception cref="Exception_EspecialidadFueraDeRango">Error si la especialidad no es correcta</exception>
        public string Especialidad
        {
            get { return especialidad; }
            set 
            {
                if (value == "XS" || value == "S" || value == "M" || value == "L" || value == "XL" || value == "XXL")
                {
                    especialidad = value;
                }
                else
                {
                    throw new Exception_EspecialidadFueraDeRango("Error la especialidad no coincide");
                }
            }
        }

        /// <summary>
        /// Propiedad Primer Torneo del jugador
        /// </summary>
        public bool PrimerTorneo
        {
            get { return primerTorneo; }
            set
            {
                if (value || !value)
                {
                    primerTorneo = value;
                }
            }
        }

        /// <summary>
        /// Estadisticas del jugador
        /// </summary>
        public Estadistica Estadistica 
        {
            get {return eJugador; }
            set {this.eJugador = value; } 
        }

        /// <summary>
        /// Constructor de jugador por defecto vacio
        /// </summary>
        public Jugador()
        {
            this.eJugador = new Estadistica();
        }

        /// <summary>
        /// Constructor jugador con parametros
        /// </summary>
        /// <param name="nroJugador">Nro identificador jugador</param>
        /// <param name="nombre">nombre jugador></param>
        /// <param name="edad">edad del jugador</param>
        /// <param name="genero">genero del jugador</param>
        /// <param name="nacionalidad">acionalidad del jugador</param>
        /// <param name="especialidad">especialidad del jugador</param>
        /// <param name="primerTorneo">primer torneo del jugador</param>
        public Jugador(int nroJugador, string nombre, int edad, string genero, string nacionalidad, string especialidad, bool primerTorneo) : this()
        {
            this.NroJugador = nroJugador;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
            this.Especialidad = especialidad;
            this.PrimerTorneo = primerTorneo;
            this.eJugador = new Estadistica();
        }

        /// <summary>
        /// Calcula el jugador con mas puntos
        /// </summary>
        /// <returns>El jugador con mas puntos</returns>
        public static Jugador Campeon(List<Jugador> lista)
        {
            Jugador auxJugador = new Jugador();
            int maximo = -5000;
            if (lista != null && lista.Count != 0)
            {
                foreach (Jugador item in lista)
                {
                    if (item.Estadistica.Puntos > maximo)
                    {
                        maximo = item.Estadistica.Puntos;
                        auxJugador = item;
                    }
                }
                return auxJugador;
            }
            return null;
        }

        /// <summary>
        /// Sobrecarga metodo toString
        /// </summary>
        /// <returns>Objeto como string</returns>
        public override string ToString()
        {
            StringBuilder jugador = new StringBuilder();
            jugador.AppendLine($"Nro: {this.NroJugador}");
            jugador.AppendLine($"Nombre: {this.Nombre}");
            jugador.AppendLine($"Edad: {this.Edad}");
            jugador.AppendLine($"Genero: {this.Genero}");
            jugador.AppendLine($"Nacionalidad: {this.Nacionalidad}");
            jugador.AppendLine($"Especialidad: {this.Especialidad}");
            jugador.AppendLine($"Primer Torneo: {this.PrimerTorneo}");
            jugador.AppendLine($"Puntos: {this.eJugador.Puntos}");
            jugador.Append($"Kills: {this.eJugador.Kills}");
            jugador.Append($" | Muertes: {this.eJugador.Muerte}");
            jugador.Append($" | Headshot: {this.eJugador.Headshot}");
            jugador.Append($" | Bombas: {this.eJugador.Bombas}");
            jugador.AppendLine($" | Rehenes: {this.eJugador.Rehenes}");
            jugador.Append($"-----------------------------------------------------------------");
            return jugador.ToString();
        }

        /// <summary>
        /// Lista ordenada por puntos obtenidos
        /// </summary>
        /// <returns>lista total desde el mejor al mas manco</returns>
        public static List<Jugador> PorPuntos(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();

            auxlista1 = lista;
            auxlista1 = auxlista1.OrderByDescending(x => x.Estadistica.Puntos).ToList();

            return auxlista1;
        }

        /// <summary>
        /// Top 5 mejores asesinos del torneo
        /// </summary>
        /// <returns>lista con los mejores asesinos</returns>
        public static List<Jugador> MasKills(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();
            List<Jugador> auxlista2 = new List<Jugador>();

            auxlista2 = lista;
            auxlista2 = auxlista2.OrderByDescending(x => x.Estadistica.Kills).ToList();

            for (int i = 0; i < 5; i++)
            {
                auxlista1.Add(auxlista2[i]);
            }

            return auxlista1;
        }

        /// <summary>
        /// Top 5 peores jugadores del torneo
        /// </summary>
        /// <returns>lista con los peores jugadores</returns>
        public static List<Jugador> MasMancos(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();
            List<Jugador> auxlista2 = new List<Jugador>();

            auxlista2 = lista;
            auxlista2 = auxlista2.OrderByDescending(x => x.Estadistica.Muerte).ToList();

            for (int i = 0; i < 5; i++)
            {
                auxlista1.Add(auxlista2[i]);
            }

            return auxlista1;
        }

        /// <summary>
        /// Jugadores que juegan su primer torneo
        /// </summary>
        /// <returns>lista con los jugadores que juegan su primer torneo</returns>
        public static List<Jugador> ListaPrimerTorneo(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();
            List<Jugador> auxlista2 = lista;

            foreach (Jugador item in auxlista2)
            {
                if (item.PrimerTorneo)
                {
                    auxlista1.Add(item);
                }
            }

            return auxlista1;
        }

        /// <summary>
        /// Top 5 mayores plantadores de bomba del torneo
        /// </summary>
        /// <returns>lista con los mayores plantadores de bombas</returns>
        public static List<Jugador> Bombarderos(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();
            List<Jugador> auxlista2 = new List<Jugador>();

            auxlista2 = lista;
            auxlista2 = auxlista2.OrderByDescending(x => x.Estadistica.Bombas).ToList();

            for (int i = 0; i < 5; i++)
            {
                auxlista1.Add(auxlista2[i]);
            }

            return auxlista1;
        }

        /// <summary>
        /// Top 5 mayores rescatistas de rehenes del torneo
        /// </summary>
        /// <returns>lista con losmayores rescatistas de rehenes</returns>
        public static List<Jugador> Rescatistas(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();
            List<Jugador> auxlista2 = new List<Jugador>();

            auxlista2 = lista;
            auxlista2 = auxlista2.OrderByDescending(x => x.Estadistica.Bombas).ToList();

            for (int i = 0; i < 5; i++)
            {
                auxlista1.Add(auxlista2[i]);
            }

            return auxlista1;
        }

        /// <summary>
        /// Jugadores XXL mayores headshots del torneo
        /// </summary>
        /// <returns>lista con los jugadores XXL mayores headshots</returns>
        public static List<Jugador> XxlHeadshots(List<Jugador> lista)
        {
            List<Jugador> auxlista1 = new List<Jugador>();
            List<Jugador> auxlista2 = new List<Jugador>();

            auxlista2 = lista;
            auxlista2 = auxlista2.OrderByDescending(x => x.Estadistica.Headshot).ToList();

            foreach (Jugador item in auxlista2)
            {
                if (item.Especialidad == "XXL")
                {
                    auxlista1.Add(item);
                }
            }

            return auxlista1;
        }

        /// <summary>
        /// Calcula el jugador mas joven del torneo
        /// </summary>
        /// <returns>El jugador mas joven</returns>
        public static Jugador MasJoven(List<Jugador> lista)
        {
            Jugador auxJugador = new Jugador();
            int minimo = 100;
            foreach (Jugador item in lista)
            {
                if (item.Edad < minimo)
                {
                    minimo = item.Edad;
                    auxJugador = item;
                }
            }
            return auxJugador;
        }
    }

}
