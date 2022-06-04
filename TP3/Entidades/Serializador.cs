using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Serializador<T>
        where T : class, new()
    {
        public void SerializarJsonYGuardar(string filePath, T objetoASerializar)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string objetoSerializado = JsonSerializer.Serialize(objetoASerializar, typeof(T), opciones);
            ManejadorArchivos.Guardar(filePath, objetoSerializado);
        }

        public T LeerJson(string filePath)
        {
            string json = ManejadorArchivos.Leer(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
