using System;

namespace BooleanCarInsuranceCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer Yes or No");
            string myDui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int mySpeed = Convert.ToInt32(Console.ReadLine());

            bool myApplicant = (myAge > 15 && myDui == "No" && mySpeed < 4);
            Console.WriteLine("Is this applicant eligible for car insurance? " + myApplicant);
            Console.ReadLine();

        }
    }
}
