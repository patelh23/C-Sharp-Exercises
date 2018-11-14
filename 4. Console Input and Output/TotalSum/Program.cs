using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer n: ");
            int n = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter number:");
                count += Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine("Total sum of integers is: " + count);

        }
    }
}
