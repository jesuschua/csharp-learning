using System;

class Primes
{
    public static void Main()
    {
        Console.WriteLine("Give me a number");
        string? input1 = Console.ReadLine();

        if (int.TryParse(input1, out int number))
        {
            Console.WriteLine($"Your number is {input1}.");    
        }
        else
        {
            Console.WriteLine($"Your input {input1} is not an integer.");
        }
        
    }
}


