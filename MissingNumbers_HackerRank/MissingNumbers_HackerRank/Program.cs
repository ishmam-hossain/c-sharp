using System;
using System.Linq;
using System.Collections.Generic;

namespace MissingNumbers_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] brr_temp = Console.ReadLine().Split(' ');
            int[] brr = Array.ConvertAll(brr_temp, Int32.Parse);
            int[] result = missingNumbers(arr, brr);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();
        }


        static int[] missingNumbers(int[] arr, int[] brr)
        {
            Array.Sort(arr);
            Array.Sort(brr);

            List<int> missing = new List<int>();

            for(int b = 0; b < brr.Length; b++)
            {
                if ( b<arr.Length && !(brr[b] == arr[b]) && !missing.Contains(brr[b]) )
                {
                    missing.Add(brr[b]);
                }
            }


            return missing.ToArray();
        }
    }
}


// && !missing.Contains(brr[b])