using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreClinica;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

           List<Paciente> aux =  ConexionDB.TraerPacientes();


            Assert.IsNotNull(aux);
            Assert.IsTrue(aux.Count>0);

        }
    }
}
