using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte sbyteData = 255;
            sbyte sbyteData2 =(sbyte)sbyteData;

            int b,c;

            b = sbyteData + sbyteData2;
            c = b / 3;
            

            Console.WriteLine("sbyteData: " +sbyteData);
            Console.WriteLine("sbyteData2: " + sbyteData2);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
        }
    }
}
