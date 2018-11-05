using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircleOutOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -6;
            int y = -1;
            int pythagareon = x * x + y * y;
            if (pythagareon <= 25 && ((x < -1) || (y < 1)))
            {
                Console.WriteLine("That point is within circle and out of rectangle");
            }
                Console.WriteLine("That point is not within circle or is in rectangle");
            // Use the Pythagorean Theorem and axis boundaries for a rectangle
        }
    }
}
