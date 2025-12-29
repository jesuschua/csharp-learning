// See https://aka.ms/new-console-template for more information

static string HandleNullInput(string? input) 
{
    if (input == null || input.Trim() == "") 
    {
        return "Guest";
    }
    return input;
}

static string Greeting(string name) 
{
    return $"Hello, {name}!";
}

Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
name = HandleNullInput(name);
Console.WriteLine(Greeting(name));
