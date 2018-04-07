using System;
using System.Linq;
using System.Collections.Generic;

namespace SearchInASortedArrayGoogle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = new int[20];
            Random rnd = new Random();
            for(int i =0;i<mainArray.Length;i++)
            {
                mainArray[i] = rnd.Next(1, 100);

            }

            Console.WriteLine(string.Join(" ",mainArray));

            int number = Convert.ToInt32(Console.ReadLine());
            check(mainArray,number);

            Console.ReadKey();
        }

        static void check(int[] arr, int num)
        {
            Array.Sort(arr);
            List<int> visited = new List<int>();

            for(int i =0; i<arr.Length;i++)
            {
                if(arr[i] > num)
                {
                    break;
                }
                else
                {
                    int compliment = num - arr[i];
                    visited.Add(arr[i]);

                    if (arr.Contains(compliment) && (!visited.Contains(compliment)))
                    {
                        Console.WriteLine(arr[i] + " " + compliment);
                    }
                    else
                    {
                        Console.WriteLine("No!");
                    }
                }
            }
        }
    }
}
