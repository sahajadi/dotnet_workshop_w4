// ParameterDemo.cs
using System;

namespace dotnet_workshop_w4
{
    internal class Task3
    {
        // Method to increase a number by 10 using ref
        public void Increase(ref int number)
        {
            number += 10;
        }

        // Method to assign full name using out
        public void GetFullName(out string fullname)
        {
            fullname = "Sahajadi Lohani"; // Replace with your full name
        }

        // Method to sum any number of integers using params
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
