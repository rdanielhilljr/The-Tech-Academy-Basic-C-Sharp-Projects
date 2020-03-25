using System;

namespace StructAssignment
{
    class Program
    {

    struct Number
        {
            public decimal amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number number = new Number();
            
            Console.WriteLine(number.amount = 3.0M);
            Console.ReadLine();
        }
    }
}
