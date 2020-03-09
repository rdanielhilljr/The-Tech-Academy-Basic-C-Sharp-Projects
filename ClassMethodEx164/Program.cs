using System;

namespace ClassMethodEx164
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a whole number:");
            math.Division(Convert.ToInt32(Console.ReadLine()));

            int a = 25;
            int b = 50;
            int sum = 0;
            int prod = 0;
            Computation(a, b, out sum, out prod);

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Product = " + prod);
            Console.ReadLine();

            double c = 25.5;
            double d = 50.5;
            double minus = 0;
            double divis = 0;
            Computation(c, d, out minus, out divis);

            Console.WriteLine("Minus = " + minus);
            Console.WriteLine("Division = " + divis);
            Console.ReadLine();

        }



        public static void Computation(int x, int y, out int sum, out int prod)
        {
                sum = x + y;
                prod = x * y;
        }
        public static void Computation(double x, double y, out double minus, out double divis)
        {
            minus = x - y;
            divis = x / y;
        }








    }
}
