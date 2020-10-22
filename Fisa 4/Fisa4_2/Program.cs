using System;

namespace Fisa4_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int n, m;

            Console.Write("Introdu numarul de linii si coloane: ");
            string s = Console.ReadLine();
            string[] elements = s.Split(" ");

            n = int.Parse(elements[0]);
            m = int.Parse(elements[1]);
            
            int[,] a = new int[n, m];
            int[] v = new int[m];
            Console.WriteLine("Introdu matricea, linie cu linie:");
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                elements = s.Split(" ");

                for(int j = 0; j < m; j++)
                {
                    v[j] = int.Parse(elements[j]);
                }

                Array.Sort(v);

                for (int j = 0; j < m; j++)
                    a[i, j] = v[j];
            }



            Console.WriteLine("Matricea cu liniile sortate este:");

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{a[i, j]} ");
                Console.WriteLine();
            }

        }
    }
}
