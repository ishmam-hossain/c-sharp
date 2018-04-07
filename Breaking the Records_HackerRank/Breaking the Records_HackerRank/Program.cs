using System;

namespace Breaking_the_Records_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] score_temp = Console.ReadLine().Split(' ');
            int[] score = Array.ConvertAll(score_temp, Int32.Parse);
            int[] result = breakingRecords(score);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();
        }

        static int[] breakingRecords(int[] score)
        {
            // Complete this function
            int[] bestWorst = new int[2];
            int high = score[0], low = score[0];

            foreach(int val in score)
            {
                if (val > high)
                {
                    high = val;
                    bestWorst[0]++;
                }
                else if (val < low)
                {
                    low = val;
                    bestWorst[1]++;
                }
            }

            return bestWorst;
        }
    }
}
