using System;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Multiplies a user given number by 50 and displays the total.
            Console.WriteLine("Supply a number that will be multiplied by 50."); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = num1 * 50;
            Console.WriteLine("Your numbers total " + num2);
            Console.ReadLine();

            // Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Supply a number.");
            int myNum = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine("Your number with 25 added to it is equal to " + myNum);

            //Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Supply a number that will be divided by 12.5");
            double dblNum1 = Convert.ToDouble(Console.ReadLine());
            double dblNum2 = dblNum1 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + dblNum2);


            //Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Supply a number...");
            int yourNum1 = Convert.ToInt32(Console.ReadLine());
            int myNum2 = 50;
            bool ourNums = yourNum1 > myNum2;
            Console.WriteLine(ourNums);


            //Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Please provide a number that will by divided by 7...");
            int myMod = Convert.ToInt32(Console.ReadLine());
            int myRemainder = myMod % 7;
            Console.WriteLine("When divided by seven, you have a remainder of " + myRemainder);















        }

    }
}
