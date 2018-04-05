using System;

namespace OOPtesting
{
    class Employee:InterfaceClass
    {
        int ID;
        string firstName, lastName;

        //----------constructor without parameter---------------
        public Employee()
        {
            Console.WriteLine("* No Id or Name Provided !\n\n");
        }

        //----------constructor with parameter---------------
        public Employee(int id, string fn, string ln)
        {
            this.ID = id;
            this.firstName = fn;
            this.lastName = ln;

            Console.WriteLine("Employee Id: {0}\nEmployee Name: {1} {2}\n", this.ID, this.firstName, this.lastName);

        }

        public void print()
        {
            Console.WriteLine("Hi from Interface");
            //throw new NotImplementedException();
        }
    }
}
