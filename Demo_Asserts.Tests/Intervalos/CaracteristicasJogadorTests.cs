using NUnit.Framework;

namespace Demo_Asserts.Tests.Intervalos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void DevoAumentarVidaDoJogadorDepoisDormir()  // sempre vai passar 
        {
            var sut = new CaracteristicasJogador
            {
                Vida = 100
            };

            sut.Dormir();
            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

        [Test]
        public void DevoAumentarVidaDoJogadorDepoisDormir_Intervalo()  
        {
            var sut = new CaracteristicasJogador
            {
                Vida = 100
            };

            sut.Dormir();  

            Assert.That(sut.Vida, Is.InRange(101,200)); // deve ganhar pontos ao dormir 
        }

    }
}