using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entidades
{
    /// <summary>
    /// Unidad 12 – Tipos genéricos 
    /// Unidad 14 – Archivos 
    /// Unidad 15 - Serialización 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Serializador<T>
        where T : class, new()
    {
        /// <summary>
        /// Serializa en formato JSON un objeto y lo guarda en un archivo
        /// </summary>
        /// <param name="filePath">Ruta del directorio donde se encuentra el archivo</param>
        /// <param name="objetoASerializar">Objeto a serializar en formato JSON</param>
        public void SerializarJsonYGuardar(string filePath, T objetoASerializar)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string objetoSerializado = JsonSerializer.Serialize(objetoASerializar, typeof(T), opciones);
            ManejadorArchivos.Guardar(filePath, objetoSerializado);
        }

        /// <summary>
        /// Des-serializa un objeto que se encuentra en formato JSON en un archivo
        /// </summary>
        /// <param name="filePath">Ruta del directorio donde se encuentra el archivo</param>
        /// <returns>Instancia del objeto des-serializado</returns>
        public T LeerJson(string filePath)
        {
            string json = ManejadorArchivos.Leer(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
