using System;
using System.IO;

namespace MiniCodeCompiler
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadFile();

            Console.ReadKey();
        }

        static void ReadFile()
        {
            StreamReader file = new StreamReader(@"G:\C#\test.txt");
            string line, allText = "";
            //int comment = 0;

            while((line = file.ReadLine()) != null)
            {
                allText += line.Trim();
            }

            Console.WriteLine(allText);

            file.Close();
        }
    }
}
