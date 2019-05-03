using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fibonacci
    {
        public static void Fib(int count)
        {
            int prev = 0;
            int current = 1;
            int nr = 1;

            Console.Write(prev + " ");
            Console.Write(current + " ");

            for (int i = 2; i < count; i++)
            {
                nr = prev + current;
                Console.Write(nr +" ");
                prev = current;
                current = nr;
            }
        }
    }
}
