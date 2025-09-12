//

using static System.Console;

int a = 10;
double b = a; // Implicit conversion from int to double
WriteLine(b);

double c = 9.8;
int d = (int)c;
WriteLine(d); // Explicit conversion from double to int (fractional part is truncated)
