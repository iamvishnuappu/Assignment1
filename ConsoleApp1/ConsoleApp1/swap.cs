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
            int n1, n2, t;
            double d;
            Console.WriteLine("Enter two numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("Swapped numbers:" );
            Console.WriteLine("A:" + n1);
            Console.WriteLine("B:" + n2);
            Console.ReadKey();
        }
    }
}
