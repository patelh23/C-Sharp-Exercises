using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            bool parsesuceed = false;
            do
            {
                Console.WriteLine("Please enter number: ");
                parsesuceed = Int32.TryParse(Console.ReadLine(), out a);

            } while (!parsesuceed);
            do
            {
                Console.WriteLine("Please enter number: ");
                parsesuceed = Int32.TryParse(Console.ReadLine(), out b);

            } while (!parsesuceed);
            do
            {
                Console.WriteLine("Please enter number: ");
                parsesuceed = Int32.TryParse(Console.ReadLine(), out c);

            } while (!parsesuceed);
            do
            {
                Console.WriteLine("Please enter number: ");
                parsesuceed = Int32.TryParse(Console.ReadLine(), out d);

            } while (!parsesuceed);
            do
            {
                Console.WriteLine("Please enter number: ");
                parsesuceed = Int32.TryParse(Console.ReadLine(), out e);

            } while (!parsesuceed);
            int sum = a + b + c + d + e;
            Console.WriteLine("Total of 5 numbers is: " + sum);
        }
    }
}
