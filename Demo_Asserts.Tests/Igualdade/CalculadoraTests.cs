using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void DeveSomarNumerosInteiros()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosInteiros(4, 2);
            Assert.That(resultado,Is.EqualTo(6));
        }

        [Test]
        public void DeveSomarNumerosDouble()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);
            Assert.That(resultado, Is.EqualTo(3.3).Within(0.01)); // se resultado entre 3.29 e 3.31 teste ok!
        }


        [Test]
        public void DeveSomarNumerosDouble_UsandoWithinPorcentagem()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(50, 50);
            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent); // tolerancia de 1%
        }

        [Test]
        public void DevoSomarNumerosDecimais_NaoBomExemploWithin()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);

            // nao deveria passar
            Assert.That(resultado, Is.EqualTo(30).Within(100)); // qualquer lugar entre -70 e 130
        }
    }
}