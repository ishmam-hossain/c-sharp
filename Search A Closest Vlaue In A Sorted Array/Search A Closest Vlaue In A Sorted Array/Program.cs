using System;

namespace Search_A_Closest_Vlaue_In_A_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {2,5,6,7,8,8,9};

            int num = Convert.ToInt32(Console.ReadLine());
            SearchClosestValue(values,num);

            Console.ReadKey();
        }

        static int diff = 99999, index = -1;

        static void SearchClosestValue(int[] values,int num)
        {
            foreach(int value in values)
            {
                if (value == num)
                {
                    index = Array.IndexOf(values, value);
                    break;
                }
                else
                {
                    if (Math.Abs(num - value) < diff)
                    {
                        diff = Math.Abs(num - value);
                        index = Array.IndexOf(values, value);
                    }                    
                }
            }

            Console.WriteLine(values[index]);
        }
    }
}
