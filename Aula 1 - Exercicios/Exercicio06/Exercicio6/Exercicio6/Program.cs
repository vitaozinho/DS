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
            double valreal, dolar, convert;
            
            Console.Write("Digite um valor em Reais(R$): ");
            valreal = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dólar(US$): ");
            dolar = double.Parse(Console.ReadLine());

            convert = valreal / dolar;

            Console.WriteLine("\n{0} R$ em Dólares é: {1:N2} US$", valreal, convert);

            Console.ReadKey();
        }
    }
}
