// See https://aka.ms/new-console-template for more information

using System;

class MainApp
{
    public static void Main()
    {
        Console.WriteLine("Welcome. What would you like to do?");
        Console.WriteLine("1. Greet Me");
        Console.WriteLine("2. Add Two Numbers");
        string? choice = Console.ReadLine();

        if (choice == "1") 
        {
            string name = Greeter.GetName();
            Greeter.Greet(name);
        } 
        else if (choice == "2") 
        {
            int sum = Adder.GetNumbersAndAdd();
            Console.WriteLine($"The sum is: {sum}");
        } 
        else 
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

class Adder
{
    public static int GetNumbersAndAdd() 
    {
        Console.WriteLine("Enter first number:");
        string? input1 = Console.ReadLine();
        Console.WriteLine("Enter second number:");
        string? input2 = Console.ReadLine();

        int num1 = HandleNullOrInvalidInput(input1);
        int num2 = HandleNullOrInvalidInput(input2);

        return Add(num1, num2);
    }

    public static int HandleNullOrInvalidInput(string? input) 
    {
        if (input == null || !int.TryParse(input, out int result)) 
        {
            return 0;
        }
        return result;
    }
    public static int Add(int a, int b) 
    {
        return a + b;
    }
}

class Greeter
{
    public static string GetName() 
    {
        Console.WriteLine("What is your name?");
        string? input = Console.ReadLine();
        return HandleNullInput(input);
    }
    public static string HandleNullInput(string? input) 
    {
        if (input == null || input.Trim() == "") 
        {
            return "Guest";
        }
        return input;
    }
    public static void Greet(string name) 
    {
        Console.WriteLine($"Hello, {name}!");
    }
}