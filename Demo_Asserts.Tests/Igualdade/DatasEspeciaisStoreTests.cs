using System;
using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class DatasEspeciaisStoreTests
    {
        [Test]
        public void DeveRetornarCorretamenteAnoNovo()
        {
            var sut = new DatasEspeciaisStore();
            var resultado = sut.Data(DatasEspeciais.AnoNovo);
            
             Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0)));
        }

        [Test]
        // usando within "Tolerancia"
        public void DeveRetornarCorretamenteAnoNovo_Within()
        {
            var sut = new DatasEspeciaisStore();
            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            // gera falha não esta esperando 1 milesimo de segundo
            // Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0,1)));

            //Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);

            // outra forma:
            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));

        }
    }
}