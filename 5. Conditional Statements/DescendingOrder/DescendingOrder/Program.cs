using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 12;

            if (a <= b && b < c) 
                Console.WriteLine("{0},{1},{2}", c, b, a);
            else if (a > b && b < c)
                    Console.WriteLine("{0},{1},{2}", c, a, b);
                else
    
                  Console.WriteLine("{0},{1},{2}", c, a, b);
            

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
