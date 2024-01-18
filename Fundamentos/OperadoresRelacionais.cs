using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            // Maior que
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            // Menor que
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            // Igual a
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            // Diferente de
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            // Maior ou igual a
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            // Menor ou igual a
            Console.WriteLine("Reprovado? {0}", nota <= 3.00);

        }
    }
}
