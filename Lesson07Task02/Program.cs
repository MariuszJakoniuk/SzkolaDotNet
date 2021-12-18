using Helpers;

IntHelpers intHelpers = new IntHelpers();
NumberHelpers numberHelpers = new NumberHelpers();

Console.WriteLine("Sprawdzamy czy liczba jest parzysta, czy nie");
int number = intHelpers.GiveMe("Podaj liczbe całkoiwitą: ");

if (numberHelpers.EvenNumbers(number))
    Console.WriteLine(number + " jest liczbą parzystą");
else
    Console.WriteLine(number + " jest liczbą nieparzystą");