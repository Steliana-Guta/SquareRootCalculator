using System;

namespace Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            double squareroot;

            Console.WriteLine("Hello, please insert a number so i can calculate the square root for you.");

            number = int.Parse(Console.ReadLine());
            squareroot = Math.Sqrt(number);
            Console.WriteLine("The square root of the number you inserted is " + squareroot);


            Console.ReadLine();


        }
    }
}
