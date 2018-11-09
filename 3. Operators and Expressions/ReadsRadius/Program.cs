using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter radius: ");
            int r = int.Parse(Console.ReadLine());
            int area = (int)(Math.PI * r * r);
            int perimeter = (int)(2 * Math.PI * r);
            Console.WriteLine("Area is: {0} and Perimeter is: {1}", area, perimeter);

            //Write a program that reads from the console the radius "r" of a circle
            //and prints its perimeter and area.
        }
    }
}
