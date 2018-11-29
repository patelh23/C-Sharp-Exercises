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
            int c = 11;

            if (a < b)
                if (a < c)
                    c = c + a;
                    a = c - a;
                    c = c - a;
                else if (b < c)
                    

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
