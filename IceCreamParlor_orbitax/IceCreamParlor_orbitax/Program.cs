using System;

namespace IceCreamParlor_orbitax
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                int[] result = icecreamParlor(m, arr);
                Console.WriteLine(String.Join(" ", result));
            }


            Console.ReadKey();
        }

        static int[] icecreamParlor(int m, int[] arr)
        {
            int[] price = new int[2];
            // Complete this function
            for (int cost=0;cost<arr.Length;cost++)
            {
                for(int cost2= 0; cost2 < arr.Length; cost2++)
                {
                    if ( (arr[cost] + arr[cost2]) == m && cost!=cost2)
                    {
                        price[0] = cost+1;
                        price[1] = cost2+1;
                    }
                }
            }

            Array.Sort(price);
            return price;

        }
    }
}
