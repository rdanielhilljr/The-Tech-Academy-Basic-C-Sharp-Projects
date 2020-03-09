using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethodAssignment161
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            int num1 = 5;
            int num2 = 10;

            math.Computation(num1, num2);
            Console.ReadLine();
        }

    }
}
