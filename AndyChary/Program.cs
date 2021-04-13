using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyChary
{
    class Program
    {
        static void Main(string[] args)
        {
            string retazec = "aaaaaba";
            Console.WriteLine(CompareChars(retazec));

            Console.ReadLine();
        }

        private static bool CompareChars(String s)
        {
            int x = -1;
            int y = 0;
            char[] ch = s.ToCharArray();

            if (s == null)
            {
                throw new Exception("The string is empty");
            }
            if (s.Length == 1)
            {
                return true;
            } 

            for (int i = 1; i < ch.Length; i++)
            {
                x++;
                y++;

                if (ch[x] <= ch[y])
                {
                    continue;
                }

                else if (ch[x] > ch[y])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
