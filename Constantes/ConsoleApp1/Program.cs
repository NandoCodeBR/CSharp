using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nome = "Fernando";
            const double pi = 3.1415;

            //nome="Rodrigo";
            //pi = 3.4;         Ambas as linhas geram erro, pois a constante não pode ter seu valor alterado

            Console.Write("O seu nome é: {0}\nPi: {1}",nome,pi);
        }
    }
}
