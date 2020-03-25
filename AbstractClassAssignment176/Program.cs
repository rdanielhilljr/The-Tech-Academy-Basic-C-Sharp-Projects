using System;

namespace AbstractClassAssignment176
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = 23;
            Employee employee2 = new Employee();
            employee.firstName = "Ted";
            employee.lastName = "Williams";
            employee.ID = 25;
            employee.SayName();
            //employee.Quit();

            Console.ReadLine();
        }
        
    }
}
