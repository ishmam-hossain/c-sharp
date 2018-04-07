using System;
using System.Linq;

namespace Intro_sorting_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i =0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] +" ");
            }

            if (arr.Contains(v))
            {
                int index = Array.IndexOf(arr, v);

                Console.WriteLine("\n"+index);
            }



            Console.ReadKey();
        }
    }
}
