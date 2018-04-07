using System;

namespace RunningTImeOfAlgo_Orbitax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = runningTime(arr);
            Console.WriteLine(result);


            Console.ReadKey();
        }

        static int runningTime(int[] inputArray)
        {

            int counter = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                       int temp = inputArray[j - 1];
                       inputArray[j - 1] = inputArray[j];
                       inputArray[j] = temp;
                       counter++;
                    }
                }
            }
            return counter;
        }
    }
}
