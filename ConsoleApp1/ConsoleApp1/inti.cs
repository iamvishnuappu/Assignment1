using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Assignment
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
            int i=0;
            int s = 0;
            while (i <= 10)
            {
                s += i;
                i++;
            }
            Console.WriteLine("Sum using while:" + s);
            Console.ReadKey();
        }
    }
}
