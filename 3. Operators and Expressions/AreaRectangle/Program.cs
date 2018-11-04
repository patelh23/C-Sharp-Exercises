using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter side: ");
            double s = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height: ");
            double h = Double.Parse(Console.ReadLine());
            double area = s * h;
            double perimeter = s * 2 + h * 2;
            Console.WriteLine("Area of the rectangle is {0}.", area);
            Console.WriteLine("Perimeter of the rectangle is {0}.", perimeter);
        }
    }
}
