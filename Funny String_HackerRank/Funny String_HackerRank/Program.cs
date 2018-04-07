using System;

namespace Funny_String_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = funnyString(s);
                Console.WriteLine(result);
                funnyString(s);
            }

            Console.ReadKey();
        }

        static string funnyString(string s)
        {
            char[] rA = s.ToCharArray();
            Array.Reverse(rA);
            string r = new string(rA);

            //Console.WriteLine(r);
            Boolean fun = false;

            for (int i = 1; i < s.Length; i++)
            {
                int val = Math.Abs( (s[i] - s[i-1]) ) - Math.Abs((r[i] - r[i - 1]));

                Console.WriteLine(val);
                if( val != 0 )
                {
                    fun = false;
                    break;
                }
                else
                {
                    fun = true;
                }
            }
            if (fun)
            {
                return "Not Funny";
            }
            else
            {
                return "Funny";
            }

        }

    }
}
