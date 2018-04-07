using System;
using System.Linq;

namespace UVA_P524
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] circular = new int[n];
            int[] visited = new int[n];

            circular[0] = visited[0] = 1;
            circular[n-1] = visited[n-1] = SearchPrimeAdjacent(n);

            Console.WriteLine(string.Join(" ",circular));
            Console.WriteLine(string.Join(" ", visited));

            Console.ReadKey();
        }

        static int SearchPrimeAdjacent(int n)
        {
            for(int i = 2; i <= n; i++)
            {
                if(PrimeChecker(i))
                {
                    return i;
                }
            }
            return 0;
        }

        static bool PrimeChecker(int i)
        {
            bool isPrime = false;
            for (int j = 2; j < (i + 1); j++)
            {
                if (!((i + 1) % j == 0))
                {
                    isPrime = true;
                }
                else
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
