﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "word of ";
            Console.WriteLine("s+", "+s+", "+s");
            Console.WriteLine("Количество символов: " + 3 * s.Length);
            Console.ReadKey();
        }
    }
}
