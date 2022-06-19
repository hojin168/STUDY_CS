﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_1_Array_Init2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[3];
            int[] arrNum2 = new int[] { 0, 1, 2 };
            int[] arrNum3 = new int[3] { 0, 1, 2 };
            int[] arrNum4 = { 0, 1, 2 };
            string[] arrWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };


            for (int i = 0; i < 3; i++)
            {
                arrNum[i] = i;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("  {0}", arrNum[i]);
            }

            Console.WriteLine("\n---------------------------------");

            Console.WriteLine("arrNum2: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("  {0}", arrNum2[i]);
            }

            Console.WriteLine("\n---------------------------------");

            Console.WriteLine("arrNum3: ");
            foreach (int temp in arrNum3)
            {
                //temp = 1000: 오류:foreach는 읽기 전용

                Console.Write("  {0}", temp);
            }
            Console.WriteLine("\n--------------------------------------------");

            Console.WriteLine("arrNum4: ");
            foreach (int temp2 in arrNum4)
            {
                //temp = 1000: 오류:foreach는 읽기 전용

                Console.Write("  {0}", temp2);
            }
            Console.WriteLine("\n--------------------------------------------");
            foreach (string temp3 in arrWeek)
            {
                Console.Write("  {0}  ", temp3);

            }
            

        }
    }
}