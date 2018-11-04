using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write an expression that looks for a given integer if its third digit(right
            to left) is 7. */

            Console.WriteLine("Please enter integer :");
            int x = int.Parse(Console.ReadLine());
            int newx = x / 100;
                        
            if (newx % 10 == 7)
            {
                Console.Write("It is 7");
            }
            else
                Console.Write("It is not 7");
        }
    }
}
