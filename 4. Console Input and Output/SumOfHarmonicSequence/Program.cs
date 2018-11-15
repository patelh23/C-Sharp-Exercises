using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfHarmonicSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 1;
            for (decimal i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (1 / i);
                }
                else
                {
                    sum -= (1 / i);
                }

                Console.WriteLine("{0:F3}", sum);
            }


        }
    }
}
