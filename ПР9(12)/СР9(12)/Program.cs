using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СР9_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "f2f34l43o9O03f";
            char[] ch = s.ToCharArray();
            var count = ch.Where((n) => n >= '0' && n <= '9').Count();
            Console.WriteLine("Кол-во цифр в строке:" + count);
            Console.ReadKey();
        }
    }
}
