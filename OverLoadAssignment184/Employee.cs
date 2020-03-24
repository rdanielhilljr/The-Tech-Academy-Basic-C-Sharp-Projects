using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OverLoadAssignment184
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.EmployeeID.Equals(emp2.EmployeeID);
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return ! emp1.EmployeeID.Equals(emp2.EmployeeID);
        }

    }
}

