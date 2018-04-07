using System;

namespace Scale_Master
{
    class Program
    {
        static string[] scaleNotes= { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#",
                                        "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

        static void Main(string[] args)
        {
            Console.Write("Enter the scale name : ");
            string inputNote = Console.ReadLine().ToUpper();
            if(!inputNote.Contains("major"))
            {
                int index = Array.IndexOf(scaleNotes, inputNote);
                PrintScale(index);

            }
            else
                Console.WriteLine("Wrong Keyword !!");

            Console.ReadKey();
        }

        private static void PrintScale(int index)
        {
            for (int i = index; i < index+14;)
            {
                Console.Write(scaleNotes[i]+" ");

                if ((i == (index + 4)) || (i == (index + 11)))
                    i++;
                else
                    i+=2;
            }
        }


    }
}
