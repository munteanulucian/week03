using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayDuplicates
    {
        public static void Dupl(int[] arr1)
        {
            List<int> dup = new List<int>();
 

            for (int i = 0; i < arr1.Length-1; i++)
            {
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        dup.Add(arr1[i]);
                    }
                }
            }

            if (dup.Count > 0)
            {
                Console.Write("Elementele comune sunt: ");
                foreach (var w in dup)
                {
                    Console.Write(w + " ");
                }
            }
            else
            {
                Console.WriteLine("Nu sunt elemente cuplicate!");
            }
        }
    }
}
