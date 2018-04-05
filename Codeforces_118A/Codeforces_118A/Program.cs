using System;
using System.Text.RegularExpressions;

namespace Codeforces_118A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.ToLower();
            
            Regex pattern = new Regex("[aeiouy]");
            input = pattern.Replace(input, "");

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("."+input[i]);
            }

            Console.ReadKey(); // this is the line why I got RTE -_-
        }
    }
}
