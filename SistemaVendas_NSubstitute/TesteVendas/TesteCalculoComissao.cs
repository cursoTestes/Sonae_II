using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas;


namespace TesteVendas
{
    [TestClass]
    public class TesteCalculoComissao
    {
        [TestMethod]
        public void ValidarVendaDezMil()
        {
            decimal valorVenda = 10000;
            decimal valorEsperado = 500;

            CalculadoraComissao calculadora = new CalculadoraComissao();
            decimal resultado = calculadora.calcular(valorVenda);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void ValidarQueDecimalEFixe()
        {
            decimal valorVenda = 1;
            decimal valorEsperado = 0.05m;

            CalculadoraComissao calculadora = new CalculadoraComissao();
            decimal resultado = calculadora.calcular(valorVenda);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void ValorMaiorQue10000()
        {
            decimal valorVenda = 20000;
            decimal valorEsperado = 1200;

            CalculadoraComissao calculadora = new CalculadoraComissao();
            decimal resultado = calculadora.calcular(valorVenda);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        public void ValorSemPerda()
        {
            decimal valorVenda = 55.59m;
            decimal valorEsperado = 2.77m;

            CalculadoraComissao calculadora = new CalculadoraComissao();
            decimal resultado = calculadora.calcular(valorVenda);

            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}
