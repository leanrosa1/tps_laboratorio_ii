using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_unitarias
{
    [TestClass]
    public class TestVecino
    {
        /// <summary>
        /// Unidad 11 – Pruebas unitarias 
        /// </summary>
        [TestMethod]
        public void AgregarReclamo_CuandoRecibeUnReclamoNotNull_DeberiaAgregarloALaLista()
        {
            Vecino vecino = new Vecino();
            Reclamo reclamo = new Reclamo();
            int expected = 1;
            int actual;

            vecino.AgregarReclamo(reclamo);
            actual = vecino.Reclamos.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AgregarReclamo_CuandoRecibeUnReclamoNull_NoDeberiaAgregarloALaLista()
        {
            Vecino vecino = new Vecino();
            Reclamo reclamo = null;
            int expected = 0;
            int actual;

            vecino.AgregarReclamo(reclamo);
            actual = vecino.Reclamos.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
