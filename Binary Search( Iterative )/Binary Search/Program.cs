using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * *****  This one is Iterative Binary Search !!
 * */

namespace startAgain
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] my = { 6, 3, 19, 4, 8, 3, 1, 7, 3, 9, 16, 17, 56 };
            int len = my.Length;
            Array.Sort(my);

            Console.Write("Enter the value to be searched: ");
            string v = Console.ReadLine();
            int value = Convert.ToInt32(v);
            Console.WriteLine(value);

            if (BinarySearch(my, len, value))
                Console.WriteLine("Found !");
            else
                Console.WriteLine("Not Found !");

            Console.ReadKey();
        }


        public static Boolean BinarySearch(int[] A, int len, int value)
        {
            int low, high, mid;
            low = 0;
            high = len - 1;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (A[mid] == value)
                    return true;

                else if (value > A[mid])
                    low = mid + 1;

                else
                    high = mid - 1;

            }

            return false;

        }

    }

}
