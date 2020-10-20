using System;
using System.Runtime.InteropServices;

namespace Fisa3_1
{
    class Program
    {
        static bool Prim(int x)
        {
            if (x < 2)
                return false;
            if (x % 2 == 0 && x != 2)
                return false;

            for (int d = 3; d * d <= x; d += 2)
                if (x % d == 0)
                    return false;
            
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Introdu numarul de elemente al sirului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i = 0;
            Console.Write("Introdu elementele sirului: ");
            string s = Console.ReadLine();
            string[] elements = s.Split(' ');

            foreach(string e in elements)
                v[++i] = int.Parse(e);

            Console.Write("Elementele prime ale sirului sunt: ");

            foreach(int element in v)
            {
                if (Prim(element))
                    Console.Write($"{element} ");
            }
        }
    }
}
