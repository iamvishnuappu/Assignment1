﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Run r = new Run();
            r.calc();

        }
    }
    class Run
    {

        public void calc()
        {
            int n1, n2;

            Console.WriteLine("Enter two number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1==n2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
                Console.WriteLine("Numbers are not equal");
            Console.ReadKey();
        }
    }
}
