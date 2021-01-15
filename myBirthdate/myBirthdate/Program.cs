using System;

namespace myBirthdate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Business Application Development
            int year = DateTime.Today.Year;
            int age = 21;
            int myYearOfBirth = year - age;

            Console.Write("My Year of birth is : ");
            Console.WriteLine(myYearOfBirth);
        }
    }
}
