using Helpers;

int first;
int second;

Console.WriteLine();
Console.WriteLine("Teraz podaj dwie liczby a ja sprawdze czy są takie same");

IntHelpers intHelpers = new IntHelpers();

first = intHelpers.GiveMe("Podaj pierwszą liczbę całkowitą: ");
second = intHelpers.GiveMe("Podaj drugą liczbę całkowitą: ");

if (first == second)
    Console.WriteLine(first + " i " + second + " sa równe");
else
    Console.WriteLine(first + " i " + second + " nie sa równe");