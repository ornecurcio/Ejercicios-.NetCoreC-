using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System; 

namespace SimulacionApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Torneo.JugarPartido(0);

            Assert.AreEqual(Torneo.ListaEquipos[0].Estadistica.PartJugados, 1);
            Assert.AreEqual(Torneo.ListaEquipos[1].Estadistica.PartJugados, 1);
            Assert.AreEqual(Torneo.ListaEquipos[2].Estadistica.PartJugados, 1);
            Assert.AreEqual(Torneo.ListaEquipos[3].Estadistica.PartJugados, 1);

        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        
        public void
    }
}
