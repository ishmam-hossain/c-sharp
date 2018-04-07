using System;

namespace EvenSumOfArraay
{
    class Program
    {
        static void Main(string[] args)
        {
            //CheckEven();
            RemoveDollarSign();

            Console.ReadKey();

        }

        static void CheckEven()
        {
            Random rnd = new Random();
            int[] values = new int[rnd.Next(1, 20)];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rnd.Next(1, 10);
                Console.Write(values[i]+" ");
            }

            int sum = 0;

            foreach(int val in values)
            {
                if (val % 2 == 0)
                {
                    sum += val;
                }
            }

            Console.WriteLine("\n\n"+sum);
        }

        static void RemoveDollarSign()
        {
            string s = "foo $ bar foo $ bar $ foo bar $";
            string res = "";
            int count = 0;

            foreach(char c in s)
            {
                if(!c.Equals('$'))
                {
                    res += c;
                }
                else
                {
                    count++;
                    if (count > 1)
                    {
                        res += c;
                    }
                    else
                    {
                        //continue;
                    }
                }
            }

            Console.WriteLine(res.Trim());

        }
    }
}
