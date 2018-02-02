using System;
using System.Collections.Generic;

namespace Demo_Asserts
{
    public class CaracteristicasJogador
    {
        public CaracteristicasJogador()
        {
            Nome = GearNome();
            NovoJogador = true;
            CriarArmasEspeciais();
        }



        public int Vida { get; set; }
        public string Nome { get; set; }
        public bool NovoJogador { get; set; }
        public string Apelido { get; set; }
        public List<string> Armas { get; set; }

        public void Dormir()
        {
            var random = new Random();
            var aumentaVida = random.Next(1, 101);
            Vida += aumentaVida;
        }

        public void PerderVida(int perderVida) => Vida = Math.Max(1, Vida -= perderVida);

        private void CriarArmasEspeciais() => Armas = new List<string>
        {
            "Agilidade", "Agilidade Força", "Força", "Inteligencia Artificial", "Teia de Aranha",/*,"Voar"*/
        };

        private string GearNome()
        {
            var nomes = new[] { "Batman", "Spider-Man", "Home de Ferro", "Capitao-America", "Homem Formiga", "Hulk" };
            return nomes[new Random().Next(0, nomes.Length)];
        }


    }
}