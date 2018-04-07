using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = new string[t];

            for(int i = 0;i<t;i++)
            {
               inputArray[i] = Console.ReadLine();
            }

            foreach (string s in inputArray)
            {
                Calculate(s);
            }

            Console.ReadKey();
        }

        static void Calculate(string s)
        {
            int number = Convert.ToInt32(s);
            char[] chArr = s.ToCharArray();
            List<int> digits = new List<int>();
            int counter = 0;

            foreach (char c in chArr)
            {
                digits.Add(Convert.ToInt32(c.ToString()));
            }

            foreach (int digit in digits)
            {
                if (digit != 0)
                {
                    if(number % digit == 0)
                    {
                        counter++;
                    }
                }
            }

           Console.WriteLine(counter);
        }
    }
}
