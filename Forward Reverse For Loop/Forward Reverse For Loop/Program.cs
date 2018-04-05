using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forward_Reverse_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+" ");

                if (i == n)
                {
                    int j = i-1;
                    while (j > 0)
                    {
                        Console.Write(j+" ");
                        j--;
                    }
                }
 
            }

            Console.ReadKey();
        }
    }
}
