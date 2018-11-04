using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightOnMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the weight on earth");
            double earthw = Double.Parse(Console.ReadLine()); 
            double moonw = .17 * earthw;
            Console.WriteLine("The weight on moon would be {0}.", moonw);
        }
    }
}
