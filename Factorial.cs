using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Factorial
    {
        public static void Fact(int nr)
        {
            
            long elapsedTime=0;
            var stopwatch = new Stopwatch();

            float x = 1;
            stopwatch.Start();
            for (int i = 1; i <= nr; i++)
            {
                if (i<nr)
                {
                    x = x * i;
                    Console.Write(i + " * ");
                }

                if (i==nr)
                {
                    x = x * i;
                    Console.Write(i);
                }
            }
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("");
            Console.WriteLine("Elapsed time: "+elapsedTime);

            stopwatch.Reset();

            Console.WriteLine("");
            Console.WriteLine(nr + "!= " + x);
            Console.WriteLine("");

        }
    }
}
