using System;

namespace HackerRank_Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputs = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputs[i] = Console.ReadLine();
            }

            int q = Convert.ToInt32(Console.ReadLine());
            string[] queries = new string[q];

            for (int i = 0; i < q; i++)
            {
                queries[i] = Console.ReadLine();
            }

            foreach(string query in queries)
            {
                int counter = 0;
                foreach(string input in inputs)
                {
                    if (input.Equals(query))
                        counter++;
                }

                Console.WriteLine(counter);

            }



            Console.ReadKey();
        }
    }
}
