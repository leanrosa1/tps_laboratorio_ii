using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_unitarias
{
    /// <summary>
    /// Unidad 11 – Pruebas unitarias 
    /// </summary>
    [TestClass]
    public class TestSerializador
    {
        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void SerializarJsonYGuardar_CuandoElPathEsInexistente_DeberiaRetornarDirectoryNotFoundException()
        {
            Serializador<Vecino> serializador = new Serializador<Vecino>();
            Vecino vecino = new Vecino();

            serializador.SerializarJsonYGuardar("/pathIncorrecto/file.txt", vecino);
        }
    }
}
