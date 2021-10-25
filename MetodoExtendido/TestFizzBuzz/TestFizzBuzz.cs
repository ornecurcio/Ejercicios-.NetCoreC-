using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades; 

namespace TestFizzBuzz
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor3_DeberiaRetornarFizz()
        {
            //Arrange 
            int numero = 6;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor5_DeberiaRetornarBuzz()
        {
            //Arrange 
            int numero = 10;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor3y5_DeberiaRetornarFizzBuzz()
        {
            //Arrange 
            int numero = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoNoEsDivisiblePor3y5_DeberiaRetornarNumero()
        {
            //Arrange 
            int numero = 4;
            string expected = numero.ToString();

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
