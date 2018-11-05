using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4-digit number: ");
            int abcd = int.Parse(Console.ReadLine());
            int d = abcd % 10;
            int c = (abcd / 10) % 10;
            int b = (abcd / 100) % 10;
            int a = (abcd / 1000) % 10;
            Console.WriteLine("Sum is {0}",(a + b + c + d)); //calculates sum of digits
            Console.WriteLine("Reversed Order is {0}{1}{2}{3}",d,c,b,a); // Prints on the console the number in reversed order: dcba
            Console.WriteLine("DABC order is {0}{1}{2}{3}", d, a, b, c); // Puts the last digit in the first position: dabc
            Console.WriteLine("DABC order is {0}{1}{2}{3}", a, c, b, d); // Exchanges second and third digits
        }
    }
}
