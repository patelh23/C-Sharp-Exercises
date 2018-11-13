using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console two integer numbers (int)
            //and prints how many numbers between them exist, such that the
            //remainder of their division by 5 is 0.Example: in the range(14, 25)
            //there are 3 such numbers: 15, 20 and 25.

            Console.WriteLine("Please enter lower and higher numbers for a range: ");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());

            for( int i = x1; x1 <= x2; x1++)
            {
                if (x1 % 5 == 0)
                    Console.Write(x1 + "\t");
                
               
            }
        }
    }
}
