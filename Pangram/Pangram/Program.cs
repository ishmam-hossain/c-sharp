using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Regex pattern = new Regex("[.,?:;'! ]");
            input = pattern.Replace(input, "");


            CheckPangram(input);
            Console.ReadKey();
        }

        // Pangram is a line containg each alphabet "at least once" !
        public static void CheckPangram(string input)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            int[] doesItExist = new int[26];

            for(int i = 0;i < doesItExist.Length; i++)
            {
                doesItExist[i] = 1;
            }

            foreach(char c in input)
            {
                if(alpha.Contains(c))
                {
                    doesItExist[alpha.IndexOf(c)] = 0;
                }
            }

            if(doesItExist.Sum() != 0)
            {
                Console.WriteLine("Not Pangram!");
            }
            else
            {
                Console.WriteLine("Hurray!! Pangram!");
            }


        }
    }
}
