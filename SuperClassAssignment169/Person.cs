using System;
using System.Collections.Generic;
using System.Text;

namespace SuperClassAssignment169
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.Write("Name: " + FirstName + " " + LastName);
        }
    }
}
