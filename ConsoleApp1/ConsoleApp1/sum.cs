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
            int n1,n2;
            int s = 0;
            
            Console.WriteLine("Enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if ((n1>=20)&&(n1<=100))
            {
                s = n1 + n1+n1;
            }
           else
            {
                s = n1 + n2;
            }
            Console.WriteLine("Sum:"+s);
            Console.ReadKey();
        }
    }
}
