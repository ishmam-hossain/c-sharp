using System;

namespace OOPtesting
{
    abstract class AbstractClass
    {
        public int _a = 100, _b = 300;
        public int a { get; }
        public int b { get; }

        void showDetails()
        {
            Console.WriteLine("Deetails");   
        }

        abstract public void printNothing()
        {
            Console.WriteLine(_a + _b);
        }

    }
}
