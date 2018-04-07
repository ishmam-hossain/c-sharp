using System;
using System.Linq;

namespace looptest
{
    class Program
    {
        static void Main(string[] args)
        {
            //looping();
            //reverseString();
            //countAppearence();
            reverseStringManual();

            Console.ReadKey();
        }


        static void looping()
        {
            Console.Write("Enter the range: ");
            int range = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < range*2; i++)
            {
                if (i <= range)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write((range*2)-i + " ");
                }
            }
        }

        static void reverseString()
        {
            string s = Console.ReadLine();
            string[] words = s.Split(" ");

            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));

        }

        static void countAppearence()
        {
            int[] numbers = { 5, 4, 5, 1, 7, 5, 7, 6, 8, 5, 7, 8, 6, 5, 3 };
            int[] position = new int[numbers.Length];
            int[] counter = new int[numbers.Length];
            int index = 0;

            Console.WriteLine(string.Join(" ",numbers));

            foreach(int number in numbers)
            {
                if (!position.Contains(number))
                {
                    position[index] = number;
                    counter[Array.IndexOf(position, number)]++;
                    index++;
                }
                else
                {
                    counter[Array.IndexOf(position, number)]++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",position));
            Console.WriteLine(string.Join(" ", counter));

        }

        static void reverseStringManual()
        {
            string s = Console.ReadLine();
            string test = s.Replace(" ", "");

            string[] words = new string[s.Length - test.Length + 1];

            string rev = "";
            int last = s.Length - 1;


            for(int i = s.Length-1; i>= 0; i--)
            {
                if(s[i].Equals(' '))
                {
                    for(int j = i+1; j <= last; j++)
                    {
                        rev += s[j];
                        last = i;
                    }
                }

                //last = i+1;

            }

            Console.WriteLine(rev);
        }
    }
}
