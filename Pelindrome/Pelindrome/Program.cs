using System;

namespace Pelindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a rather inefficient approach of solving the problem
            // there is a better approach than this one
            checkPelindrome();
            Console.ReadKey();
        }


        public static void checkPelindrome()
        {
            Console.Write("Enter the word to check if Pelindrome: ");
            string pel = Console.ReadLine().ToLower().Replace(" ", "").Replace(",", "");

            char[] c = pel.ToCharArray();
            string first = "";
            string second = "";

            if (pel.Length % 2 != 0)
            {
                for (int i = 0; i <= (pel.Length / 2); i++)
                {
                    first += c[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i <= (pel.Length / 2) - 1; i++)
                {
                    first += c[i].ToString();
                }
            }

            Console.WriteLine(first);

            for (int j = pel.Length - 1; j >= (pel.Length / 2); j--)
            {
                second += c[j].ToString();
            }

            Console.WriteLine(second);

            if (first.Equals(second))
            {
                Console.WriteLine("* Yes! It is a pelindrome! ");
            }
            else
            {
                Console.WriteLine("* No! Not a pelindrome! ");
            }

        }
  
    }
}
