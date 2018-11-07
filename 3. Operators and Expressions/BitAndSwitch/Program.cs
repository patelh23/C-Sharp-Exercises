using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAndSwitch
{
    class Program
    {


        static uint ExchangeBits(uint number)
        {
            byte first = (byte)((number >> 3) & 7);
            byte second = (byte)((number >> 24) & 7);

            byte mix = (byte)(first ^ second);
            number = (uint)((number) ^ (mix << 3));
            number = (uint)((number) ^ mix << 24);
            return number;
        } 



        static void Main(string[] args)
        {
            uint number = 1073709056;
            Console.WriteLine("Old number {0,-10} to binary -> {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
            number = ExchangeBits(number);
            Console.WriteLine("New number {0,-10} to binary -> {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
