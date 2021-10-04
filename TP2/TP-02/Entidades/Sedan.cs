using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {        
        ETipo tipo;

        /// <summary>
        /// Constructor sedan
        /// </summary>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="chasis">Chasis del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        /// <param name="tipo">tipo del vehiculo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, color, marca)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor sedan: Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="chasis">Chasis del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }

        /// <summary>
        /// Enumerado de tipo de vehiculo
        /// </summary>
        public enum ETipo
        { 
            CuatroPuertas, 
            CincoPuertas 
        }

        /// <summary>
        /// Propiedad tamaño: Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra los datos del sedan
        /// </summary>
        /// <returns>Retorna los datos del sedan en formato string</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine($"TIPO :  {this.tipo}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
