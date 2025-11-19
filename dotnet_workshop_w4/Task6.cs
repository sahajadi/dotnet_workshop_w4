// Task6.cs
using System;

namespace dotnet_workshop_w4
{
    internal class Task6
    {
        public static void CalculatePercentage()
        {
            Console.Write("Enter marks obtained: ");
            string marksInput = Console.ReadLine();

            Console.Write("Enter total marks: ");
            string totalInput = Console.ReadLine();

            // Using TryParse to safely convert input
            bool isMarksValid = int.TryParse(marksInput, out int marks);
            bool isTotalValid = int.TryParse(totalInput, out int total);

            if (!isMarksValid || !isTotalValid || total == 0)
            {
                Console.WriteLine("Invalid input. Please enter valid integers and total > 0.");
                return;
            }

            // --- Breakpoint 1: before calculation ---
            double percentage = (double)marks / total * 100; // ✅ Cast to double fixes integer division
            // --- Breakpoint 2: after calculation ---

            Console.WriteLine("Percentage: " + percentage + "%");
        }
    }
}
