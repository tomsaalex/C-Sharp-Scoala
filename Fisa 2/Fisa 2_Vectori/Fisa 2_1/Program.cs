using System;

namespace Fisa_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[101];
            int n;
            Console.Write("Introdu numarul de elemente al sirului: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Introdu elementele sirului pe o singura linie: ");

            String s = Console.ReadLine();
            String[] elements = s.Split(' ');
            int i = 0;
            float medieElemente = 0;
            
            foreach (string c in elements)
            {
                int nr;
                if (int.TryParse(c, out nr))
                {
                    a[i++] = nr;
                    medieElemente += nr;
                }
            }

            medieElemente /= n;

            Console.Write("Sirul introdus este: ");
            for(int j = 0; j < n; j++)
                Console.Write($"{a[j]} ");


            Console.WriteLine();
            Console.WriteLine($"Media aritmetica a elementelor este: {medieElemente}");
        }
    }
}
