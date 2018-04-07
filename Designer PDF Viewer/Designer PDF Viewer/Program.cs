using System;
using System.Linq;
using System.Collections.Generic;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            List<int> height = new List<int>(); 

            foreach(char c in word)
            {
                height.Add(h[alpha.IndexOf(c)]);
            }

            int max = height.Max();

            int res = max * word.Length;
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
