﻿using System;

namespace DaysOfWeek
{
    class Program
    {
        enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        


        static void Main(string[] args)
        {
            Console.WriteLine("Enter day of week: ");
            string day = Console.ReadLine();
            foreach (string str in Enum.GetNames(typeof(WeekDay)))
            {
                try
                {
                    if (day == str)
                    {

                        Console.WriteLine("Yes, today is " + str);
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter an actual day of the week.", e);
                }
            }
                
                
                






        }

        
    }
}
