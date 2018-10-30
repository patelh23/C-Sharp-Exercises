using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 > 0)
                {
                    Console.Write(-i + ",");
                }
                else
                {
                    Console.Write(i + ",");
                }
            }
            // a for loop to generate sequence with if statement to find even numbers
        }
    }
}
