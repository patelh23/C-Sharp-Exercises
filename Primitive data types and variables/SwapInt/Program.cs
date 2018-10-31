using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 5;
            int value2 = 10;
            int temp = value2;
            value2 = value1;
            value1 = temp;

            Console.WriteLine("{0},{1}", Convert.ToString(value1), Convert.ToString(value2));
        }
    }
}
