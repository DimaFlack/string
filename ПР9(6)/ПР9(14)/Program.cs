using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9_14_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < s.Length - 1; i += 3)
            {

                Console.Write(s[i] + ",");

            }
            Console.ReadKey();
        }
    }
}

