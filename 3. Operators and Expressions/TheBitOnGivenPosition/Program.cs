using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBitOnGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 35;
            int position = 6;
            int check = (1 << position);
            Console.WriteLine((number & check) != 0 ? 1 : 0);

            // We are given a number n and a position p. Write a sequence of
            // operations that prints the value of the bit on the position p in the
            // number(0 or 1)
        }
    }
}
