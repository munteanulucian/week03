using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOfDigits
    {
        public static int Sum(int nr)
        {
            string w = Convert.ToString(nr);
            int suma = 0;

            for (int i = 0; i < w.Length; i++)
            {
                suma = suma + Convert.ToInt32(w[i]) - '0';
            }
            return suma;
        }
    }
}
