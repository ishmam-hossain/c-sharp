using System;

namespace revString
{
    class Program
    {
        static void Main(string[] args)
        {
            ManualRev();
            Console.ReadKey();
        }

        static void ManualRev()
        {
            string input = Console.ReadLine();
            int bgn = 0, end = input.Length;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    for (int x = 0; x < bgn; x++)
                    {
                        Console.Write(input[x]);
                    }
                }
                else if (!input[i].Equals(' '))
                {
                    continue;
                }
                else
                {
                    bgn = i + 1;
                    for (int j = bgn; j < end; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.Write(" ");
                    end = i;
                }
            }
        }
    }
}

