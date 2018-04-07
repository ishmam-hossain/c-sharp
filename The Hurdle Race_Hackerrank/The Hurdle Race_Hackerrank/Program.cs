using System;
using System.Linq;

namespace The_Hurdle_Race_Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            int result = hurdleRace(k, height);
            Console.WriteLine(result);


            Console.ReadKey();
        }

        static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();

            if (max < k)
                return 0;
            else
                return Math.Abs(max - k);
        }
    }
}
