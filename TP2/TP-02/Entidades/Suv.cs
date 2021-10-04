using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor del suv
        /// </summary>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="chasis">Chasis del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, color, marca)
        {

        }

        /// <summary>
        /// Propiedad tamaño: SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Muestra los datos del suv
        /// </summary>
        /// <returns>Retorna los datos como string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
