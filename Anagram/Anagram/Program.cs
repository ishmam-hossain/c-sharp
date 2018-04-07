using System;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //CheckAnagramBySorting();
            //SwapWithoutTemp();
            //RemoveDuplicateFromString();
            //CheckArmstrongNumber();

            Console.ReadKey();
        }

        static void CheckAnagram()
        {
            string frst = Console.ReadLine().ToLower();
            string sec = Console.ReadLine().ToLower();

            Boolean isAnagram = true;
            foreach(char c in sec)
            {
                if(!frst.Contains(c))
                {
                    isAnagram = false;
                    break;
                }
            }

            if (isAnagram)
            {
                Console.WriteLine("Anagram!");
            }
            else
                Console.WriteLine("Not Anagram!");
        }

        static void CheckAnagramBySorting(string frst, string sec)
        {
            Array.Sort(frst.ToCharArray());
            Array.Sort(sec.ToCharArray());
        }

        static void SwapWithoutTemp()
        {
            int a = 5, b = 10;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a + " " + b);
        }

        static void RemoveDuplicateFromString()
        {
            string s = Console.ReadLine().ToLower();
            string res = "";

            foreach(char c in s)
            {
                if(!res.Contains(c))
                {
                    res += c;
                }
            }

            Console.WriteLine(res);
        }

        static void CheckArmstrongNumber()
        {
            string n = Console.ReadLine();
            int len = n.Length;
            int num = Convert.ToInt32(n);
            int res = 0;

            for(int i = 1; i <= len; i++)
            {
                int digit = num % 10;
                num /= 10;
                res +=(int) Math.Pow(digit, len);
            }
            Console.WriteLine(res);

            if (Convert.ToInt32(n) == res)
            {
                Console.WriteLine("Armstrong!");
            }
            else
            {
                Console.WriteLine("Not Armstrong!");
            }
        }



    }


}
