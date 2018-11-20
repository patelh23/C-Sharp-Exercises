using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 11, -2, 23 };
            int negativecount = 0;
            char product;
            bool hasZero = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    negativecount++;
                }
                else if (num[i] == 0)
                {
                    hasZero = true;
                }
            }

            if (negativecount % 2 == 0 && !hasZero)
            {
                product = '+';
            }
            else if (negativecount % 2 != 0 && !hasZero)
                product = '-';
            else
                product = '0';

            Console.WriteLine(product);
            Console.WriteLine(negativecount);

        }
    }
}
