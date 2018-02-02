using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTests
    {
        [Test]
        public void DevoJuntarNomes()
        {
            var sut = new JuntarNomes();
            var resultado = sut.Juntar("Antonio Carlos", "Pinheiro");

            Assert.That(resultado, Is.EqualTo("Antonio Carlos Pinheiro"));
        }

        [Test]
        public void DevoJuntarNomes_CaseSensitive()
        {
            var sut = new JuntarNomes();
            var resultado = sut.Juntar("antonio carlos", "pinheiro");

            Assert.That(resultado, Is.EqualTo("ANTONIO CARLOS PINHEIRO").IgnoreCase);
        }

        [Test]
        public void DevoJuntarNomes_NaoIgual()
        {
            var sut = new JuntarNomes();
            var resultado = sut.Juntar("Joana", "Pinheiro");

            Assert.That(resultado, Is.Not.EqualTo("Anderson Pinheiro"));
        }
    }
}