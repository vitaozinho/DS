using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        { //inicio main

            //declarão de variaveis

            int a, b, total;

            //atribuição de valores

            a = 20;
            b = 10;

            /*concatenação de valores a serem exibidos na tela
             Calculo da operação sendo realiazado entre parenteses*/
            Console.WriteLine(a + "+" + b + "=" + (a + b));

            //Resultado do cálculo da operação sendo atribuido em uma variavel

            total = a - b;
            Console.WriteLine(a + "-" + b + "=" + total);
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));
            Console.WriteLine("Hello Word");

            Console.ReadKey();//instrução utilizada para dar uma pausa para visualizão 


        }//fim main
    }//fim class
}//fim namespace
