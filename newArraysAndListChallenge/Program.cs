using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Arrays:

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 3;
        //numArray[2] = 200;
        //numArray[3] = 6;
        //numArray[4] = 75;

        //Console.WriteLine(numArray[0]);
        //Console.ReadLine();

        //int[] numArray2 = new int[] { 5, 3, 200, 6, 7 };
        //Console.WriteLine(numArray2[2]);
        //Console.ReadLine();

        //int[] numArray3 = { 5, 3, 200, 6, 7 };
        //Console.WriteLine(numArray3[2]);
        //Console.ReadLine();

        // Lists:

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(5);
        //intList.Add(8);
        //intList.Add(236);
        //intList.Remove(4);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();



        // Challenge 1
        string[] myString = { "Hello", "Danny", "Hill" };
        Console.WriteLine("Please select index 0, 1, or 2 of this string Array to show the value");
        int userSelection = Convert.ToInt32(Console.ReadLine());
        if (userSelection == 0)
        {
            Console.WriteLine(myString[0]);
        }
        else if (userSelection == 1)
        {
            Console.WriteLine(myString[1]);
        }
        else if (userSelection == 2)
        {
            Console.WriteLine(myString[2]);
        }
        else
        {
            Console.WriteLine("You selected an index that doesn't exist."); // Challenge 3
        }
        Console.ReadLine();


        //Challenge 2
        int[] myNum = { 2, 5, 8 };
        Console.WriteLine("Please select an index 0, 1, 2 of this numeric Array to show the value");
        int yourSelection = Convert.ToInt32(Console.ReadLine());
        if (yourSelection == 0)
        {
            Console.WriteLine(myNum[0]);
        }
        else if (yourSelection == 1)
        {
            Console.WriteLine(myNum[1]);
        }
        else if (yourSelection == 2)
        {
            Console.WriteLine(myNum[2]);
        }
        else
        {
            Console.WriteLine("You selected an index that doesn't exist.");  // Challenge 3
        }
        Console.ReadLine();


        // Challenge 4
        List<string> userString = new List<string>();
        userString.Add("Have");
        userString.Add("a");
        userString.Add("great");
        userString.Add("Day");

        Console.WriteLine("Please select index 0, 1, 2, or 3 from this list to see its value.");
        int listSelection = Convert.ToInt32(Console.ReadLine());
        if (listSelection == 0)
        {
            Console.WriteLine(userString[0]);
        }
        else if (listSelection == 1)
        {
            Console.WriteLine(userString[1]);
        }
        else if (listSelection == 2)
        {
            Console.WriteLine(userString[2]);
        }
        else if (listSelection == 3)
        {
            Console.WriteLine(userString[3]);
        }
        else
        {
            Console.WriteLine("You selected an index that doesn't exist.");  // Challenge 3
        }
        Console.ReadLine();




    }


}


