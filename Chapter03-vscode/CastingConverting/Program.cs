//

using static System.Console;
using static System.Convert;

double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double dbl in doubles)
{
    WriteLine($"{dbl} to int 32 is {ToInt32(dbl)}");
}

foreach (double dbl in doubles)
{
    WriteLine(format:
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    arg0: dbl,
    arg1: Math.Round(value: dbl, digits: 0, mode: MidpointRounding.AwayFromZero));
}
