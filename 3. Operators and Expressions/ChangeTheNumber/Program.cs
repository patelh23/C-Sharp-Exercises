using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 2;
            int v = 1;
            int check = 1 << p;
            Console.WriteLine(v == 0 ? n = (n & (~check)) : n = (n | check));

        }
    }
}
