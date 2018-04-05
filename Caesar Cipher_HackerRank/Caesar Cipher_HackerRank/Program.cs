using System;

namespace Caesar_Cipher_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            char[] cArray = s.ToCharArray();

            for(int i =0; i<cArray.Length;i++)
            {
                if ((cArray[i] >= 'a' && cArray[i] <= 'z') || (cArray[i] >= 'A' && cArray[i] <= 'Z'))
                {
                    if (cArray[i] == 'z')
                    {
                        cArray[i] = (char) 96;
                    }
                    else if(cArray[i] == 'Z')
                    {
                        cArray[i] = (char) 64;
                    }

                    cArray[i] = (char)((int)(cArray[i] + k));
                }

            }

            string res = new string(cArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
