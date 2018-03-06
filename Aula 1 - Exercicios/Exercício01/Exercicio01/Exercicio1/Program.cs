using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; string cidade;
            int idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a cidade em que você mora: ");
            cidade = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = int.Parse (Console.ReadLine());

            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Cidade de nascimento: " + cidade);

        }
    }
}
