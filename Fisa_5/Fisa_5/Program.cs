using System;
using System.Collections;
using System.Threading.Tasks.Dataflow;
namespace Fisa_5
{
    class Program
    {
        struct elev
        {
            public string nume;
            public float medie;
        }

        public class ComparatorMedii : IComparer
        {
            // stabilește cum se compară 2 elevi după medie
            public int Compare(Object x, Object y)
            {
                elev e1 = (elev)x;
                elev e2 = (elev)y;

                if (e1.medie < e2.medie) return -1;
                if (e1.medie == e2.medie) return 0;
                if (e1.medie > e2.medie) return 1;

                return 0;
            }
        }

        public class ComparatorNume : IComparer
        { 
            public int Compare(Object x, Object y)
            {
                elev e1 = (elev)x;
                elev e2 = (elev)y;

                return String.Compare(e1.nume, e2.nume);
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Introdu numarul de elevi: ");
            n = int.Parse(Console.ReadLine());

            elev[] clasa = new elev[n];
            float medieClasa = 0;

            string s;
            string[] el;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu numele si media elevului {i + 1} separate printr-un spatiu: ");
                s = Console.ReadLine();
                el = s.Split();
                clasa[i].nume = el[0];
                clasa[i].medie = int.Parse(el[1]);
                medieClasa += clasa[i].medie;
            }
            Console.WriteLine();
            medieClasa /= n;
            Console.WriteLine("Media clasei este: {0:N2}\n", medieClasa);
            Console.WriteLine("Elevii ordonati dupa medie sunt:\n");
            
            Array.Sort(clasa, new ComparatorMedii());
            
            foreach(elev i in clasa)
            {
                Console.WriteLine(string.Format("{0, -10}{1, -5}", i.nume, i.medie));
            }
            Console.WriteLine();
            Console.WriteLine("Elevii ordonati dupa nume sunt:\n");
            Array.Sort(clasa, new ComparatorNume());

            foreach (elev i in clasa)
            {
                Console.WriteLine(string.Format("{0, -10}{1, -5}", i.nume, i.medie));
            }
        }
    }
}
