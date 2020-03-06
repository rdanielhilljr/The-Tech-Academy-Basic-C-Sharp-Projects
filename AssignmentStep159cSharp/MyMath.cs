using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;


namespace AssignmentStep159cSharp
{
    class MyMath
    {
        public static int Computation(int x)
        {
            int Num1 = 10;
            int Num2 = x;
            int Answer = Num1 + Num2;
            return Answer;
        }

        public static decimal Computation(decimal x)
        {

            decimal num1 = 10.5m;
            decimal num2 = x;
            decimal num3 = num2 - num1;
            return num3;
        }

        public static string Computation(string x)
        {
            string num1 = "10";
            string num2 = x;
            int answer = Convert.ToInt32(num1) * Convert.ToInt32(num2);
            return Convert.ToString(answer);
        }


    }
}
