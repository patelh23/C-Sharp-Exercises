using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer n: ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);

            }

        }
    }
}
