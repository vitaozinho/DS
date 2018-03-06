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
            int a, b;
            string verdade = "sim", falso = "não";

            Console.Write("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número inteiro: "); b = int.Parse(Console.ReadLine());


            Console.Write("\n{0} > {1} ? Resposta: ", a, b);
            Console.Write(a > b ? verdade : falso);

            Console.ReadKey();

        }
    }
}
