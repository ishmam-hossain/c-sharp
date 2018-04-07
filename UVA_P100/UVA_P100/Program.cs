using System;

namespace UVA_P100
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int counter, max = 0,n;

            while(i<=j)
            {
                counter = 1;
                n = i;

                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else
                        n = (n * 3) + 1;

                    counter++;
                }
                if (counter > max)
                {
                    max = counter;
                }

                i++;
            }

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
