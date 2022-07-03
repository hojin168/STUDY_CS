using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_03_class_base
{
    class Super
    {
        int num;
        protected string name1;

        public Super(int num)
        {
            this.num = num;
        }
        
        public void PrintSuper()
        {
            Console.WriteLine("Super  num: {0} ", num);
        } 
    }
    class Sub:Super
    {
     
        string name2;

        public Sub(int num, string name2) : base(num)
        {
            this.name2 = name2;
        }

        public void PrintSub()
        {
            base.name1 = "Super";
            base.PrintSuper();

            Console.WriteLine("Super  name: {0}", base.name1);
            Console.WriteLine("Sub name: {0}", this.name2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(26, "Jack");
            sub.PrintSub();
        }
    }
}
