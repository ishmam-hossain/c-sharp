using System;

namespace BeautifulDay_orbitax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int k = Convert.ToInt32(tokens_i[2]);
            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);

            Console.ReadKey();
        }


        static int beautifulDays(int i, int j, int k)
        {
            // Complete this function
            int countOfBeautifulDay = 0;

            for (int day = i; day <= j; day++)
            {
                int rev = 0;
                int cur = day;
                while (cur > 0)
                {
                    int rem = cur % 10;
                    rev = rev * 10 + rem;
                    cur /= 10;
                }


                if (Math.Abs(day - rev) % k == 0)
                {
                    countOfBeautifulDay++;
                }
            }

            return countOfBeautifulDay;
        }
    }
}



            //for(int x = num1; x <= num2; x++)
            //{
            //    int rev = 0;
            //    int cur = x;
            //    while (cur > 0)
            //    {
            //        int rem = cur % 10;
            //        rev = rev* 10 + rem;
            //        cur /= 10;
            //    }

            //    Console.WriteLine(x+" "+rev);
            //}




//                    string revDayStr = "";

//string dayStr = day.ToString();

//                for(int x = dayStr.Length - 1; x >= 0; x--)
//                {
//                    revDayStr += dayStr[x];
//                }

//                int revDay = Convert.ToInt32(revDayStr);
//            for(int day = i; day <= j; day++)
//            {
//                string dayStr = day.ToString();
//char[] digitChar = dayStr.ToCharArray();
//Array.Reverse(digitChar);
//                string revStr = string.Join("", digitChar);
//int dayRev = Convert.ToInt32(revStr);

//                if (Math.Abs(day-dayRev) % k == 0)
//                {
//                    countOfBeautifulDay++;
//                }
//            }


//while (day > 0)
//{
//    int remainder = day % 10;
//    revDay = (revDay * 10) + remainder;
//    day = day / 10;
//}

//while (day > 0)
//{
//    int rem = day % 10;
//    revDay = (revDay * 10) + rem;
//    day = day/ 10;
//}
// Console.WriteLine(revDay);