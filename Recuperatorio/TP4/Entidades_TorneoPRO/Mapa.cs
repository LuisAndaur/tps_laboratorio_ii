using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public abstract class Mapa
    {
        private string nombre;
        private ETipo estilo;        

        public enum ETipo { Bombas, Rehenes, Deahtmatch}

        /// <summary>
        /// Estilo de mapa
        /// </summary>
        public ETipo Estilo
        {
            get { return estilo; }
        }

        /// <summary>
        /// Nombre del mapa
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }        

        /// <summary>
        /// Constructor por defecto del mapa
        /// </summary>
        public Mapa()
        {

        }

        /// <summary>
        /// Constructor con parametros del mapa
        /// </summary>
        /// <param name="nombre">Nombre del mapa</param>
        /// <param name="estilo">Tipo de mapa</param>
        public Mapa(string nombre, ETipo estilo) : this()
        {
            this.nombre = nombre;
            this.estilo = estilo;            
        }

    }
}
