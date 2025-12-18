using System;
using System.Collections.Generic;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to C# Learning! ===\n");

            // Example 1: Basic C# Concepts
            DemonstrateBasics();

            // Example 2: Working with Classes
            DemonstrateClasses();

            // Example 3: Collections (similar to Python lists/dicts)
            DemonstrateCollections();

            // Example 4: Database Connection (MSSQL)
            // Uncomment the line below when you have a database connection string
            // DemonstrateDatabaseConnection();

            Console.WriteLine("\n=== All examples completed! ===");
        }

        static void DemonstrateBasics()
        {
            Console.WriteLine("--- Example 1: Basic C# Concepts ---");

            // Variables (strongly typed - unlike Python)
            string name = "C# Learner";
            int age = 25;
            double height = 5.9;
            bool isLearning = true;

            // String interpolation (like f-strings in Python)
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}ft, Learning: {isLearning}");

            // Arrays (fixed size)
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"First number: {numbers[0]}");

            // Methods (functions)
            int sum = AddNumbers(10, 20);
            Console.WriteLine($"Sum of 10 + 20 = {sum}");

            // Conditional statements (same as Python, but with parentheses)
            if (age >= 18)
            {
                Console.WriteLine("You're an adult!");
            }

            // Loops
            Console.Write("Counting: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static void DemonstrateClasses()
        {
            Console.WriteLine("--- Example 2: Working with Classes ---");

            // Create an instance of a class (like creating an object in Python)
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);

            // Call methods on the object
            person1.Introduce();
            person2.Introduce();

            // Access properties
            Console.WriteLine($"{person1.Name} is {person1.Age} years old\n");
        }

        static void DemonstrateCollections()
        {
            Console.WriteLine("--- Example 3: Collections (like Python lists/dicts) ---");

            // List<T> - similar to Python list
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            fruits.Add("Date");
            
            Console.WriteLine("Fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  - {fruit}");
            }

            // Dictionary<TKey, TValue> - similar to Python dict
            Dictionary<string, int> scores = new Dictionary<string, int>
            {
                { "Alice", 95 },
                { "Bob", 87 },
                { "Charlie", 92 }
            };

            Console.WriteLine("\nScores:");
            foreach (var kvp in scores)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine();
        }

        static void DemonstrateDatabaseConnection()
        {
            Console.WriteLine("--- Example 4: MSSQL Database Connection ---");
            
            // Connection string - update this with your database details
            string connectionString = "Server=localhost;Database=TestDB;Integrated Security=True;";
            
            try
            {
                using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to database!");
                    
                    // Example query
                    string query = "SELECT @@VERSION AS Version";
                    using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine($"SQL Server Version: {reader["Version"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
                Console.WriteLine("Make sure you have a valid connection string and SQL Server is running.");
            }
            Console.WriteLine();
        }
    }

    // Class definition (similar to Python class)
    class Person
    {
        // Properties (like attributes in Python, but with getters/setters)
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor (like __init__ in Python)
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method (like a function in a Python class)
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }
}

