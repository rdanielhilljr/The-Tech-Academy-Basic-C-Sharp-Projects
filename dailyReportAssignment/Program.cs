using System;

namespace dailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy" + Environment.NewLine + "Student Daily Report");
            Console.WriteLine("What Course are you on?");
            string myCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int myPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? (Please answer true or false)");
            bool myHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Was there any positive experiences you would like to share? Please be specific");
            string myXp = Console.ReadLine();
            Console.WriteLine("Is there any feedback you would like to provide?");
            string myFeedBack= Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int myHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You indicated that you are on the " + myCourse + " course " + " page " + myPage + " and said " + myHelp + " regarding your need for help.");
            Console.WriteLine("You studied " + myHours + " hours today.");
            Console.WriteLine("You said your positve experiences were: " + Environment.NewLine + myXp + Environment.NewLine + "Here is the feedback you provided:  " + 
                Environment.NewLine + myFeedBack);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();




            









        }
    }
}
