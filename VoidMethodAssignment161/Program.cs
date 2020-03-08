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

            math.num2 = 5;
            math.num1 = 10;

            Console.WriteLine(math.num2 + math.num1);
            Console.ReadLine();
        }

    }
}
