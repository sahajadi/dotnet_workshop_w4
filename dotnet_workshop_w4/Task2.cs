// Calculator.cs
using System;

namespace dotnet_workshop_w4
{
    internal class Task2
    {
        // Void method to print welcome message
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        // Method to add two numbers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method to multiply two numbers, second parameter optional
        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
