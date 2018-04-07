using System;

namespace insertion1_hackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            insertionSort1(size, arr);
            Console.ReadKey();
        }

        static void insertionSort1(int size, int[] arr)
        {
            int chekVal = arr[size - 1];

            for(int i = size-2; i>=0; i--)
            {
                if( chekVal < arr[i] )
                {
                    arr[i + 1] = arr[i];
                }
                else
                {
                    arr[i+1] = chekVal;
                }

                Console.WriteLine(String.Join(' ', arr));
            }


        }
    }
}
