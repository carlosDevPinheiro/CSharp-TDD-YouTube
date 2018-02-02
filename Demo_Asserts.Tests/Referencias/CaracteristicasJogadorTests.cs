using NUnit.Framework;

namespace Demo_Asserts.Tests.Referencias
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void CompararReferenciaDeObjeto()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            var temp = jogador1;

            // Assert.That(jogador, Is.SameAs(jogador1)); // se duas referencia são do mesmo objeto
            Assert.That(temp, Is.Not.SameAs(jogador2));
        }
    }
}