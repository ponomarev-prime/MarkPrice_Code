// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello from the Top Level Program!");
Console.WriteLine(Environment.OSVersion.VersionString);

Console.WriteLine($"Args: {string.Join(", ", args)}");
var all = Environment.GetCommandLineArgs();
Console.WriteLine($"All Args: {string.Join(", ", all)}");

System.Console.WriteLine("Hello, C#! XX");
