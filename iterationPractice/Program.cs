using System;
using System.Collections.Generic;
using System.Linq;

namespace iterationPractice
{ 

    class Program
    { 
    static void Main(string[] args)
    {
            // CODE CHALLENGE 1
            //string[] autos = { "Jeep", "Truck", "Motorcycle", "Car" };
            //Console.WriteLine("What is your favorite color?");
            //string favColor = Console.ReadLine();

            //for (int i = 0; i < autos.Length; i++)
            //{
            //    Console.WriteLine(favColor + " " + autos[i]);
            //}
            //Console.ReadLine();



            // CODE Challenge 2 Infinite Loop
            //int monthsInYear = 12;

            //for (int i = 0; i != monthsInYear; i += 5)
            //{
            //    Console.WriteLine("Whoa Nelly...");
            //}



            // CODE CHALLENGE 3 FIX THE LOOP
            //int monthsInYear = 12;

            //for (int i = 0; i != monthsInYear; i ++)
            //{
            //    Console.WriteLine("Whoa Nelly...");
            //}


            // CODE CHALLENGE 4 < operator
            //int monthsInYear = 12;

            //for (int i = 0; i < monthsInYear; i ++)
            //{
            //    Console.WriteLine("Whoa Nelly...");
            //}


            //CODE CHALLENGE 5 <= operator
            //int monthsInYear = 12;

            //for (int i = 0; i <= monthsInYear; i ++)
            //{
            //    Console.WriteLine("Whoa Nelly...");
            //}


            // CODE CHALLENGE 6, 7, 8 UNIQUE LIST OF STRINGS
            //List<string> names = new List<string>() { "John", "Ringo", "Paul", "George" };
            //Console.WriteLine("Who is your favorite Beatle?");
            //string userPick = Console.ReadLine();
            //if (userPick == "John" || userPick == "Ringo" || userPick == "Paul" || userPick == "George")
            //{
            //    int index1 = names.IndexOf(userPick);
            //    Console.WriteLine("Your favorite Beatle is at index: " + index1);
            //}
            //else
            //{
            //    Console.WriteLine("You did not pick a Beatle. Goodbye.");
            //}



            // CODE CHALLENGE 9 and 10
            //List<String> cars = new List<string>() { "Ford", "Jeep", "BMW", "Honda", "Audi", "Honda" };
            //Console.WriteLine("Who is your favorite car maker?");
            //string userPick = Console.ReadLine();
            //int carIndex = (cars.IndexOf(userPick));

            //foreach (string car in cars)
            //{

            //    if (userPick == car)


            //    {
            //        Console.WriteLine("Your choice is at index " + carIndex);
            //        Console.ReadLine();
            //    }
            //    else
            //    {

            //        Console.WriteLine("You did not choose an available car maker."); 

            //   }

            //}


            //Code Challenge 9 

            List<String> cars = new List<string>() { "Ford", "Jeep", "BMW", "Honda", "Audi", "Honda" };
            Console.WriteLine("Who is your favorite car maker?");
            string userPick = Console.ReadLine();
            int indexCounter = 0;

            foreach (string car in cars)
            {
                if (userPick == car)
                {
                    Console.WriteLine("Your choice is at index " + indexCounter);
                }
                else
                {
                    Console.WriteLine("You did not choose an available car maker.");
                }
                indexCounter++;
            }






            // CODE CHALLENGE 11

            //string[] listOfItems = new string [] { "Bill", "Ted", "Ted", "Sam", "Will" };

            //var duplicates = listOfItems
            //    .GroupBy(i => i)
            //    .Where(g => g.Count() > 1)
            //    .Select(g => g.Key);

            //foreach (string list in listOfItems)
            //{
            //    Console.WriteLine(list);
            //}
            //foreach (var d in duplicates)
            //    Console.WriteLine("The following name appears more than once in the list: " + d);
            //    Console.ReadLine();























































            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test scroe: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine("Hey your name is " + names[j]);

            //    }
            //    Console.ReadLine();
            //}


            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int i in testScores)
            //{
            //    if (i > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + i);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "Matthew", "Mark", "Luke", "John" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();


            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99, 100, 93 };  // list with scores
            //List<int> passingScores = new List<int>();                          // blank list that we will add passing scores to if they are over 85

            //foreach (int score in testScores)                                   // iterate through testScores list
            //{
            //    if (score > 85)                                                 // if score above 85
            //    {
            //        passingScores.Add(score);                                   // add to list passingScores
            //    }
            //}

            //Console.WriteLine(passingScores.Count);                             // Count method tells us how many items are in the new list
            //passingScores.ForEach(Console.WriteLine);                           // Method to print to console all items in passingScores list

            //Console.ReadLine();


















        }

    }
}

