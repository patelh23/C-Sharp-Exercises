﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to find Prime numbers\n");
            int inp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Prime Numbers are:\n------------------------------");
            int count = 0;

            for (int i = 1; i <= inp; i++)
            {
                for (int j = 2; j < i; j++) // j=2 because if we divide any number with 1 the remaider will always 0, so skip this step to minimize time duration.
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }
                if (count == (i - 2))
                {
                    Console.Write(i + "\t");
                }

                count = 0;
            }

        }
    }
}
