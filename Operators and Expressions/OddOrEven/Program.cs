using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer to check if even or odd");
            int x = int.Parse(Console.ReadLine());
            // if the int.Parse is not used. Console only reads first digit
            // even if the number is 92 it will only ready and classify odd
            int numcheck = x % 2;
            Console.WriteLine((numcheck > 0) ? "Odd" : "Even" );
                       
        }
    }
}
