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
            int num1, resul;

            Console.WriteLine("Digite um número que você gostaria de ver o dobro");
            num1 = int.Parse(Console.ReadLine());

            resul = num1 + num1;

            Console.WriteLine("O dobro do seu número é: " + resul);
            Console.ReadKey(); 

        }
    }
}
