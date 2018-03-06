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
            double num1, num2;
            
            Console.WriteLine("Digite um número inteiro: ");
            num1 = double.Parse(Console.ReadLine());

            num2 = Math.Pow(num1, 2);

            Console.WriteLine("O número {0} ao quadrado é: {1}" + num1, num2);
            Console.ReadKey();
        }
    }
}
