using NUnit.Framework;
using System.Linq;

namespace Demo_Asserts.Tests.Colecoes
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void NaoDevoTerListaDeArmasVazia()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Is.All.Not.Empty);
        }

        [Test]
        public void DeveTerArmaTeiaDeAranh()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Contains.Item("Teia de Aranha"));
        }

        [Test]
        public void DeveConterPeloMenosUmTipoArtificial()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Has.Some.Contains("Artificial")); // deve conter pelo menos um "Artificial" na coleção
        }

        //Método responsável por testar se tem um número específico de determinados itens:
        [Test]
        public void DeveConterDuasArmasDeForca()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Has.Exactly(2).EndWith("Força"));
        }

        //Método responsável por testar se os itens contidos na lista são únicos:
        [Test]
        public void NaoDeveContarMaisTiposDeArmasNoJogo()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Is.Unique);
        }

        //Método responsável por testar se os itens contidos na lista são únicos:
        [Test]
        public void NaoDeveConterArmaVoar()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Has.None.EqualTo("Voar"));
        }

        [Test]
        public void DeveCOnterExatamenteTodasArmas()
        {
            var sut = new CaracteristicasJogador();
            var listaArmasEsperadas = new[]
                {"Agilidade", "Força", "Agilidade Força", "Teia de Aranha", "Inteligencia Artificial"};

            Assert.That(sut.Armas, Is.EquivalentTo(listaArmasEsperadas));
        }

        [Test]
        public void ArmasDevemEstarOrdemAlfabetica()
        {
            var sut = new CaracteristicasJogador();
            Assert.That(sut.Armas, Is.Ordered);
        }

    }
}