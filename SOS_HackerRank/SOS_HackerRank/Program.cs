using System;
using System.Collections.Generic;
using System.Linq;

namespace SOS_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] old = s.ToCharArray();
            
            string[] newString = new string[1000];

            for(int i = 0;i<old.Length;i+=3)
            {
                for(int j =i;j<(i+3);j++)
                {
                    newString[i] = old[j];
                }
                

                //Console.Write(old[i]);
            }

            Console.ReadKey();
        }

    }
}
