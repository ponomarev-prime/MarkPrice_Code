//
using static System.Console;

WriteLine("***** Fun with Operators *****\n");


int number= (new Random()).Next(1, 7);
WriteLine($"You rolled a {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Four");
        goto case 1;
    case 5:
        WriteLine("Five");
        goto A_Label;

    default:
        WriteLine("Default case hit!");
        break;
}
        A_Label:
        WriteLine("A_Label");
