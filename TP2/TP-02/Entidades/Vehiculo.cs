using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        /// <summary>
        /// Constructor de vehiculo
        /// </summary>
        /// <param name="chasis">Chasis del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        /// <param name="marca">Marca del vehiculo</param>
        public Vehiculo(string chasis, ConsoleColor color, EMarca marca)
        {
            this.chasis = chasis;
            this.color = color;
            this.marca = marca;
        }

        /// <summary>
        /// Propiedad ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Enumerado de marcas de vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerado de tamaño de vehiculos
        /// </summary>
        protected enum ETamanio
        {
            Chico, Mediano, Grande
        }        

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Los datos obtenidos como tipo string</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Castea explicitamente los datos de un objeto vehiculo a tipo string
        /// </summary>
        /// <param name="p">Objeto tipo vehiculo</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Primer objeto vehiculo</param>
        /// <param name="v2">Segundo objeto vehiculo</param>
        /// <returns>Retorna true si son iguales, sino false</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Primer objeto vehiculo</param>
        /// <param name="v2">Segundo objeto vehiculo</param>
        /// <returns>Retorna true si no son iguales, sino false</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Sobrescribe el metodo para igualar objetos tipo vehiculo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Vehiculo)
            {
                return this == (Vehiculo)obj;
            }
            return false;
        }

        /// <summary>
        /// Sobreescribe el metodo para que sean iguales por tipo chasis
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return chasis.GetHashCode();
        }
    }
}
