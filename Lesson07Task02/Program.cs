using Helpers;

IntHelpers intHelpers = new IntHelpers();

Console.WriteLine("Sprawdzamy czy liczba jest parzysta, czy nie");
int number = intHelpers.GiveMe("Podaj liczbe całkoiwitą: ");

if (number % 2 != 0)
    Console.WriteLine(number + " jest liczbą nieparzystą");
else
    Console.WriteLine(number + " jest liczbą parzystą");