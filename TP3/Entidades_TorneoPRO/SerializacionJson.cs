using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public static class SerializacionJson<T>
    {
        /// <summary>
        /// Serializa a json con el nombre y en el directorio elegido por el usuario
        /// </summary>
        /// <param name="datos">datos a serializar</param>
        /// <param name="path">ruta de serializacion</param>
        public static void Escribir(T datos, string path)
        {
            try
            {                
                File.WriteAllText(path, JsonSerializer.Serialize(datos));
            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Deserializa desde un archivo predeterminado
        /// </summary>
        /// <param name="nombre">nombre del archivo</param>
        /// <returns>los datos deserializados</returns>
        public static T Leer(string nombre)
        {
            string path2 = $"{Environment.CurrentDirectory}\\{nombre}";
            string info = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {
                info = File.ReadAllText(path2);
                datosRecuperados = JsonSerializer.Deserialize<T>(info);
                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception_SerializacionJson($"Error en el archivo ubicado en {path2}", e);
            }

        }
    }
}
