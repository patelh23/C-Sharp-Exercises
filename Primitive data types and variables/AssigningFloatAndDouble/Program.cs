using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigningFloatAndDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which of the following values can be assigned to variables of type float,
            //double and decimal
            float a = 5f;
            float b = -5.01f;
            decimal c = 34.567839023m;
            float d = 12.345f;
            double e = 8923.1234857;
            decimal f = .091124875956542151256683467m;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4}, f = {5}", a, b, c, d, e, f);
        }
    }
}
