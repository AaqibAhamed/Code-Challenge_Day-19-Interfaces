using System;

namespace Code_Challenge_Day_19_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number : ");

            int n = Int32.Parse(Console.ReadLine());

            AdvancedArithmetic calculation = new DivisorSum();

            int sum = calculation.divisorSum(n);

            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
