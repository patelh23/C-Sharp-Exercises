using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a Boolean expression that checks whether a given integer is
            divisible by both 5 and 7, without a remainder. */            
            Console.WriteLine("Please enter integer: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 5 == 0 && x % 7 == 0) 
            {
                bool isDivisible = true;
                Console.WriteLine(isDivisible);
            }
            else
                Console.WriteLine("False, there is a remainder in division");

        }
    }
}
