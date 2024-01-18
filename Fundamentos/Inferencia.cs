using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "Ramon";
            // nome = 123;
            Console.WriteLine(nome);

            // int idade;
            var idade = 18;
            Console.WriteLine(idade);

            // Declaração de variavel
            int a;
            a = 3;

            // Inicialização de variavel
            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
