using System;
using System.Diagnostics.CodeAnalysis;

namespace Calculator
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            Calc calculator = new Calc();
            Console.WriteLine("Enter a your number -> operation -> number");
            double a = GetNum();
            char c = GetOper();
            double b = GetNum();
            while (true)
            {
                a = calculator.Calculate(a,c,b);
                Console.WriteLine("You can continue the calculation. Enter the operation and the number...Answer = \n" + a);
                c = GetOper();
                b = GetNum();
                
            }


        }

        private static char GetOper()
        {
            return char.Parse(Console.ReadLine());
        }

        private static int GetNum()
        {
            return int.Parse(Console.ReadLine());
        }

    }
}
