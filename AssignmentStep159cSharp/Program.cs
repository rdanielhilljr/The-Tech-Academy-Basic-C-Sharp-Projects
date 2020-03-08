using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentStep159cSharp
{
    class Program
    {
        static void Main(string[] args)
            // Challenge 1 and 2
        {
            Console.WriteLine("Provide a whole number to see what that number plus 10 is equal to.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int userSolution = MyMath.Computation(userNum1);
            Console.WriteLine(userNum1 + " + 10 = " + userSolution);
            Console.ReadLine();

            // Challenge 3 and 4

            Console.WriteLine("Provide a number larger than 10.5 to see what that number minus 10.5 is equal to.");
            decimal userDecimal1 = Convert.ToDecimal(Console.ReadLine());
            decimal userSolution2 = MyMath.Computation(userDecimal1);
            Console.WriteLine(userDecimal1 + " - 10.5 = " + userSolution2);
            Console.ReadLine();

            // Challenge 5 and 6

            Console.WriteLine("Provide a number to see what that number times 10 is equal to.");
            string userString1 = Console.ReadLine();
            string userSolution3 = MyMath.Computation(userString1);
            Console.WriteLine(userString1 + " * 10 = " + userSolution3);
            Console.ReadLine();
        }
    }
}
 