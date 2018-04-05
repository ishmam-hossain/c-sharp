using System;

namespace UniversityManagementSystem
{
    class Student : AbstractPrintFullName,IprintSalaryOrTutionFee
    {
        string firstName, lastName;
        double tutFee;

        public Student(string fn,string ln,double fee)
        {
            firstName = fn;
            lastName = ln;
            tutFee = fee;

            printFullName(firstName,lastName);
            printSalOrTutionFee();
        }

        public void printSalOrTutionFee()
        {
            Console.WriteLine("Student's Tution Fee = "+tutFee);
        }
    }
}
