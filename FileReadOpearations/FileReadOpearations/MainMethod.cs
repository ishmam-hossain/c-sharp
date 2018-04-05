using System;
using System.IO;
using System.Collections.Generic;

namespace FileReadOpearations
{
    class MainMethod
    {
        static List<string> wordList = new List<string>();
        static int[] countArray = new int[500];

        static void Main(string[] args)
        {
            string input;
            StreamReader read = new StreamReader(@"G:\C#\test.txt");
            while((input = read.ReadLine()) != null)
            {
                counterMethod(input);
            }

            read.Close();

            foreach (string str in wordList)
            {
                Console.WriteLine("' " + str + "'   occured--- " + countArray[wordList.IndexOf(str)] + " ---time(s).");
            }

            Console.ReadKey();
        }


        private static void counterMethod(string inputFromMainMethod)
        {
            //inputFromMainMethod= inputFromMainMethod.Replace('.', ' ');
            string[] splitArray = inputFromMainMethod.Split();

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
        }
    }
}
