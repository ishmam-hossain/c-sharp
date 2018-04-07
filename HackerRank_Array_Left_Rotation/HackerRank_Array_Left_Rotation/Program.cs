using System;

namespace HackerRank_Array_Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            //int[] result = leftRotation(a, d);
            //Console.WriteLine(String.Join(" ", result));

            Better(a,d,n);

            Console.ReadKey();
        }

        static int[] leftRotation(int[] a, int d)
        {
            for(int i = 1; i <= d; i++)
            {
                int temp = a[0];
                for(int j = 0; j < a.Length; j++)
                {
                    if (j < a.Length-1)
                    {
                        a[j] = a[j + 1];
                    }
                    else
                    {
                        a[j] = temp;
                    }

                }
            }
            return a;
        }

        static void Better(int[] a, int d,int n)
        {
            d %= n;
            int[] ans = new int[a.Length];

            for (int i = 0; i < n; i++)
            {
                ans[(n + i - d) % n] = a[i];
            }
            Console.WriteLine(string.Join(' ',ans));
        }

    }
}
