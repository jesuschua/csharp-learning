// See https://aka.ms/new-console-template for more information

using System.Reflection;
Greeter.Main();

class Greeter
{
    public static string Main() 
    {
        string name = GetName();
        Greet(name);
        return name;
    }
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