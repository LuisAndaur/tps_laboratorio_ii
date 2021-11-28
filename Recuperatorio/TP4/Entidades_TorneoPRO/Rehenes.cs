using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Rehenes : Mapa, IRehenes
    {
        private Estadistica eRehenes;

        /// <summary>
        /// Rstadistica Mapas
        /// </summary>
        public Estadistica Estadistica
        {
            get { return eRehenes; }
            set { this.eRehenes = value; }
        }

        /// <summary>
        /// Constructor de mapa de rehenes
        /// </summary>
        /// <param name="nombre">Nombre del mapa</param>
        /// <param name="estilo">Estilo de mapa</param>
        public Rehenes(string nombre, ETipo estilo) : base(nombre, ETipo.Rehenes)
        {
            this.eRehenes = new Estadistica();
        }

        /// <summary>
        /// Calcula la cantidad total de rehenes rescatados en este tipo de mapas
        /// </summary>
        /// <returns>La cantidad total de rehenes rescatados</returns>
        public int RehenesRescatados()
        {
            int acumulador = 0;
            foreach (Jugador item in TorneoPro.ListaJugadores)
            {
                acumulador += item.Estadistica.Rehenes;
            }
            return acumulador;
        }
    }
}
