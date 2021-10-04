using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor de ciclomotor
        /// </summary>
        /// <param name="marca">Marca del ciclomotor</param>
        /// <param name="chasis">Chasis del ciclomotor</param>
        /// <param name="color">Color del ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, color, marca)
        {

        }
        
        /// <summary>
        /// Propiedades Tamaño: Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Muestra los datos del ciclomotor
        /// </summary>
        /// <returns>Retorna los datos del ciclomotor como string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
