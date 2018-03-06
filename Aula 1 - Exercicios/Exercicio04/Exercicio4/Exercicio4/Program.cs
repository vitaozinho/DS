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
            double a, b, c, resul;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            resul = (Math.Pow(a, 2)) * 5 - c / (b - a % 4);
            Console.Write("Resultado da operação é: ", resul);

        }
    }
}
