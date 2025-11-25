using System;
using System.Collections.Generic;

public class DotNet10Features
{
    // 1. Imaginary Feature: Enhanced Structural Pattern Matching for Tuples
    public string MatchPerson((string Name, int Age) person)
    {
        return person switch
        {
            ("Alice", < 18) => "Alice is a minor.",
            ("Bob", >= 65) => "Bob is a senior citizen.",
            (_, var age) when age < 18 => $"{person.Name} is underage.",
            (_, var age) when age >= 65 => $"{person.Name} is a senior citizen.",
            _ => $"{person.Name} is an adult."
        };
    }
    // 2. Imaginary Feature: Inline Record Instantiation and Printing
    public void InlineRecordDemo()
    {
        var book = new { Title = "Dotnet 10", Author = "Future Dev", Year = 2025 };
        Console.WriteLine($"Book: {book.Title}, by {book.Author} ({book.Year})");
    }
    // 3. Imaginary Feature: Native Parameter Validation Attribute
    public void PrintNumber([Range(1, 100)] int number)
    {
        // Hypothetical: Method argument 'number' will be validated automatically in .NET 10
        Console.WriteLine($"Valid number: {number}");
    }
    // 4. Imaginary Feature: Asynchronous Streams with LINQ Filtering
    public async IAsyncEnumerable<int> GetEvenNumbersAsync()
    {
        // Hypothetical: .NET 10 supports built-in filtering with LINQ-style syntax in async streams
        for (int i = 1; i <= 10; i++)
        {
            await Task.Delay(10); // Simulate async work
            if (i % 2 == 0) yield return i;
        }
    }
    // 5. Imaginary Feature: Lambda Expressions with Type Inference for Return
    public Func<int, string> DescribeAge = age => // .NET 10 infers return type as string
        age switch
        {
            < 18 => "Minor",
            >= 65 => "Senior",
            _ => "Adult"
        };
    // 6. Imaginary Feature: String Interpolation Enhancements
    public string InterpolatedExpressionDemo(string name, int score)
    {
        // Hypothetical: Embedded expressions and formatting
        return $"Player: {name}, Score: {score}, Grade: {score switch { >90 => \"A\", >80 => \"B\", _ => \"C\" }}";
    }
}

// Example usage:
public class Program
{
    public static async Task Main()
    {
        var features = new DotNet10Features();
        // Feature 1 demo
        Console.WriteLine(features.MatchPerson(("Alice", 16)));
        Console.WriteLine(features.MatchPerson(("Charlie", 70)));
        // Feature 2 demo
        features.InlineRecordDemo();
        // Feature 3 demo (if Range Attribute is supported)
        features.PrintNumber(50);
        // Feature 4 demo
        await foreach (var even in features.GetEvenNumbersAsync())
            Console.WriteLine($"Even number: {even}");
        // Feature 5 demo
        Console.WriteLine(features.DescribeAge(17));
        Console.WriteLine(features.DescribeAge(75));
        // Feature 6 demo
        Console.WriteLine(features.InterpolatedExpressionDemo("Sam", 85));
    }
}