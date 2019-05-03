using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumarPrim
    {
        public static void Numar(int nr)
        {
            int count = 0;

            for (int i = 2; i < nr; i++)
            {
                if (nr % i == 0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Numarul " + nr + " nu este prim");
            }
            else
            {
                Console.WriteLine("Numarul " + nr + "este prim");
            }
        }
    }
}
