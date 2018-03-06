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
            //definição de constante pi
        const double pi = 3.14159265358979323846264338327950;

            //declaração de variavel e atribuição de valor na variavel
            double raio = 10;
            double area;

            Console.WriteLine("Calculo da area de um circulo\n");
            Console.WriteLine("Fórmula : area = pi * raio \n");

            //Mat.pow: exponenciação
            area = pi * Math.Pow(raio, 2); //sem usar o método pow seria: area = pi * area * area;

            Console.WriteLine("Área = {0}", area); 
            Console.WriteLine("Área = {0:N}", area);
            Console.WriteLine("Área = {0:N5}", area);

            Console.ReadKey();
        }

    }
}
