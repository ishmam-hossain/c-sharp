using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forward_reverse_one_with_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            int dif = 1;

            //while (i > 0)
            //{
            //    Console.Write(i + " ");

            //    if (i >= n - 1)
            //    {
            //        dif = -dif;

            //    }
            //    i += dif;

            //}

            for (; i > 0; )
            {
                Console.Write(i + " ");

                if (i >= n - 1)
                {
                    dif = -dif;

                }
                i += dif;

            }


            Console.ReadKey();
           
        }
    }
}
