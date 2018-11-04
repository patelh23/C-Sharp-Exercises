using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write an expression that calculates the area of a trapezoid by given
            sides a, b and height h*/
            
            Console.WriteLine("Enter side, a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side, b :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height, h :");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("Area of trapezoid is " + area);

        }
    }
}
