using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCreationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a whole number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a second whole number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int result = Computation.Add(num1, num2);
            //int result2 = Computation.Subtract(num1, num2);
            //int result3 = Computation.Multiply(num1, num2);
            //Console.WriteLine(num1 + " + " + num2 + " = " + result);
            //Console.WriteLine(num1 + " - " + num2 + " = " + result2);
            //Console.WriteLine(num1 + " * " + num2 + " = " + result3);
            //Console.ReadLine();

            Console.WriteLine("Please enter two whole numbers (one at a time) to see what your number plus five equals:");
            int userPick = Convert.ToInt32(Console.ReadLine());
            int yourNum = Computation.Addition(userPick);
            Console.WriteLine(userPick + " + 5 = " + yourNum);
            int userPick2 = Convert.ToInt32(Console.ReadLine());
            int yourNum2 = Computation.Addition(userPick2);
            Console.WriteLine(userPick2 + " + 5 = " + yourNum2);
            Console.ReadLine();





        }

    }
}
