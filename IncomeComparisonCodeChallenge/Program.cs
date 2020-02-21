using System;

namespace IncomeComparisonCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double prsn1Hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double prsn1weekHrs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            double prsn2Hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double prsn2weekHrs = Convert.ToDouble(Console.ReadLine());

            double prsn1Totals = (prsn1Hourly * prsn1weekHrs) * 52;
            double prsn2Totals = (prsn2Hourly * prsn2weekHrs) * 52;

            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(prsn1Totals);

            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(prsn2Totals);

            bool moMoneyMoProblems = prsn1Totals > prsn2Totals;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(moMoneyMoProblems);
            Console.ReadLine();



        }
    }
}
