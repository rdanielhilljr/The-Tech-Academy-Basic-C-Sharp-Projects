using System;
using System.Collections.Generic;


namespace userExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{

            //    Console.WriteLine("Pick a number.");
            //    int numOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick another number.");
            //    int numTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two....");
            //    int result = numOne / numTwo;
            //    Console.WriteLine(numOne + " divided by " + numTwo + " = " + result);
            //    Console.ReadLine();

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a Whole Number.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please do not divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}



            // CODE CHALLENGE 1
            try
            {
                List<int> nums = new List<int>() { 200, 400, 600, 800, 1000, 120, 2000 };
                Console.WriteLine("Pick a number to divide each number in the list by");
                int userPick = Convert.ToInt32(Console.ReadLine());
                foreach (int num in nums)
                {
                    Console.WriteLine(num / userPick);

                }
                Console.ReadLine();

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This program has emerged from the try/catch block.");
                Console.ReadLine();
            }
            


            
            


        }
    }
}
