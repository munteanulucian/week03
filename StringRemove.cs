using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringRemove
    {
        public static string Dupl(string text)
        {
            string retext = "";


            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 1; j < text.Length; j++)
                {
                    if (text[i]!=text[j] && !retext.Contains(text[i]))
                    {
                        retext = retext + text[i];
                    }
                }
            }
            Console.WriteLine(retext);
            return retext;

        }

    }
}
