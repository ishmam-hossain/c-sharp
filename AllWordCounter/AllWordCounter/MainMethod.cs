using System;
using System.Collections.Generic;

namespace AllWordCounter
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            counterMethod(inputString);

            Console.ReadKey();
        }

        private static void counterMethod(string input)
        {
            List<string> wordList = new List<string>(); 
            int[] countArray = new int[input.Length];

            string[] splitArray = input.Split();

            foreach (String s in splitArray)
            {
                if (!wordList.Contains(s))
                {
                    wordList.Add(s);
                    int index = wordList.IndexOf(s);
                    countArray[index] = 1;
                }
                else
                {
                    int index = wordList.IndexOf(s);
                    countArray[index]++; 
                }                    
            }

            Console.WriteLine("\n\n");
            foreach (string str in wordList)
            {
                Console.WriteLine("* '"+str+"' occured "+countArray[wordList.IndexOf(str)]+" time(s).");
            }

        }
    }
}
