using System;
using System.Text;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "When I root ";
            string secondString = "I root ";
            string thirdString = "for the Timbers!";
            string timbers = (firstString + secondString + thirdString + "\n");
            string bigTimbers = timbers.ToUpper();
            Console.WriteLine(bigTimbers);

            string strOne = "The woods are lovely, dark and deep,\n";
            StringBuilder sb = new StringBuilder(strOne);
            sb.Append("But I have promises to keep\n");
            sb.Append("And miles to go before I sleep,\n");
            sb.Append("And miles to go before I sleep.");
            Console.WriteLine(sb);
            Console.ReadLine();

               
        }
    }
}
