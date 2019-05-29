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
            int i;
            int s = 0;
            for (i = 1; i <= 10; i++)
                s += i;

            Console.WriteLine("Sum:" + s);
            Console.ReadKey();
        }
    }
}
