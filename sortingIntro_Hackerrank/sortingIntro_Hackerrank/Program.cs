using System;
using System.Linq;

namespace sortingIntro_Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            string[] str = Console.ReadLine().Split(" ");
            int[] arr = Array.ConvertAll(str, Int32.Parse);

            int index;
            if (arr.Contains(v))
            {
                index = Array.IndexOf(arr, v);
                Console.WriteLine(index);
            }

            Console.ReadKey();
        }
    }
}
