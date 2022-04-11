using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(string.Format($"{n} x {contador} = {n*contador} ")); 
              //escreva o seu código nos espaços em branco
            }
        }
    }
}