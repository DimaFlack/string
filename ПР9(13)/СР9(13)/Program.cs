using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СР9_13_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "sdhasdkuahsjdashdasdasdlkabaababsdhabsdjh";
            Console.WriteLine(s.All(c => c == 'a' || c == 'b'));
            Console.ReadKey();
        }
    }
}
