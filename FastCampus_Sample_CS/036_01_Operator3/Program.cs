﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_01_Operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 100;
            a += 10;
            Console.WriteLine("a: "+ a);

            a -= b;
            Console.WriteLine("a: " + a);

            a += b;
            Console.WriteLine("a: " + a);

            b /= 3;
            Console.WriteLine("a: " + b);

            b %= 10;
            Console.WriteLine("a: " + b);
        }
    }
}