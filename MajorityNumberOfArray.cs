using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MajorityNumberOfArray
    {
        public static int Number(int[] arr1)
        {
            int max = 0;
            int count = 0;
            int nr = 0;

            foreach (var q in arr1)
            {
                foreach (var w in arr1)
                {
                    if (q==w)
                    {
                        count++;
                    }
                }
                if (count>max)
                {
                    max = count;
                    nr = q;
                }
                count = 0;
            }

            if (max >= arr1.Length / 2)
            {
                Console.WriteLine("Numarul este: " + nr);
            }
            return max;
        }
    }
}
