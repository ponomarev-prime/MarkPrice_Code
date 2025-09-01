//#error version

using System.Reflection;

System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;

foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name);
}


string[] names;

names = new string[4];

names[0] = "Ahmed";
names[1] = "Sayed";
names[2] = "Ali";
names[3] = "Omar";

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

string[] names2 = new[] { "Kate", "Jack", "Mary", "Bill" };

for (int i = 0; i < names2.Length; i++)
{
    Console.WriteLine(names2[i]);
}
