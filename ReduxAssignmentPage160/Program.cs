using System;

namespace ReduxAssignmentPage160
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one or two whole numbers (one at a time) to see what your number plus five equals:");
            int userPick = Convert.ToInt32(Console.ReadLine());
            int yourNum = Computation.Adds(userPick);
            Console.WriteLine(userPick + " + 5 = " + yourNum);
            string userPick2 = Console.ReadLine();
            if (userPick2 == "")
            {
                Console.WriteLine("Thanks, have a great day!");
            }
            else
            {
                int UserPick3 = Convert.ToInt32(userPick2);
                int yourNum2 = Computation.Adds(UserPick3);
                Console.WriteLine(userPick2 + " + 5 = " + yourNum2);
            }
            Console.ReadLine();
        }
    }
}
