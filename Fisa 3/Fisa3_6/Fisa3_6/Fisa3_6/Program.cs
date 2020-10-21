using System;

namespace Fisa3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de linii: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane: ");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementele liniei {i}: ");
                string s = Console.ReadLine();
                string[] el = s.Split(" ");
                int index = 0;
                foreach (string e in el)
                    a[i, index++] = int.Parse(e);
            }

            int nrPoz = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i, j] > 0)
                        nrPoz++;

            Console.Write($"Numarul de elemente pozitive din matrice este de {nrPoz}");
        }
    }
}
