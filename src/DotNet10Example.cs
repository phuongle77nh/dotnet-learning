using System;

public class DotNet10
{
    // Demo: Imaginary new feature - structural pattern matching for tuples in switch (C#)
    public string DescribePerson((string name, int age) person)
    {
        // Imaginary syntax for enhanced tuple pattern matching in .NET 10:
        return person switch
        {
            ("Alice", < 18) => $"{person.name} is a minor named Alice.",
            ("Bob", >= 65) => $"{person.name}, age {person.age}, is a senior.",
            ("Charlie", _) => $"{person.name} is Charlie of any age.",
            (_, int age) when age < 18 => $"{person.name} is a minor.",
            (_, int age) when age >= 65 => $"{person.name} is a senior.",
            _ => $"{person.name} is an adult."
        };
    }
}

// Example usage:
pubic class Program
{
    public static void Main()
    {
        var dotnet10 = new DotNet10();
        Console.WriteLine(dotnet10.DescribePerson(("Alice", 15)));
        Console.WriteLine(dotnet10.DescribePerson(("Bob", 70)));
        Console.WriteLine(dotnet10.DescribePerson(("Charlie", 22)));
        Console.WriteLine(dotnet10.DescribePerson(("Dave", 30)));
    }
}