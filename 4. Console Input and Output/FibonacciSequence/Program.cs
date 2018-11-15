using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int sum = 1;
            Console.Write("0,");
            for (int i = 1; i <= 100; i++)
            {
                int temp = sum;
                sum = sum + first;
                Console.Write(sum + ",");
                first = temp;
            }

        }
    }
}
