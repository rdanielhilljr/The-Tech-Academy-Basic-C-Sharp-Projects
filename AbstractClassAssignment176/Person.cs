using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment176
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
