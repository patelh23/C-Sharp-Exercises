using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggestof3integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("A is the biggest");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A & C are the biggest");

            else if (a < b)
                if (b > c) Console.WriteLine("B is the biggest");
                else if (b < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("B & C are the biggest");

            else if (a == b)
                if (a == c) Console.WriteLine("All are equal");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A & B are equal");


        }
    }
}
