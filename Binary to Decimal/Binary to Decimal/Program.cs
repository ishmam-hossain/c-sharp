using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the binary number: ");
            string bin = Console.ReadLine();
            
            char[] binChar = bin.ToCharArray();
            int[] binArray = new int[binChar.Length];

            for (int i = 0; i < binArray.Length; i++)
            {
                binArray[i] = Convert.ToInt16(char.GetNumericValue((binChar[i])));
            }

            Array.Reverse(binArray);
            Binary2Decimal(binArray);

            Console.ReadKey();
        }



        private static void Binary2Decimal(int[] num)
        {
            double decimalNumber = 0;

            for (int i = 0; i < num.Length; i++)
                decimalNumber += ( Convert.ToInt16(num[i]) * Math.Pow(2, i) );

            Console.WriteLine(decimalNumber);        
        }
    }
}
