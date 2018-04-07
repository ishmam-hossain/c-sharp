using System;
using System.Text;

namespace HackerRank_SImple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            int q = Convert.ToInt32(Console.ReadLine());
            int lastop = 0;
            string temp = "";

            for (int i=0;i<q; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        temp = s.ToString();
                        s.Append(Console.ReadLine());
                        lastop = 1;
                        
                        //Console.WriteLine(s);
                        break;

                    case 2:
                        temp = s.ToString();
                        int k = Convert.ToInt32(Console.ReadLine());
                        s.Remove(s.Length - k, k);
                        lastop = 2;
                        Console.Write(s);
                        break;

                    case 3:
                        int l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(s[l-1]);
                        break;

                    case 4:
                        if (lastop == 1)
                        {
                            Console.Write(" " + s);
                            s.Clear();
                            s.Append(temp);
                            Console.WriteLine(s);
                        }
                        else
                        {
                            Console.Write(" " + s);
                            s.Clear();
                            s.Append(temp);
                            Console.WriteLine(s);
                        }
                        break;


                }
            }
            //Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
