
//// task1
//using System;

//namespace dotnet_workshop_w4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create students using the constructor
//            task1 student1 = new task1("Sahajadi", 21, "Information Technology");
//            task1 student2 = new task1("Aarohi", 20, "Information Technology");

//            // Display their info
//            student1.DisplayInfo();
//            student2.DisplayInfo();

//            Console.ReadLine();
//        }
//    }
//}


//// task2
//using System;

//namespace dotnet_workshop_w4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create Calculator object
//            Calculator calc = new Calculator();

//            // Call PrintWelcome
//            calc.PrintWelcome();
//            Console.WriteLine();

//            // Call Add method
//            int sum = calc.Add(10, 20);
//            Console.WriteLine("Addition of 10 and 20: " + sum);

//            // Call Multiply method with both numbers
//            int product1 = calc.Multiply(5, 4);
//            Console.WriteLine("Multiplication of 5 and 4: " + product1);

//            // Call Multiply method with only one number (num2 defaults to 1)
//            int product2 = calc.Multiply(7);
//            Console.WriteLine("Multiplication of 7 and default 1: " + product2);

//            Console.ReadLine();
//        }
//    }
//}

//// task3
//using System;

//namespace dotnet_workshop_w4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create object of ParameterDemo
//            Task3 demo = new Task3();

//            // --- Using ref ---
//            int myNumber = 15;
//            Console.WriteLine("Before Increase: " + myNumber);
//            demo.Increase(ref myNumber);  // Pass using ref
//            Console.WriteLine("After Increase: " + myNumber);
//            Console.WriteLine();

//            // --- Using out ---
//            demo.GetFullName(out string fullname); // out parameter
//            Console.WriteLine("Full Name: " + fullname);
//            Console.WriteLine();

//            // --- Using params ---
//            int total = demo.SumAll(5, 10, 15, 20); // passing multiple numbers
//            Console.WriteLine("Sum of all numbers: " + total);

//            Console.ReadLine();
//        }
//    }
//}

