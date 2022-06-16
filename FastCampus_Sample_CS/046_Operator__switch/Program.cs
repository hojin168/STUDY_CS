using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_Operator__switch
{
    internal class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            THE,
            WED,
            TUE,
            FRI,
            SAT,
        }

        static void Main(string[] args)
        {
            DAY_OF_WEEK DAY_OF_WEEK = DAY_OF_WEEK.FRI;
            string dayString = "";

            switch(DAY_OF_WEEK)
            {
                case DAY_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                case DAY_OF_WEEK.MON:
                    dayString = "월";
                    break;
                case DAY_OF_WEEK.THE:
                    dayString = "화";
                    break;
                case DAY_OF_WEEK.WED:
                    dayString = "수";
                    break;
                case DAY_OF_WEEK.TUE:
                    dayString = "목";
                    break;
                case DAY_OF_WEEK.FRI:
                    dayString = "금";
                    break;
                case DAY_OF_WEEK.SAT:
                    dayString = "토";
                    break;
                default:
                    break;


            }
            Console.WriteLine("{0}요일입니다. " , dayString);
        }
    }
}
