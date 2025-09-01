using System.Xml;

uint naturalNumber = 23;

int integerNumber = -23;

float realNumber = 2.3F;

double anotherRealNumber = 2.31;

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// print all numbers
Console.WriteLine(naturalNumber);
Console.WriteLine(integerNumber);
Console.WriteLine(realNumber);
Console.WriteLine(anotherRealNumber);

Console.WriteLine($"Decimal: {decimalNotation}, Binary: {binaryNotation}, Hexadecimal: {hexadecimalNotation}");
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue:N0} to {float.MaxValue:N0}");
Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue:N0} to {long.MaxValue:N0}");
Console.WriteLine($"ulong uses {sizeof(ulong)} bytes and can store numbers in the range {ulong.MinValue:N0} to {ulong.MaxValue:N0}");
Console.WriteLine($"short uses {sizeof(short)} bytes and can store numbers in the range {short.MinValue:N0} to {short.MaxValue:N0}");
Console.WriteLine($"ushort uses {sizeof(ushort)} bytes and can store numbers in the range {ushort.MinValue:N0} to {ushort.MaxValue:N0}");
Console.WriteLine($"byte uses {sizeof(byte)} bytes and can store numbers in the range {byte.MinValue:N0} to {byte.MaxValue:N0}");
Console.WriteLine($"sbyte uses {sizeof(sbyte)} bytes and can store numbers in the range {sbyte.MinValue:N0} to {sbyte.MaxValue:N0}");
Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue:N0} to {uint.MaxValue:N0}");
//Console.WriteLine($"object uses {sizeof(object)} bytes and can store numbers in the range {object.MinValue:N0} to {object.MaxValue:N0}");


Console.WriteLine("Using doubles:");

double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"{(a + b) - 0.3 > double.Epsilon}");


Console.WriteLine("Using decimals:");

decimal c = 0.1M;
decimal d = 0.2M;

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}

Console.WriteLine($"c + d = {c + d}");


Console.WriteLine($"double.Epsilon = {double.Epsilon:G17}");
Console.WriteLine($"double.PositiveInfinity = {double.PositiveInfinity}");
Console.WriteLine($"double.NegativeInfinity = {double.NegativeInfinity}");

var population = 66_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

Console.WriteLine($"{population}, {weight}, {price}, {fruit}, {letter}, {happy}");

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something.txt");
StreamWriter file2 = File.CreateText("something2.txt");

XmlDocument xml3 = new();


Person kim = new();
kim.BirthDate = new DateTime(1971, 10, 21);

Console.WriteLine(kim.BirthDate.ToLongDateString());

Console.WriteLine($"default of int: {default(int)}");
Console.WriteLine($"default of double: {default(double)}");
Console.WriteLine($"default of decimal: {default(decimal)}");
Console.WriteLine($"default of DateTime: {default(DateTime)}");
Console.WriteLine($"default of string: {default(string)}");
Console.WriteLine($"default of bool: {default(bool)}");


int number = 13;
Console.WriteLine($"number is {number}");
number = default;
Console.WriteLine($"number is {number}");

class Person
{
    public DateTime BirthDate;
}




