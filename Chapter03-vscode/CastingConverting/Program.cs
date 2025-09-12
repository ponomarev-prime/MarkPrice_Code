//

using static System.Console;

int a = 10;
double b = a; // Implicit conversion from int to double
WriteLine(b);

double c = 9.8;
int d = (int)c;
WriteLine(d); // Explicit conversion from double to int (fractional part is truncated)

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}"); // Explicit conversion from long to int

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
