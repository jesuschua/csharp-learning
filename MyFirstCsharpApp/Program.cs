// See https://aka.ms/new-console-template for more information

string name = Greeter.GetName();
Greeter.Greet(name);
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