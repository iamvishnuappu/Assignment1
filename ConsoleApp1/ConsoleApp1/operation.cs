using System;
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
            int n1, n2, m;
            double d;
            Console.WriteLine("Enter two numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int s=n1+n2;
            m=n1*n2;
	    d= n1/n2; 
            Console.WriteLine("Sum:"+s );
            Console.WriteLine("Product:" + m);
            Console.WriteLine("Division:" +d);
            Console.ReadKey();
        }
    }
}
