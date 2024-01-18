using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da curcunferencia
            double raio = 4.5;
            // Constantes não podem ter seu valor alterado
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            // Concatenação
            Console.WriteLine("Área é " + area);

            // Tipos internos
            
            // bool é true ou false
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);
            
            // 0 a 256
            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            // -128 a 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols "+ saldoDeGols);

            // Até 32767
            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            // Passa da casa dos bilhões
            int menorValorInt = int.MinValue; //Mais usados dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A população brasileira é de " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            // f no final pra definir que é float
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
