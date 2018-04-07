using System;

namespace TimeConversion_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }





        static string timeConversion(string s)
        {
            string res = "";

            if (s.Contains("AM"))
            {
                s = s.Replace("AM", "");
                res = s;

            }
            else
            {
                s = s.Replace("PM", "");
                string[] times = s.Split(':');

                int hr = Convert.ToInt32(times[0]);
                hr += 12;
                if (hr == 24)
                {
                    res+= "00:" + times[1] + ":" + times[2];
                }
                else
                {
                    res+= hr.ToString() + ":" + times[1] + ":" + times[2];
                }

            }

            return res;

        }
    }
}
