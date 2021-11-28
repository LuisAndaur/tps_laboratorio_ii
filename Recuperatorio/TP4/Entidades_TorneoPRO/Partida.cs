using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public delegate bool Simulacion(List<Jugador> lista);

    public class Partida : IAwp, IBomba, IRehenes
    {
        Random random;
        private int kills;
        private int muertes;
        public Simulacion simulador;

        /// <summary>
        /// Construtor de partida
        /// </summary>
        public Partida()
        {
            random = new Random();
            simulador += MapaBomba;
            simulador += MapaDeathmatch;
            simulador += MapaRehenes;
        }        

        /// <summary>
        /// Calcula muertes por headshot por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int CantidadHeadshot()
        {
            return random.Next(0, 10);
        }

        /// <summary>
        /// Calcula bombas plantadas por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int BombasPlantadas()
        { 
            return random.Next(0, 4); ;
        }

        /// <summary>
        /// Calcula rehenes rescatados por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int RehenesRescatados()
        {
            return random.Next(0, 3);
        }

        /// <summary>
        /// Simula las partidas en los mapas de bombas
        /// </summary>
        /// <param name="lista">lista de jugadores</param>
        public bool MapaBomba(List<Jugador> lista)
        {
            foreach (Bomba mBomba in TorneoPro.MapasBomba)
            {
                foreach (Jugador auxJugador in lista)
                {
                    kills = random.Next(0, 10);
                    muertes = random.Next(0, 10);
                    auxJugador.Estadistica.Actualizar(kills, muertes, 0, BombasPlantadas(), 0);
                    mBomba.Estadistica.Actualizar(kills, muertes, 0, BombasPlantadas(), 0);
                }
            }
            return true;
        }

        /// <summary>
        /// Simula las partidas en los mapas de deathmatch
        /// </summary>
        /// <param name="lista">lista de jugadores</param>
        public bool MapaDeathmatch(List<Jugador> lista)
        {
            foreach (Deathmatch mDeathmatch in TorneoPro.MapasDeathmatch)
            {
                foreach (Jugador auxJugador in lista)
                {
                    kills = random.Next(0, 30);
                    muertes = random.Next(0, 30);
                    auxJugador.Estadistica.Actualizar(kills, muertes, CantidadHeadshot(), 0, 0);
                    mDeathmatch.Estadistica.Actualizar(kills, muertes, CantidadHeadshot(), 0, 0);
                }
            }
            return true;
        }

        /// <summary>
        /// Simula las partidas en los mapas de rehenes
        /// </summary>
        /// <param name="lista">lista de jugadores</param>
        public bool MapaRehenes(List<Jugador> lista)
        {
            foreach (Rehenes mRehenes in TorneoPro.MapasRehenes)
            {
                foreach (Jugador auxJugador in lista)
                {
                    kills = random.Next(0, 10);
                    muertes = random.Next(0, 10);
                    auxJugador.Estadistica.Actualizar(kills, muertes, 0, 0, RehenesRescatados());
                    mRehenes.Estadistica.Actualizar(kills, muertes, 0, 0, RehenesRescatados());
                }
            }
            return true;
        }
    }
}
