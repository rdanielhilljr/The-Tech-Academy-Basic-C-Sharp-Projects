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
            //employee.SayName();
            employee.Quit();
            Console.ReadLine();
        }
        
    }
}
