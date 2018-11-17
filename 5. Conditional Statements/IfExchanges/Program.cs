using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExchanges
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 26;
            int num2 = 23;

            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;

            }
            Console.WriteLine("Num1 :" + num1);
            Console.WriteLine("Num2 :" + num2);
        }
    }
}
