using System;

namespace SuperDigit_Orbitax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            string n = tokens_n[0];
            int k = Convert.ToInt32(tokens_n[1]);
            int result = digitSum(n, k);
            Console.WriteLine(result);


            Console.ReadKey();
        }

        static int digitSum(string n, int k)
        {
            string res = "";
            for (int i = 1; i <= k; i++)
            {
                res = res + n;
            }
            int num = Convert.ToInt32(res);



            return 0;
        }
    }
}



//int final = 0;
//            while (num > 0)
//            {
//                while (sum > 9)
//                {
//                    int sum = 0;
//sum += num % 10;
//                    num /= 10;
//                    final = sum;
//                }
//            }

//            //int final = cal(num);
//            // return final;

//            return final;