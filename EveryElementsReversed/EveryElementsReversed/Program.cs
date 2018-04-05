using System;

namespace EveryElementsReversed
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            Console.WriteLine(reverseTheInputString(input));

            Console.ReadKey();
        }

        private static string reverseTheInputString(string input)
        {
            string final = null;

            string[] splits = input.Split(' ');
            foreach (string s in splits)
            {
                char[] a = s.ToCharArray();
                Array.Reverse(a);

                string result = new string(a);
                final += result;
                final += " ";
            }

            return final;
        }
    }
}
