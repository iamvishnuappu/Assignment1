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
            int n1,n2,n3,n4;
            int s = 0;
            double avg;
            Console.WriteLine("Enter four number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2= Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            s = n1 + n2 + n3 + n4;
            avg = s / 4;
            Console.WriteLine("Average="+avg);
            Console.ReadKey();
        }
    }
}
