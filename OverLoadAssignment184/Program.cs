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
            Program myProgram = new Program();
            myProgram.DoSomething();
        }

        public void DoSomething()
        {
            Employee emp1 = new Employee();
            emp1.EmployeeID = 2;

            Employee emp2 = new Employee();
            emp2.EmployeeID = 1;

            Console.WriteLine(emp1.Equals(emp2));
            Console.ReadLine();
        }
    }

    

        
    
}
