using System;

namespace HourGLass_HackerRank
{
    class Program
    {
        static int[][] arr = new int[3][];

        static void Main(string[] args)
        {
            for (int arr_i = 0; arr_i < 3; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            calculateSumOfHourGlass();

            Console.ReadKey();

        }

        public static void calculateSumOfHourGlass()
        {
            int count = 0;
            int i = 0;
            int j = 0;
            int lineLength = arr.GetLength(0);

            for (; j <= lineLength+1; j++)
            {               
                count += arr[i][j];
            }
            count += arr[i + 1][i + 1];


            Console.WriteLine(count);
        }
    }
}
