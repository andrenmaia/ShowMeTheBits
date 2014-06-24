using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShowMeTheBits
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 0) quit
             * 1) int
             * 2) double
             * 3) uint
             * 4) short
             */

            var option = 0;

            Console.WriteLine("ShowMeTheBits");
            Console.WriteLine("0) quit");
            Console.WriteLine("1) int");
            Console.WriteLine("2) double");
            Console.WriteLine("3) uint");
            Console.WriteLine("4) short");



            do
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        int i = 8;
                        var bytes = BitConverter.GetBytes(i);
                        printBits(bytes);
                        break;

                    case 2:
                        double d = 8d;
                        printBits(BitConverter.GetBytes(d));
                        break;

                    case 3:
                        uint ui = 8;
                        printBits(BitConverter.GetBytes(ui));
                        break;

                    case 4:
                        short s = 8;
                        printBits(BitConverter.GetBytes(s));
                        break;

                    default:
                        Console.WriteLine("See you son!");
                        break;
                }

                Console.WriteLine(string.Empty);
            } while (option != 0);
        }

        private static void printBits(byte[] bytes)
        {
            var str = new List<string>();
            var bits = new BitArray(bytes);

            for (int i = 0; i < bits.Length; i++)
            {
                var bit = bits[i];
                if (bit)
                    str.Add("1");
                else
                    str.Add("0");

                // separator
                if ((i+1) % 4 == 0)
                    str.Add(" ");
            }

            // print the bits list in string.
            Console.WriteLine(string.Join("", string.Join("", str).Reverse()));
        }
    }
}
