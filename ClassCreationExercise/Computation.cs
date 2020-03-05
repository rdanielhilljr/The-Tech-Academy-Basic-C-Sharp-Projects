using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCreationExercise
{
    public class Computation
    {
        public static int Add(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 + Num2;
            return Answer;
        }
        public static int Subtract(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 - Num2;
            return Answer;
        }
        public static int Multiply(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 * Num2;
            return Answer;
        }

    }
}
