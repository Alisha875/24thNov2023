using System;

namespace Assignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Hello World
            Console.WriteLine("Hello, World!");

            // Task 2: Variables and User Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            // Task 3: Basic Arithmetic
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {(double)num1 / num2}");

            // Task 4: Control Structures
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }

            // Task 5: Loops
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Task 6: Arrays
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = (double)sum / numbers.Length;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            // Task 7: Write a method called "CalculateFactorial" that calculates the factorial of a given positive integer.
            Console.Write("Enter a positive integer: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial: {CalculateFactorial(num3)}");

            // Task 8: Exception Handling
            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter your age: ");
            }
            Console.WriteLine(GetAgeCategory(age));
            Console.ReadKey();
        }

        static int CalculateFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * CalculateFactorial(num - 1);
            }
        }

        static string GetAgeCategory(int age)
        {
            if (age < 18)
            {
                return "You are a minor (under 18).";
            }
            else if (age >= 18 && age <= 65)
            {
                return "You are an adult (between 18 and 65).";
            }
            else
            {
                return "You are a senior (65 and older).";
            }
            
        }
    }
}