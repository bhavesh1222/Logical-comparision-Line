﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_Problem
{
    internal class Lc2cs
    {
        static void Main(string[] args)
        {
            //Accepting Values For Line 1
            Console.Write("Enter Value A1:");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value B1:");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value A2:");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value B2:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            double ans1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Ans Is:" + ans1);
            Console.WriteLine("------------------------------------------------------------------------------------");

            //Accepting Values For Line 2
            Console.Write("Enter Value C1:");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D1:");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value C2:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D2:");
            int d2 = Convert.ToInt32(Console.ReadLine());

            double ans2 = Math.Sqrt(Math.Pow((c2 - c1), 2) + Math.Pow((d2 - d1), 2));
            Console.WriteLine("Ans Is:" + ans2);
            Console.WriteLine("------------------------------------------------------------------------------------");

            //Comparing Both Lines If Equal Or Not
            if (ans1 == ans2)
            {
                Console.WriteLine("Both The Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Both The Lines Are Not Equal");
            }
        }
    }
}
    

