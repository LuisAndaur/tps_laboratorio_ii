using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Archivo<T>
    {
        static string path;

        static Archivo()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }               

        /// <summary>
        /// Toma datos desde un archivo txt
        /// </summary>
        /// <returns>datos obtenidos</returns>
        public static string Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("Archivos_01"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            string line;

                            while ((line = sr.ReadLine()) != null)
                            {
                                informacionRecuperada += "\n" + line;
                            }

                        }
                    }
                }

                return informacionRecuperada;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

        /// <summary>
        /// Escribe datos a un archivo txt
        /// </summary>
        /// <param name="datos">datos a guardar</param>
        /// <param name="path">ruta donde se guarda</param>
        public static void Escribir(T datos, string path)
        {
            try
            {        
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(datos);
                    sw.WriteLine("La fecha es: ");
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine("-----------------------------");
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Escribe datos a un archivo txt
        /// </summary>
        /// <param name="datos">datos recibidos como string</param>
        /// <param name="path">ruta donde se guarda</param>
        public static void Escribir(string datos, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(datos);
                    sw.WriteLine("La fecha es: ");
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine("-----------------------------");
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }
    }
}
