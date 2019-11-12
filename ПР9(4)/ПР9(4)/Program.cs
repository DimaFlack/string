using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Console.ReadLine());
            int x = s.Length;
            if (s.Length > 5)
            {
                Console.WriteLine(s[0] + "," + s[1] + "," + s[2] + "," + s[s.Length - 3] + "," + s[s.Length - 2] + "," + s[s.Length - 1]);

            }
            else
                while (x > 0)
                {
                    x -= 1;
                    Console.WriteLine(s[0]);
                }

            Console.ReadKey();
        }
    }
}
