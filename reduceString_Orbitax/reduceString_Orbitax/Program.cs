using System;

namespace reduceString_Orbitax
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string final = "";
            foreach(char c in s)
            {
                if (!final.Contains(c.ToString()))
                {
                    final += c;
                }
            }
            Console.WriteLine(final);

            Console.ReadKey();
        }
    }
}
