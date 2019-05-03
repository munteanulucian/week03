using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Armstrong
    {
        public static void Number(int nr)
        {
            string arm = Convert.ToString(nr);
            int number = 0;
            int p = 0;
            foreach (var q in arm)
            {
                p=Convert.ToInt32(q)-'0';
                number = number + (p * p * p);
            }
            if (number == nr)
            {
                Console.WriteLine("The number " + nr + " is armstrong!");
            }
            else
            {
                Console.WriteLine("The number " + nr + " is not armstrong!");
            }
        }
    }
}
