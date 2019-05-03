using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RemoveDuplicates
    {
        public static void Remove(int[]list)
        {
            int count = 0;

            List<int> uniq = new List<int>();

            foreach (var w in list)
            {
                foreach (var q in list)
                {
                    if (w==q && count==0)
                    {
                        if (!uniq.Contains(w))
                        {
                            uniq.Add(w);                          
                        }
                        count++;
                    }
                }
                count = 0;
            }

            foreach (var s in uniq)
            {
                Console.Write(s + " ");
            }
        }
    }
}
