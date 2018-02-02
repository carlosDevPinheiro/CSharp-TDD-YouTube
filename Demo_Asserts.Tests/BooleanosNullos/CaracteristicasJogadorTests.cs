using NUnit.Framework;

namespace Demo_Asserts.Tests.BooleanosNullos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void DevoGerarNomeRandomicoPorDeafult()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Nome, Is.Not.Empty);
        }

        [Test]
        public void DevoVerificarNovoJogador()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.NovoJogador, Is.True);
        }

        [Test]
        public void DeveVerificarApelidoJogador()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Apelido, Is.Null);
        }



    }
}