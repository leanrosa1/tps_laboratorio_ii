using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Unidad 14 – Archivos 
    /// </summary>
    public static class ManejadorArchivos
    {
        /// <summary>
        /// Lee contenido del archivo 
        /// Unidad 10 – Excepciones 
        /// </summary>
        /// <param name="filePath">Ruta del directorio donde se encuentra el archivo a leer</param>
        /// <returns> String con el contenido del archivo </returns>
        public static string Leer(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Guarda un contenido (string) en un archivo
        /// Unidad 10 – Excepciones 
        /// </summary>
        /// <param name="filePath">Ruta del directorio donde se encuentra el archivo a leer</param>
        /// <param name="contenido">Contenido a guardar</param>
        public static void Guardar(string filePath, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(contenido);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
