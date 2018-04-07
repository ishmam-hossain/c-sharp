using System;

namespace reverseNu
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            for( int x = num1; x <= num2; x++)
            {
                int rev = 0;
                int cur = x;
                while (cur > 0)
                {
                    int rem = cur % 10;
                    rev = rev * 10 + rem;
                    cur /= 10;
                }

                Console.WriteLine(x+" "+rev);
            }



            Console.ReadKey();
        }
    }
}
