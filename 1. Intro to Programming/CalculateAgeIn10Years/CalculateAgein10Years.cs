using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgeIn10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter your age: ");
            var age = Console.ReadLine();
            int newage2 = int.Parse(age) + 10;
            Console.WriteLine(newage2 + " years old");
            // to show the age after 10 years
        }
    }
}
