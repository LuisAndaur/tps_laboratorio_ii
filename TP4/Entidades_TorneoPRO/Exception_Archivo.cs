using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_Archivo : Exception
    {

        /// <summary>
        /// Crea una excepcion con un mensaje
        /// </summary>
        /// <param name="message">Mensaje de la excepcion</param>
        public Exception_Archivo(string message) : this(message, null)
        {

        }

        /// <summary>
        /// Crea una excepcion con un mensaje y un innerException
        /// </summary>
        /// <param name="message">Mensaje de la excepcion</param>
        /// <param name="innerException">innerException de la excepcion</param>
        public Exception_Archivo(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
