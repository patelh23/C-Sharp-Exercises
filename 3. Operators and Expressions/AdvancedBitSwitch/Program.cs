using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedBitSwitch
{
    class Program
    {
            private static void PrintBinaryNumber(byte[] numberToBinary)
            {
                for (int j = numberToBinary.Length - 1; j >= 0; j--)
                {
                    Console.Write(numberToBinary[j]);

                    if ((j + 4) % 4 == 0)
                        Console.Write(" ");
                }
            }

            static void Main(string[] args)
            {
                uint number = 1073709056;
                byte p = 1, q = 15, steps = 14; // steps = k

                byte[] numberToBinary = new byte[32];

                // Initialize array (number to binary), every cell contains 0 or 1
                for (int i = 0; i < numberToBinary.Length; i++)
                {
                    numberToBinary[i] = (byte)(number % 2);
                    number = number / 2;
                }

                Console.Write("Step 0   -> ");
                PrintBinaryNumber(numberToBinary);
                Console.WriteLine();

                for (int i = 0; i < steps; i++)
                {
                    byte temp = numberToBinary[p];
                    numberToBinary[p] = numberToBinary[q];
                    numberToBinary[q] = temp;
                    p++;
                    q++;

                    // Follow the steps
                    Console.Write("Step {0,-3} -> ", i + 1);
                    PrintBinaryNumber(numberToBinary);

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }

