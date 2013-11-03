using _002_Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _004_UnitTest
{
    /// <summary>
    ///This is a test class for CalculadoraTest and is intended
    ///to contain all CalculadoraTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculadoraTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Somar
        ///</summary>
        [TestMethod()]
        public void SomarTest()
        {
            double x = 5;
            double y = 3;
            double expected = 8;
            double actual = Calculadora.Somar(x, y);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Subtrair
        ///</summary>
        [TestMethod()]
        public void SubtrairTest()
        {
            double x = 5;
            double y = 3;
            double expected = 2;
            double actual;
            actual = Calculadora.Subtrair(x, y);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Multiplicar
        ///</summary>
        [TestMethod()]
        public void MultiplicarTest()
        {
            double x = 5;
            double y = 3;
            double expected = 15;
            double actual;
            actual = Calculadora.Multiplicar(x, y);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Dividir
        ///</summary>
        [TestMethod()]
        public void DividirTest()
        {
            double x = 5;
            double y = 2;
            double expected = 2.5;
            double actual;
            actual = Calculadora.Dividir(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ExtrairRaizTest()
        {
            double x = 9;
            double y = 2;
            double expected = 3;
            double actual;
            actual = Calculadora.ExtrairRaiz(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
