using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OverLoadAssignment184
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee emp1 = new Employee();
            //emp1.EmployeeID = 2;

            //Employee emp2 = new Employee();
            //emp2.EmployeeID = 1;

            //Console.WriteLine(emp1 == emp2);

            //List<string> things = new List<string> { "Bill", "Ted", "Jan" };

            //foreach (string i in things)
            //{
            //    Console.WriteLine(i);
            //}

            Employee<string> employee = new Employee<string>();
            Employee<int> employee2 = new Employee<int>(); 
            employee.things = new List<string>() { "Ted", "Frank", "Bill" };
            employee2.things = new List<int>() { 1, 2, 3};
            foreach (string i in employee.things)
            {
                Console.WriteLine(i);
            }
            foreach (int x in employee2.things)
            {
                Console.WriteLine(x);
            }















        }
    }

    

        
    
}
