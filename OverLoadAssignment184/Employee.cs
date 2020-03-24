using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OverLoadAssignment184
{
    public class Employee<T>
    {
        //public int EmployeeID { get; set; }
        //public string EmployeeName { get; set; }

        //public static bool operator ==(Employee emp1, Employee emp2)
        //{
        //    return emp1.EmployeeID.Equals(emp2.EmployeeID);
        //}

        //public static bool operator !=(Employee emp1, Employee emp2)
        //{
        //    return !emp1.EmployeeID.Equals(emp2.EmployeeID);
        //}

        public List<T> things { get; set; }

    }
}

