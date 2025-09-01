// object и полиморфизм

object height = 1.88;
object name = "Amir";
object today = DateTime.Now;

Console.WriteLine($"{name} is {height} meters tall.");
Console.WriteLine($"Date: {today}");

//int length1 = name.Length; // Error
int length2 = ((string)name).Length; // OK.
// Явное приведение ((string)name) сообщает компилятору,
// что фактически внутри хранится строка.
// После кастинга доступны члены string, включая Length.

Console.WriteLine($"{name} has {length2} letters.");

Console.WriteLine(@"///////////////////");

dynamic something = "Ahmed";

something = 12;

something = new[] { 3, 5, 7 };

Console.WriteLine($"Length is {something.Length}"); // OK

Console.WriteLine(@"///////////////////");

object something1 = "Ahmed";

something1 = 12;

something1 = new[] { 3, 5, 7 };

//Console.WriteLine($"Length1 is {((string)something1).Length}"); // OK
