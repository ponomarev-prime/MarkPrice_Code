//

using static System.Console;
using static System.Convert;

byte[] binaryObject = new byte[128];

(new Random()).NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X} ");
}
WriteLine();

string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

byte[] decoded = FromBase64String(encoded);
for (int index = 0; index < decoded.Length; index++)
{
    Write($"{decoded[index]:X} ");
}
