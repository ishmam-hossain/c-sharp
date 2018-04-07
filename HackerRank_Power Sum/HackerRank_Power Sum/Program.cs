using System;

namespace HackerRank_Power_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int result = powerSum(X, N);
            //Console.WriteLine(result);

            Console.ReadKey();
        }


        static int powerSum(int X, int N)
        {
            // Complete this function
            double[] res = new double[11];

            double limit = 0;
            int i = 0;

            while (limit < X && i<11)
            {
                limit = res[i] = Math.Pow(i, N);
                i++;
            }
            Console.WriteLine(string.Join(' ',res));


            //finding sum combo

            double sum = 0;
            int total = 0;


            for(int j = res.Length - 1; j >= 1; j--)
            {

            }

            return 0;
        }
    }
}
