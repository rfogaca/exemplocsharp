﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            for ( a = 10; a > 0; a = a-3 )
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadKey();
        }
    }
}
