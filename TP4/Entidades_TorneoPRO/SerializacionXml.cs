using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades_TorneoPRO
{
    public class SerializacionXml<T>
    {
        static string path;

        static SerializacionXml()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }        

        /// <summary>
        /// Serializa con el nombre y path determinado por el usuario
        /// </summary>
        /// <param name="datos">dato a guardar</param>
        /// <param name="path">Ruta donde guardar</param>
        public static void Escribir(T datos, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }
            }
            catch (Exception_SerializacionXml eXml)
            {
                throw new Exception_SerializacionXml($"Error en el archivo ubicado en {path}", eXml);
            }
        }

        /// <summary>
        /// Deserializa los datos en una ruta especifica
        /// </summary>
        /// <returns></returns>
        public static T Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datos = default;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("SerializacionXml_01_"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

    }
}
