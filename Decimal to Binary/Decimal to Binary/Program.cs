using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal number: ");
            int dec = int.Parse(Console.ReadLine());

            dec2bin(dec);

            Console.ReadKey();
        }


        private static void dec2bin(int num)
        {
            string reverseBinary = "";

            while (num >= 1)
            {
                reverseBinary += (num % 2).ToString();
                num /= 2;               
            }

            char[] binary = reverseBinary.ToCharArray();
            Array.Reverse(binary);
            Console.WriteLine(binary);
        }
    }
}
