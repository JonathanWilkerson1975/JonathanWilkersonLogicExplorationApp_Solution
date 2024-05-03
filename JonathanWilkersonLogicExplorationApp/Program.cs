//namespace JonathanWilkersonLogicExplorationApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
using System;

class JonathanWilkersonLogicExplorationApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Jonathan Wilkerson Logic Exploration App!");

        while (true)
        {
            Console.WriteLine("\nChoose a logic operation:");
            Console.WriteLine("1. AND");
            Console.WriteLine("2. OR");
            Console.WriteLine("3. NOT");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    LogicalAND();
                    break;
                case 2:
                    LogicalOR();
                    break;
                case 3:
                    LogicalNOT();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
            }
        }
    }

    static void LogicalAND()
    {
        Console.WriteLine("\nEnter two boolean values (true or false):");
        Console.Write("Enter the first value: ");
        bool value1;
        if (!bool.TryParse(Console.ReadLine(), out value1))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        Console.Write("Enter the second value: ");
        bool value2;
        if (!bool.TryParse(Console.ReadLine(), out value2))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        bool result = value1 && value2;
        Console.WriteLine($"Result of {value1} AND {value2} is: {result}");
    }

    static void LogicalOR()
    {
        Console.WriteLine("\nEnter two boolean values (true or false):");
        Console.Write("Enter the first value: ");
        bool value1;
        if (!bool.TryParse(Console.ReadLine(), out value1))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        Console.Write("Enter the second value: ");
        bool value2;
        if (!bool.TryParse(Console.ReadLine(), out value2))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        bool result = value1 || value2;
        Console.WriteLine($"Result of {value1} OR {value2} is: {result}");
    }

    static void LogicalNOT()
    {
        Console.WriteLine("\nEnter a boolean value (true or false):");
        Console.Write("Enter the value: ");
        bool value;
        if (!bool.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        bool result = !value;
        Console.WriteLine($"Result of NOT {value} is: {result}");
    }
}
