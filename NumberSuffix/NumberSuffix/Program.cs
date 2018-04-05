using System;

namespace NumberSuffix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int lastDigit = number % 10;
            switch(lastDigit)
            {
                case 1:
                    printTheDigit(number,"st");
                    break;
                case 2:
                    printTheDigit(number, "nd");
                    break;
                case 3:
                    printTheDigit(number, "rd");
                    break;

                default:
                    printTheDigit(number, "th");
                    break;
            }

            Console.ReadKey();
        }

        private static void printTheDigit(int digit,string s)
        {
            Console.WriteLine(digit+" "+s);
        }
    }
}
