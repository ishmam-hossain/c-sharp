using System;
using System.Numerics;

namespace BigSort_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            //string[] result = bigSorting(arr);
            //Console.WriteLine(String.Join("\n", result));

            test(arr);

            Console.ReadKey();
        }

        static string[] bigSorting(string[] arr)
        {
            // Complete this function

            BigInteger[] a = Array.ConvertAll(arr, BigInteger.Parse);
            Array.Sort(a);
           
            string[] final = new string[arr.Length];
            int i = 0;
            foreach(BigInteger big in a)
            {
                final[i] = big.ToString();
                i++;
            }

            return final;
        }

        static void test(string[] t)
        {

            Array.Sort(t);
            Console.WriteLine();
            Console.WriteLine(String.Join('\n',t));
        }
    }
}



/*


6
31415926535897932384626433832795
1
3
10
3
5


*/