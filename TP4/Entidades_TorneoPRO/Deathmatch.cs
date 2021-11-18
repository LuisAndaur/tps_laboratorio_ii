using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Deathmatch : Mapa, IAwp
    {
        private Estadistica eDeathmatch;

        /// <summary>
        /// Rstadistica Mapas
        /// </summary>
        public Estadistica Estadistica
        {
            get { return eDeathmatch; }
            set { this.eDeathmatch = value; }
        }

        /// <summary>
        /// Constructor de mapa batalla a muerte
        /// </summary>
        /// <param name="nombre">Nombre del mapa</param>
        /// <param name="estilo">Estilo de mapa</param>
        public Deathmatch(string nombre, ETipo estilo) : base(nombre, ETipo.Deahtmatch)
        {
            this.eDeathmatch = new Estadistica();
        }

        /// <summary>
        /// Calcula la cantidad total de muertes por headshot en este tipo de mapas
        /// </summary>
        /// <returns>La cantidad total de muertes por headshot</returns>
        public int CantidadHeadshot()
        {
            int acumulador = 0;
            foreach (Jugador item in TorneoPro.ListaJugadores)
            {
                acumulador += item.Estadistica.Headshot;
            }
            return acumulador;
        }
    }
}
