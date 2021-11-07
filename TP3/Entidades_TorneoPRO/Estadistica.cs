using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Estadistica
    {
        private int puntos;
        private int kills;
        private int muertes;
        private int headshot;
        private int bomba;
        private int rehenes;

        /// <summary>
        /// Propiedad readonly de puntos
        /// </summary>
        public int Puntos { get { return puntos; } }

        /// <summary>
        /// Propiedad readonly de kills
        /// </summary>
        public int Kills { get { return this.kills; } }

        /// <summary>
        /// Propiedad readonly de muerte propia
        /// </summary>
        public int Muerte { get { return this.muertes; }  }

        /// <summary>
        /// Propiedad readonly de headshot
        /// </summary>
        public int Headshot { get { return this.headshot; } }

        /// <summary>
        /// Propiedad readonly de bombas plantadas
        /// </summary>
        public int Bombas { get { return this.bomba; }  }

        /// <summary>
        /// Propiedad readonly de rehenes
        /// </summary>
        public int Rehenes { get { return this.rehenes; } }

        /// <summary>
        /// Constructor por defecto de estadistica
        /// </summary>
        public Estadistica()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="puntos">puntos obtenidos</param>
        /// <param name="kills">muertes ocasionadas</param>
        /// <param name="muertes">muertes recibidas</param>
        /// <param name="headshot">headshot hechos</param>
        /// <param name="bomba">bombas plantadas</param>
        /// <param name="rehenes">rehenes rescatados</param>
        public Estadistica(int puntos, int kills, int muertes, int headshot, int bomba, int rehenes) : this()
        {
            this.puntos = puntos;
            this.kills = kills;
            this.muertes = muertes;
            this.headshot = headshot;
            this.bomba = bomba;
            this.rehenes = rehenes;
        }



        /// <summary>
        /// Acumula los puntos por partida y las estadisticas
        /// </summary>
        /// <param name="kills">kills hechas</param>
        /// <param name="muertes">muertes recibidas</param>
        /// <param name="headshot">headshot hechas</param>
        /// <param name="bombas">bombas plantadas</param>
        /// <param name="rehenes">rehenes rescatados</param>
        public void Actualizar(int kills, int muertes, int headshot, int bombas, int rehenes)
        {
            int acumuladorPuntos = 0;

            this.kills += kills;
            this.muertes += muertes;
            this.headshot += headshot;
            this.bomba += bombas;
            this.rehenes += rehenes;

            acumuladorPuntos = (kills + (headshot * 2) + (bombas*3) + (rehenes*3)) - (muertes*2);
            this.puntos += acumuladorPuntos;
        }

    }
}
