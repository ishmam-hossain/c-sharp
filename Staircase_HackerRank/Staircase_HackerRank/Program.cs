using System;
using System.Linq;
using System.Collections.Generic;

namespace Staircase_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            Divisible_Sum_Pairs();
            Console.ReadKey();
        }

        public static void Divisible_Sum_Pairs()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            //int result = divisibleSumPairs(n, k, ar);
            //Console.WriteLine(result);
            int counter = 0;
            Array.Sort(ar);
            var visited = new List<Tuple<int, int>>();

            //foreach(int v in ar)
            //{
            //    if(!visited.Contains(v))
            //    {
            //        for(int i = 0; i < ar.Length; i++)
            //        {
            //            if( (v + ar[i]) % 3 == 0)
            //            {
            //                counter++;
            //            }
            //        }

            //        visited.Add(v);
            //    }
            //}

            //Console.WriteLine(counter);
        }


        public static void Mini_Max_Sum()
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Array.Sort(arr);
            long lowSum = 0, highSum = 0;

            for(int i = 0; i < 4; i++)
            {
                lowSum += arr[i];
            }
            for (int i = arr.Length - 1 ; i >= arr.Length-4; i--)
            {
                highSum += arr[i];
            }

            Console.WriteLine(lowSum+" "+highSum);
        }


        public static void Birthday_Cake_Candles()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            //int result = birthdayCakeCandles(n, ar);
            //Console.WriteLine(result);

            Array.Sort(ar);

            int max = ar.Max();
            int index = Array.IndexOf(ar, max);

            Console.WriteLine(ar.Length - index);
        }


        public static void StairCase()
        {
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }


                Console.WriteLine();
            }
        }

        public static void PlusMinus()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            double zeros = 0, pos = 0, neg = 0;

            foreach (int a in arr)
            {
                if (a == 0)
                    zeros++;
                else if (a > 0)
                    pos++;
                else
                    neg++;
            }

            Console.WriteLine(pos / arr.Length + "\n" + neg / arr.Length + "\n" + zeros / arr.Length);

        }

        public static void Diagonal_Difference()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int leftDia = 0, rightDia = 0;

            for (int i = 0; i < n ; i++)
            {
                leftDia += a[i][i];
            }

            int j = n-1;
            for (int i = 0; i < n; i++)
            {
                rightDia += a[i][j];
                j--;
            }

            int res = Math.Abs(leftDia - rightDia);
            Console.WriteLine(res);

        }
    }

}


