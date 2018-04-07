using System;

namespace InterviewPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindPrime();
            FloydsTriangle();

            Console.ReadKey();
        }

        static void FindPrime()
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());

            Boolean isPrime = false;

            for(int number = start; number <= end; number++)
            {
                for(int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number == divider)
                    {
                        continue;
                    }
                    else
                    {
                        if (!(number % divider == 0))
                        {
                            isPrime = true;
                        }
                        else
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(number + " is a Prime Number in the {0} to {1} region", start, end);
                }
            }            
        }

        static void FloydsTriangle()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 1;

            for (int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(a + " ");
                    a++;
                }
                Console.WriteLine();
            }
        }
    }
}
