using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which compares correctly two real numbers with
            //accuracy at least 0.000001
            Console.WriteLine("Please enter number 1:");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number 2:");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
            Console.Write(comparing);

        }
    }
}
