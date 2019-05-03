using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PairOfElements
    {
        public static void Pair(int nr)
        {
            Console.Write("Introduceti numarul de elemente din lista: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Introduceti elementul " + (i+1) + " din " + x + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool exist = false;
            foreach (var q in arr)
            {
                foreach (var w in arr)
                {
                    if (q+w==nr)
                    {
                        Console.WriteLine(q + "+" + w + "=" + nr);
                        exist = true;
                    }
                }
            }

            if (exist==false)
            {
                Console.WriteLine("Nu s-a gasit 2 elemente in lista sa dea suma " + nr);
            }



        }
    }
}
