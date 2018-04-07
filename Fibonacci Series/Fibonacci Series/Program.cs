using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciRecursion(n));

            Console.ReadKey();
        }

        static int FibonacciRecursion(int n) // return the exact one value
        {
            if (n <= 1)
                return n;
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        static void FibonacciNormal() // return all the values till the input
        {
            int first = 1, sec = 1, latest = 0;

            int limit = Convert.ToInt32(Console.ReadLine());

            Console.Write(first + " " + sec);

            for (int i = 1; i <= limit; i++)
            {
                latest = first + sec;
                Console.Write(" " + latest);

                first = sec;
                sec = latest;
            }
        }
    }
}
