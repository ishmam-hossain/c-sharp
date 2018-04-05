using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int number_one = Convert.ToInt32(a, 2);
            int number_two = Convert.ToInt32(b, 2);
            string res = Convert.ToString(number_one+number_two,2);
            Console.WriteLine("-------------------");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
