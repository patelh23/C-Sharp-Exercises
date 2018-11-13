using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two numbers from the console and prints the
            //greater of them.Solve the problem without using conditional
            //statements.
                       Console.WriteLine("Please enter two integers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int greater = Math.Max(number1, number2);
            Console.WriteLine("The greater number is: " + greater);
        }
    }
}
