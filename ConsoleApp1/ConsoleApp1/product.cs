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
            r.display();

        }
    }
    class Run
    {
        public void display()
        {
            int n1,m=1;
            
            Console.WriteLine("Enter 3 number");
			n1 = Convert.ToInt32(Console.ReadLine());
			n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            
                m = n2 * n1 * n3;
                
                Console.WriteLine("product="+m);
            
            Console.ReadKey();
        }
    }
}
