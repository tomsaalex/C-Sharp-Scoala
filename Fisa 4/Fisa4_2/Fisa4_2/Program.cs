using System;

namespace Fisa4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            string s;
            string[] el;
            Console.Write("Introdu numarul de linii si coloane cu un spatiu intre ele: ");
            s = Console.ReadLine();
            el = s.Split(' ');

            n = int.Parse(el[0]);
            m = int.Parse(el[1]);

            int[,] a = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introdu elementele liniei {i + 1}: ");
                s = Console.ReadLine();
                el = s.Split();
                for(int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(el[j]);
                }
            }

            Console.WriteLine("Matricea introdusa este:");

            int[] temp = new int[m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{a[i, j]} ");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    temp[j] = a[i, j];

                Array.Sort(temp);

                for (int j = 0; j < m; j++)
                    a[i, j] = temp[j];
            }

            Console.WriteLine("Matricea cu liniile sortate este:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{a[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
