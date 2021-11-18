using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Bomba : Mapa, IBomba
    {
        private Estadistica eBomba;

        /// <summary>
        /// Rstadistica Mapas
        /// </summary>
        public Estadistica Estadistica
        {
            get { return eBomba; }
            set { this.eBomba = value; }
        }

        /// <summary>
        /// Constructor de mapa de bombas
        /// </summary>
        /// <param name="nombre">Nombre del mapa</param>
        /// <param name="estilo">Estilo de mapa</param>
        public Bomba(string nombre, ETipo estilo) : base(nombre, ETipo.Bombas)
        {
            this.eBomba = new Estadistica();
        }

        /// <summary>
        /// Calcula la cantidad total de bombas plantadas en este tipo de mapas
        /// </summary>
        /// <returns>La cantidad total de bombas plantadas</returns>
        public int BombasPlantadas()
        {
            int acumulador = 0;
            foreach (Jugador item in TorneoPro.ListaJugadores)
            {
                acumulador += item.Estadistica.Bombas;
            }
            return acumulador;
        }
    }
}
