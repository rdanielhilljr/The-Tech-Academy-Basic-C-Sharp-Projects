using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment176
{
    public class Employee : Person
    {
       public override void SayName()
        {
            Console.WriteLine("Employee Name:");
            base.SayName();
        }
    }
}
