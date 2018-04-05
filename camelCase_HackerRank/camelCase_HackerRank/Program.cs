using System;
using System.Text;

namespace camelCase_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            char[] cArray = s.ToCharArray();
            int count = 1;

            foreach(char c in cArray)
            {
                int n = (int)c;
                if (n>=65 && n<=90)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
