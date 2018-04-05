using System;

namespace Codeforces_158A
{
    class Program
    {
        static void Main(string[] args)
        {
            string nk = Console.ReadLine();
            string pos = Console.ReadLine();
            string[] nkInput = nk.Split(' ');
            string[] positions = pos.Split(' ');

            int n = Convert.ToInt32(nkInput[0]);
            int k = Convert.ToInt32(nkInput[1]);


            Console.WriteLine(n+" "+k);

            Console.ReadKey();
        }
    }
}
