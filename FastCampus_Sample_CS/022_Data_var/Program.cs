using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Data_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.1415943847285493857392345643f;
            var c = 3.1415943847285493857392345643m;
            var d = 'H';
            var e = 'i';
            var f = "World!!";
            var g = false;

            Console.WriteLine("type: {0}, a: {0}", a.GetType(), a);
            Console.WriteLine("type: {0}, b: {0}", b.GetType(), b);
            Console.WriteLine("type: {0}, c: {0}", c.GetType(), c);
            Console.WriteLine("type: {0}, g: {0}", g.GetType(), g);

            Console.WriteLine("{0}{1} {2}", d, e, f);

            var num = 0;
            num = 100;

            Console.WriteLine("num: " +num);
        }
    }
}
