using System;

namespace Desafio09
{
    class Program
    {
                static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double x = 1;
            double y;
            double z;


            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", x);
                y = Math.Pow(x, 2);
                Console.Write("{0} ", y);
                z = Math.Pow(x, 3);
                Console.Write("{0} \n", z);
                x++;
            }
        }
    }
}