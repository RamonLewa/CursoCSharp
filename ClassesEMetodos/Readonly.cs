using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;
        readonly int x = 100;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento()
        {
            return String.Format("{0:D2}/{1:D2}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    internal class Readonly
    {
        public static void Executar()

        {
            var novoCliente = new Cliente("Ramon Loewenstein", new DateTime(2007, 10, 07));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

            // novoCliente.Nascimento = new DateTime(2020, 10, 10);
        }
    }
}