using System;

namespace Fisa3_7
{
    class Program
    {
        public enum zi
        {
            Luni,
            Marti,
            Miercuri,
            Joi,
            Vineri,
            Sambata,
            Duminica
        }

        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar intre 1 si 7, inclusiv: ");
            int n = int.Parse(Console.ReadLine());
            zi Z = zi.Luni;

            if (n <= 7)
                Console.Write($"Ziua data este {Z + n - 1}");
            else
                Console.Write("Incorect");
        }
    }
}
