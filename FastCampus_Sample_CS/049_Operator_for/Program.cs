using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_Operator_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i <= 10; i++)
                // 0 0<=10  . total +=0; =>1
                //1 <=10 . total +=1;  =>값 2
                //2 <=10 . total +=2; =>값 3
                //....
                //11<= 10 -> false -> for문 빠저나감
            {
                total += i;
            }
            Console.WriteLine("total : " + total);
        }
    }
}
