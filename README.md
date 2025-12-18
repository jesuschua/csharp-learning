# C# Learning Project

Welcome to your C# learning journey! This project is designed for hobbyists who already know Python and MSSQL.

## What's Included

This project contains practical examples that build on your existing knowledge:

1. **Basic C# Concepts** - Variables, methods, conditionals, loops
2. **Classes and Objects** - Object-oriented programming basics
3. **Collections** - Lists and dictionaries (similar to Python)
4. **Database Connection** - MSSQL connection example

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- (Optional) SQL Server for database examples

## Getting Started

### 1. Verify .NET Installation

```bash
dotnet --version
```

You should see version 8.0 or higher.

### 2. Restore Dependencies

```bash
dotnet restore
```

### 3. Run the Project

```bash
dotnet run
```

## Key Differences from Python

### Type System
- **Python**: Dynamic typing (`x = 5` can become `x = "hello"`)
- **C#**: Static typing (`int x = 5` must stay an integer)

### Syntax
- **Python**: Uses indentation for blocks
- **C#**: Uses curly braces `{}` for blocks

### String Formatting
- **Python**: `f"Hello {name}"` or `"Hello {}".format(name)`
- **C#**: `$"Hello {name}"` (string interpolation)

### Lists vs Arrays
- **Python**: Lists are dynamic (`my_list = [1, 2, 3]`)
- **C#**: Arrays are fixed-size, Lists are dynamic (`List<int> myList = new List<int> {1, 2, 3}`)

## Learning Resources

### Official Documentation
- [Microsoft Learn - C# Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)

### Recommended Learning Path
1. **Basics**: Variables, data types, operators
2. **Control Flow**: If/else, loops, switch
3. **Methods**: Functions and parameters
4. **Classes**: Object-oriented programming
5. **Collections**: Lists, dictionaries, LINQ
6. **Async/Await**: Asynchronous programming
7. **Entity Framework**: ORM for database work (similar to SQLAlchemy in Python)

### Practice Ideas
- Build a console-based todo app
- Create a simple calculator
- Build a file organizer script
- Connect to your MSSQL database and query data
- Create a simple REST API with ASP.NET Core

## Database Connection

To use the database example:

1. Update the connection string in `Program.cs`:
```csharp
string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;Integrated Security=True;";
```

2. Uncomment the database demonstration line in `Main()`:
```csharp
DemonstrateDatabaseConnection();
```

## Next Steps

1. Modify the examples to experiment
2. Try creating your own classes
3. Connect to your MSSQL database
4. Explore LINQ (Language Integrated Query) - it's like Python's list comprehensions but more powerful
5. Learn about async/await for better performance

## Common C# Patterns (vs Python)

| Python | C# |
|--------|-----|
| `def my_function():` | `void MyFunction() { }` |
| `class MyClass:` | `class MyClass { }` |
| `self.name` | `this.Name` or just `Name` |
| `if __name__ == "__main__":` | `static void Main(string[] args)` |
| `import module` | `using Namespace;` |
| `list.append(item)` | `list.Add(item)` |
| `dict['key']` | `dict["key"]` or `dict.TryGetValue("key", out value)` |

Happy coding! 🚀

