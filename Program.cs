using System;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate void smallerDelegate(double a, double b);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            // Func with Lambda expression
            Func<double, double, double> GetSum = (x, y) => x + y;
            Console.WriteLine($"The Sum Is: {GetSum(10,20)}");

            // Action with anonymous method
            Action<double, double> GetProduct = delegate (double x, double y) { Console.WriteLine($"The Product Is: {x * y}"); };
            GetProduct(10,50);

            // Custom delegate
            smallerDelegate d = new smallerDelegate(answer.GetSmaller);
            d(num1, num2);

            //Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            //Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            //answer.GetSmaller(num1, num2);
        }
    }
}