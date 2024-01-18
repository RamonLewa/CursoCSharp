using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            // Definindo que terá apenas uma casa decimal
            Console.WriteLine(valor.ToString("F1"));
            // Definindo como moeda
            Console.WriteLine(valor.ToString("C"));
            // Definindo como percentual * 100
            Console.WriteLine(valor.ToString("P"));
            // Definindo que será um número com duas casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            // Define um padrão de símbolos
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            // Preenche zeros a esquerda
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
