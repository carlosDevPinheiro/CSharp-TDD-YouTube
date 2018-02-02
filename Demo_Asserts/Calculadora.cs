using System;

namespace Demo_Asserts
{
    public class Calculadora
    {
        public int SomarNumerosInteiros(int num1, int num2)
        {
            var resultado = num1 + num2;
            return resultado;
        }
        public double SomarNumerosDecimais(double num1, double num2) => num1 + num2;

        public int Dividir(int num, int por)
        {
            if (num > 100) throw new ArgumentOutOfRangeException(nameof(por)); // proposito para demo

            return num / por;
        }

        
    }
}