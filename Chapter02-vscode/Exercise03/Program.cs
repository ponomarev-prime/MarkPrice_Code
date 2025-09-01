//

var typeInfo = new Dictionary<string, (int Bytes, object Min, object Max)>
{
    ["sbyte"]   = (sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue),
    ["byte"]    = (sizeof(byte), byte.MinValue, byte.MaxValue),
    ["short"]   = (sizeof(short), short.MinValue, short.MaxValue),
    ["ushort"]  = (sizeof(ushort), ushort.MinValue, ushort.MaxValue),
    ["int"]     = (sizeof(int), int.MinValue, int.MaxValue),
    ["uint"]    = (sizeof(uint), uint.MinValue, uint.MaxValue),
    ["long"]    = (sizeof(long), long.MinValue, long.MaxValue),
    ["ulong"]   = (sizeof(ulong), ulong.MinValue, ulong.MaxValue),
    ["float"]   = (sizeof(float), float.MinValue, float.MaxValue),
    ["double"]  = (sizeof(double), double.MinValue, double.MaxValue),
    ["decimal"] = (sizeof(decimal), decimal.MinValue, decimal.MaxValue)
};

Console.WriteLine(new string('-', 110));
Console.WriteLine("{0,-10} {1,-15} {2,40} {3,40}", "Type", "Bytes", "Min", "Max");
Console.WriteLine(new string('-', 110));

foreach (var kvp in typeInfo)
{
    string name = kvp.Key;
    int bytes = kvp.Value.Bytes;
    object min = kvp.Value.Min;
    object max = kvp.Value.Max;

    Console.WriteLine("{0,-10} {1,-15} {2,40} {3,40}", name, bytes, min, max);
}

