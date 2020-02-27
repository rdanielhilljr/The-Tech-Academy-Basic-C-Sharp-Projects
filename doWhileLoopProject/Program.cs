using System;

namespace doWhileLoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Guess a number between 1 and 5:");
            //    string userNumber = "4";
            //    string num;
            //    int count = 0;
            //    do
            //    {
            //        num = Console.ReadLine();
            //        count++;
            //    } while (num != userNumber && count < 2);

            //    if (num == userNumber)
            //        Console.WriteLine("You picked the right number!!");
            //    else
            //        Console.WriteLine("You didn't pick the right number!");
            //}

            
            int counter = 0;
            while (counter < 11)
            {
                Console.WriteLine("Tech Academy Rules");
                counter++;
            }
                
            Console.ReadLine();
        }
    }
}
