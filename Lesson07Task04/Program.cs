using Helpers;

IntHelpers intHelpers = new IntHelpers();

Console.WriteLine("Sprawdzamy czy rok jest przetepny");
int year = intHelpers.GiveMe("Podaj rok: ");

if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
    Console.WriteLine(year + " jest rokiem przestępnym");
else
    Console.WriteLine(year + " nie jest rokiem przestępnym");