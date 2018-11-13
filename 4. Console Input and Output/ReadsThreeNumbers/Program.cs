using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console three numbers of type int
            //and prints their sum.
            
            Console.WriteLine("Please enter three numbers: ");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is: " + (x1 + x2 + x3));
        }
    }
}
