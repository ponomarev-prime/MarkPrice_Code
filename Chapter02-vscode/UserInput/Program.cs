//
using static System.Console;

// Write("Type your first name and press ENTER:  ");
// string? firstName = ReadLine();

// Write("Type your age and press ENTER:  ");
// string? age = ReadLine();

// Console.WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();

WriteLine();
Console.WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");
