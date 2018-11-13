using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 13;
            decimal x2 = (decimal)3 / 4;
            decimal x3 = (decimal)-3 / 8;
            Console.WriteLine("{0,-10:X}" + "{1,-10:F2}" + "{2,-10:F2}", x1, x2, x3);

        }
    }
}
