using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu nome?: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);
            Console.ReadKey();
        }
    }
}
