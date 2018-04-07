using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Grading_Students_HackerRank
{
    class Program
    {
        static int[] solve(int[] grades)
        {
            int[] mods = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    mods[i] = grades[i] % 5;

                    if((grades[i]+(5-mods[i]) - grades[i]) < 3 )
                    {
                        grades[i] = grades[i] + (5 - mods[i]);
                    }
                }
            }

            return grades;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }


            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n", result));

            Console.ReadKey();
        }
    }
}

