using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TotalEvenNumbers
    {
        public static int Suma(int[]arr1)
        {
            int suma = 0;
            foreach (var w in arr1)
            {
                if (w%2==0)
                {
                    suma = suma + w;
                }
            }
            return suma;
        }
    }
}
