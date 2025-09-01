// See https://aka.ms/new-console-template for more information

using static System.Console;

// Задаём путь к папке, где будет работать программа
string path = @"C:\MarkPrice_Code\Chapter03-vscode\comparison_with_the_sample";

// Просим пользователя выбрать режим открытия файла: только чтение или запись
Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey(); // Считываем нажатую клавишу
WriteLine(); // Переход на новую строку

// Объявляем переменную для потока (Stream), который будет связан с файлом
Stream? s;

// В зависимости от выбора пользователя открываем файл либо для чтения, либо для записи
if (key.Key == ConsoleKey.R)
{
    // Открываем файл только для чтения
    s = File.Open(
        Path.Combine(path, "file.txt"), // Полный путь к файлу
        FileMode.Open,                   // Открыть существующий файл
        FileAccess.Read                  // Только чтение
        );
}
else
{
    // Открываем файл для записи (если файла нет — создаём)
    s = File.Open(
        Path.Combine(path, "file.txt"),  // Полный путь к файлу
        FileMode.OpenOrCreate,           // Открыть или создать файл
        FileAccess.Write                 // Только запись
        );
}

// Объявляем строку для сообщения о типе потока
string message;

// Используем оператор switch для определения типа потока и его возможностей
switch (s)
{
    // Если поток — это FileStream и доступна запись
    case FileStream writeable when s.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    // Если поток — это FileStream (но не доступна запись, значит только чтение)
    case FileStream readOnly:
        message = "The stream is a read-only file.";
        break;
    // Если поток — это MemoryStream (работа с памятью, не с файлом)
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    // Если поток другого типа
    default:
        message = "The stream is some other type.";
        break;
    // Если поток равен null (не был открыт)
    case null:
        message = "The stream is null.";
        break;
}

// Выводим сообщение о типе потока
WriteLine(message);
