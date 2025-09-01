

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: numberOfApples * pricePerApple
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: numberOfApples * pricePerApple
);

Console.WriteLine(formatted);

int appleCount = 5;
decimal applePrice = 1.20m;
decimal totalPrice = appleCount * applePrice;
Console.WriteLine("{0} apples cost {1:C}", appleCount, totalPrice);

Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

string appleText = "Apples";
int applesCount = 1234;

string bananaText = "Bananas";
int bananaCount = 56789;

Console.WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count"
);
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: appleText,
    arg1: applesCount
);
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananaText,
    arg1: bananaCount
);
