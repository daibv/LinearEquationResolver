using System;
namespace LinearEquationResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given an equation as 'a * x + b = 0', please enter constants:");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The answer for the equation is as following:");

            if (a != 0)
            {
                double root = -b / a;
                Console.Write("The only one root is:" + root);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("Infinite solutions");
                }
                else
                {
                    Console.Write("No solution!");
                }
            }
            Console.ReadLine();
        }
    }
}