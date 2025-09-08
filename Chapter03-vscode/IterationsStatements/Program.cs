//
using static System.Console;

string? password;
int i = 0;
bool isCorrect = false;

do
{
    Write("Enter your password:  ");
    password = ReadLine();
    if (password == "Pa$$w0rd")
    {
        WriteLine("Correct!");
        isCorrect = true;
        break;
    }
    i++;
}
while (i < 5);

if (!isCorrect)
{
    WriteLine("You shall not pass!");
}

