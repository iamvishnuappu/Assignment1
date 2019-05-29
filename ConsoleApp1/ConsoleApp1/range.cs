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
            int n1, n2;
            int s = 0;

            Console.WriteLine("Enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            if ((n1 >= 20) && (n1 <= 100))
            {
                Console.WriteLine("Number is between 20 and 100");
            }
            else
                Console.WriteLine("Number is not between 20 and 100");
            Console.ReadKey();
        }
    }
}
