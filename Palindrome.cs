using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindrome
    {
        public static void Text()
        {
            Console.WriteLine("Introduceti textul: ");
            bool polidrom = false;
            string t = Console.ReadLine();
            int p = t.Length - 1;

            for (int i = 0; i <= p; i++)
            {
                if (t[i] != t[p - i])
                {
                    polidrom = false;
                    break;
                }
                else
                {
                    polidrom = true;
                }
            }
            if (polidrom == false)
            {
                Console.WriteLine("Textul introdus nu este palindrom!");
            }
            else
            {
                Console.WriteLine("Textul introdus este palindrom!");
            }
        }
    }
}
