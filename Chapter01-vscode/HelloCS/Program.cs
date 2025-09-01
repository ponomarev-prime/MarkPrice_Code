using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // int z;
            Console.WriteLine("Hello, C#! 00");
            Console.WriteLine($"Args: {string.Join(", ", args)}");
            var all = Environment.GetCommandLineArgs();
            Console.WriteLine($"All Args: {string.Join(", ", all)}");
        }
    }
}
