using System;

public class Example
{
    public static void Main(string[] args)
    {
        int myInt = 100; // Using the 'int' alias
        System.Int32 anotherInt = 200; // Using the fully qualified name

        Console.WriteLine($"myInt: {myInt}");
        Console.WriteLine($"anotherInt: {anotherInt}");

        Console.WriteLine($"Minimum Int32 value: {Int32.MinValue}");
        Console.WriteLine($"Maximum Int32 value: {Int32.MaxValue}");
    }
}
