﻿using System;
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

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o nome da cidade que você nasceu: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\nome***Informações digitadas*** \n");
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Cidade de nascimento: " + cidade);

            Console.ReadKey();
        }
    }
}
