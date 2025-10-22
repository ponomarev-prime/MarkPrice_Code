// See https://aka.ms/new-console-template for more information
using static System.Console;


try
{
    Console.Write("Enter a number between 0 and 255: ");
    byte a = byte.Parse(Console.ReadLine()!);

    Console.Write("Enter another number between 0 and 255: ");
    byte b = byte.Parse(Console.ReadLine()!);

    int result = a / b;
    Console.WriteLine($"{a} divided by {b} is {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero.");
}
catch (FormatException)
{
    Console.WriteLine("Input string was not in a correct format.");
}
catch (OverflowException)
{
    Console.WriteLine("Number must be between 0 and 255.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
