using System;

namespace Fisa_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[101];
            int n;
            Console.WriteLine("Introdu numarul de elemente al sirului:");
            n = int.Parse(Console.ReadLine());
           
            String s = Console.ReadLine();
            String[] elements = s.Split(' ');
            int i = 0;

            foreach(string c in elements)
            {
                int nr;
                if (int.TryParse(c, out nr))
                    a[i++] = nr;
            }

            for(int j = 0; j < n; j++)
                Console.Write($"{a[j]} ");
                
        }
    }
}
