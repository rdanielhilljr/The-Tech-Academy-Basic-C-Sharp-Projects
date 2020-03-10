using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCreationExercise
{
    public class Computation
    {
        //public static int Add(int x, int y)
        //{
        //    int Num1 = x;
        //    int Num2 = y;
        //    int Answer = Num1 + Num2;
        //    return Answer;
        //}
        //public static int Subtract(int x, int y)
        //{
        //    int Num1 = x;
        //    int Num2 = y;
        //    int Answer = Num1 - Num2;
        //    return Answer;
        //}
        //public static int Multiply(int x, int y)
        //{
        //    int Num1 = x;
        //    int Num2 = y;
        //    int Answer = Num1 * Num2;
        //    return Answer;
        //}
        public static int Adds(int x, int y = 5)
        {
            int num1 = x;
            int num2 = y;
            int result = num1 + num2;
            return result;
        }



    }
}
