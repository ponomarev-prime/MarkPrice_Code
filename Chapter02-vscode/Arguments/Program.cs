//
using static System.Console;


if (args.Length < 3)
{
    WriteLine("You must specify two colours and cursor size, e.g.");
    WriteLine("dotnet run red yellow 10");
    return;
}

// Сохраняем старые значения
ConsoleColor oldForeground = ForegroundColor;
ConsoleColor oldBackground = BackgroundColor;
int oldCursorSize = CursorSize;

try
{
    // Применяем новые
    ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
    BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
    CursorSize = int.Parse(args[2]);

    WriteLine("New console settings applied. Press ENTER...");
    ReadLine();
}
finally
{
    // Восстанавливаем исходные
    ForegroundColor = oldForeground;
    BackgroundColor = oldBackground;
    CursorSize = oldCursorSize;

    WriteLine("Console settings restored.");
}

/*
ResetColor();

#error version
*/
