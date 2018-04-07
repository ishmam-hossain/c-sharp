using System;

namespace superDigit_amreen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            string n = tokens_n[0];
            ulong k = Convert.ToUInt64(tokens_n[1]);
            ulong result = digitSum(n, k);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.ReadKey();
        }

        static ulong Sum(ulong n)
        {

            ulong result = 0;
            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }
            if ((result / 10) > 0)
            {
                result = Sum(result);
                return result;
            }
            else
                return result;

        }
        static ulong digitSum(string n, ulong k)
        {
            ulong result = 0;

            for (int i = 0; i < n.Length; i++)
                result += Convert.ToUInt64(n[i]) - '0';

            result *= k;

            if ((result / 10) > 0)
            {
                result = Sum(result);
                return result;
            }
            else
                return result;
        }
    }
}
