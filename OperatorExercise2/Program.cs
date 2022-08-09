using System;

namespace OperatorExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;
            var add = a + b;
            var subtract = a - b;
            var multiply = a * b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine($"{a} / {b} is {quotient}");
            Console.WriteLine($"{a} + {b} is {add}");
            Console.WriteLine($"{a} - {b} is {subtract}");
            Console.WriteLine($"{a} * {b} is {multiply}");

            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(Class1.AreaOfCircle(radius));
        }
    }
}
