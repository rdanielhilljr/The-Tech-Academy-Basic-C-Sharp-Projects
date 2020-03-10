using System;

namespace SuperClassAssignment169
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.Id = 25;
            person.SayName();
            Console.ReadLine();

        }
    }
}
