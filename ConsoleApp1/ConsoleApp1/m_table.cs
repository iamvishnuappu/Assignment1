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
            int n1,m=1;
            
            Console.WriteLine("Enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MULTIPLICATION TABLE OF " + n1 + "\n");
            for (int i = 1; i <= 10; i++)
            {
                m = i * n1;
                
                Console.WriteLine(i + "*" + n1 + "=" + m);
            }
            Console.ReadKey();
        }
    }
}
