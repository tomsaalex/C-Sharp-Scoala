using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisa_5_2
{
    class Program
    {
        public enum numere
        {
            unu = 1,
            doi = 2,
            trei = 3,
            patru = 4,
            cinci = 5,
            sase = 6,
            sapte = 7,
            opt = 8,
            noua = 9,
            zece = 10
        }

        static void Main(string[] args)
        {
            for(numere i = numere.unu; i <= numere.zece; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
