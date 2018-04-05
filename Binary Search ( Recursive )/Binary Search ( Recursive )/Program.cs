using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search___Recursive__
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20];
            Random r = new Random();

            for( int i = 0; i<20 ; i++ )
            {
                A[i] = r.Next(0, 100);
            }

            Array.Sort(A);

            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i]+" ");
            }

            Console.WriteLine("\n\nEnter the number to search:  ");
            String n = Console.ReadLine();
            int search = Convert.ToInt32(n);
            int low = 0,    high = A.Length-1;

            Boolean isFound = BinarySearch(A,search,low,high);

            if(isFound)
                Console.WriteLine("Found !");
            else
                Console.WriteLine("Not Found !");


            Console.ReadKey();

        }

        public static Boolean BinarySearch(int[] A, int search, int low, int high)
        {
            int mid = (low+high)/2;

            if (low > high)
                return false;

            else
            {
                if( search == A[mid] )
                    return true;

                else if (search > A[mid])
                    return BinarySearch(A, search, mid + 1, high);

                else
                    return BinarySearch(A, search, low, mid - 1);

            }
        }
    }
}
