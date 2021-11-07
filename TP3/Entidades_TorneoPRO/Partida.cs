using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Partida : IAwp, IBomba, IRehenes
    {
        Random random;
        private int kills;
        private int muertes;

        /// <summary>
        /// Construtor de partida
        /// </summary>
        public Partida()
        {
            random = new Random();
        }

        /// <summary>
        /// Simula todas las partidas del torneo
        /// </summary>
        public bool SimularPartidas(List<Jugador> lista)
        {
            if (lista != null)
            {
                foreach (Bomba mBomba in TorneoPro.MapasBomba)
                {
                    foreach (Jugador auxJugador in lista)
                    {
                        kills = random.Next(0, 30);
                        muertes = random.Next(0, 30);
                        auxJugador.Estadistica.Actualizar(kills, muertes, 0, BombasPlantadas(), 0);
                        mBomba.Estadistica.Actualizar(kills, muertes, 0, BombasPlantadas(), 0);
                    }
                }

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

                foreach (Rehenes mRehenes in TorneoPro.MapasRehenes)
                {
                    foreach (Jugador auxJugador in lista)
                    {
                        kills = random.Next(0, 30);
                        muertes = random.Next(0, 30);
                        auxJugador.Estadistica.Actualizar(kills, muertes, 0, 0, RehenesRescatados());
                        mRehenes.Estadistica.Actualizar(kills, muertes, 0, 0, RehenesRescatados());
                    }
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calcula muertes por headshot por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int CantidadHeadshot()
        {
            return random.Next(0, 20);
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

    }
}
