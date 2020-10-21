using System;

namespace Fisa3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de linii: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];
            
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementele liniei {i}: ");
                string s = Console.ReadLine();
                string[] el = s.Split(" ");
                int index = 0;
                foreach (string e in el)
                    a[i, index++] = int.Parse(e);
            }

            float medie = 0;

            for (int i = 0; i < n; i++)
                medie += a[i, i];
            
            medie /= n;
            Console.WriteLine($"Media aritmetica a elementelor de pe diagonala principala este {medie}");
                    
        }
    }
}
