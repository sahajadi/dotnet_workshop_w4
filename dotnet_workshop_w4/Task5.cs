// Task5.cs
using System;

namespace dotnet_workshop_w4
{
    internal class Task5
    {
        // Enum for day type
        internal enum DayType
        {
            Weekday,
            Weekend
        }

        // Record for Book
        internal record Book(string title, string author, double price);

        // Method to check if day is weekend or weekday
        public static void CheckDay()
        {
            Console.Write("Enter a day (e.g., Sunday): ");
            string inputDay = Console.ReadLine().Trim();

            DayType dayType;

            if (inputDay.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                inputDay.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine("It is: " + dayType);
            Console.WriteLine();
        }

        // Method to demonstrate record usage
        public static void BookDemo()
        {
            // Create a record object
            Book book1 = new Book("C# in Depth", "Jon Skeet", 45.99);

            // Create another object using 'with' to modify title and price
            Book book2 = book1 with { title = "Advanced C#", price = 55.99 };

            // Print the first book
            Console.WriteLine("First Book:");
            Console.WriteLine(book1);
            Console.WriteLine();

            // Deconstruct the second book into variables
            var (title, author, price) = book2;
            Console.WriteLine("Second Book Deconstructed:");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price);
        }
    }
}
