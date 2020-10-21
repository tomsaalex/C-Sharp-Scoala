using System;

namespace Fisa3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de linii: ");
            int n = int.Parse(Console.ReadLine()); //nr linii

            int[][] matrice = new int[n][];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti lungimea liniei {i}: ");
                int lungime = int.Parse(Console.ReadLine());
                matrice[i] = new int[lungime];
                Console.Write($"Introduceti {lungime} elemente pe o linie: ");
                string s = Console.ReadLine();
                string[] el = s.Split(" ");
                int indice = 0;
                foreach(string element in el)
                {
                    matrice[i][indice++] = int.Parse(element);
                }
            
            }



            int max = int.MinValue;

            foreach(int[] a in matrice)
            {
                foreach(int b in a)
                {
                    if (b > max)
                        max = b;
                }
            }

            Console.WriteLine($"Elementul maxim din matricea neregulata este {max}");
        }
    }
}
