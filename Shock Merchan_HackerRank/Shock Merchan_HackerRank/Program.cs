using System;
using System.Collections.Generic;
using System.Linq;

namespace Shock_Merchan_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);

            Console.ReadKey();
        }


        static int sockMerchant(int n, int[] ar)
        {
            // Complete this function
            int counter = 0;
            Dictionary<int, int> pair = new Dictionary<int, int>();

            foreach(int val in ar)
            {
                if (pair.ContainsKey(val))
                {
                    pair[val]++;
                }
                else
                {
                    pair.Add(val, 1);
                }
            }

            //foreach (KeyValuePair<int, int> kvp in pair)
            //{
            //    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            foreach (int val in pair.Values)
            {
                if (val % 2 == 0)
                    counter += val / 2;
                else if( val > 2 )
                    counter += val % 2;
            }

            return counter;

        }
    }
}
