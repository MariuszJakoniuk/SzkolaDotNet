using Helpers;

int intInt = 10;
string stringString = "Szkoła Dotneta";
double doubleDouble = 12.5;

Console.WriteLine($"Liczba całkowita: {intInt}");
Console.WriteLine($"Tekst: {stringString}");
Console.WriteLine($"Liczba: {doubleDouble}");

IntHelpers intHelper = new IntHelpers();
StringHelpers stringHelper = new StringHelpers();
DoubleHelpers doubleHelper = new DoubleHelpers();

Console.WriteLine("\n\rPodaj swoje");
intInt = intHelper.GiveMe("Podaj liczbę całkowitą: ");
stringString = stringHelper.GiveMe("Podaj jakis tekst: ");
doubleDouble = doubleHelper.GiveMe("Podaj liczbę: ");

Console.WriteLine($"Liczba całkowita: {intInt}");
Console.WriteLine($"Tekst: {stringString}");
Console.WriteLine($"Liczba: {doubleDouble}");