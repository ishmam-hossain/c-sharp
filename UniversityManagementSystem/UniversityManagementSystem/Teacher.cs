using System;

namespace UniversityManagementSystem
{
    class Teacher : AbstractPrintFullName,IprintSalaryOrTutionFee
    {
        string firstName, lastName;
        double salary;

        public Teacher(string fn,string ln,double sal)
        {
            firstName = fn;
            lastName = ln;
            salary = sal;

            printFullName(firstName,lastName);
            printSalOrTutionFee();
        }

        public void printSalOrTutionFee()
        {
            Console.WriteLine("Teacher's Salary = "+salary);
        }
    }
}
