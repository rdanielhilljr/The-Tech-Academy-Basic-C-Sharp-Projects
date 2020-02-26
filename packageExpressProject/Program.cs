using System;

namespace packageExpressProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int userWeight = Convert.ToInt32(Console.ReadLine());
            if (userWeight >= 51)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else 
            {
                Console.WriteLine("Please enter the package width:");
                int userWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int userHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int userLength = Convert.ToInt32(Console.ReadLine());
                int userDimensions = userWidth + userHeight + userLength;
                if (userDimensions >= 51)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal userQuote = Convert.ToDecimal(userWidth * userHeight * userLength * userWeight) / 100;
                    string newUserQuote = userQuote.ToString("#,##0.00");
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + newUserQuote);
                    Console.WriteLine("Thank You.");
                    Console.ReadLine();
                    
                }




            }
        }
    }
}
