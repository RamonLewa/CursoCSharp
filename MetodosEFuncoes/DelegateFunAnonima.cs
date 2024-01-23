using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateFunAnonima
    {
        delegate string StringOperacao(string s);

        public static void Executar()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            if (palavra == inverter(palavra) )
            {
                Console.WriteLine($"{palavra} é um palíndormo");
            }
            else
            {
                Console.WriteLine($"{palavra} não é um palíndormo");
            }
        }
    }
}
