using Helpers;

int intInt;
string stringString;
double doubleDouble;

intInt = 10;
stringString = "Szkoła Dotneta";
doubleDouble = 12.5;

Console.WriteLine($"Liczba całkowita: {intInt}");
Console.WriteLine($"Tekst: {stringString}");
Console.WriteLine($"Liczba: {doubleDouble}");

IntHelpers intHelper = new IntHelpers();
StringHelpers stringHelper = new StringHelpers();
DoubleHelpers doubleHelper = new DoubleHelpers();

Console.WriteLine("\n\rPodaj swoje");
intInt = intHelper.GiveMeInt("Podaj liczbę całkowitą: ");
stringString  = stringHelper.GiveMeString("Podaj jakis tekst: ");
doubleDouble = doubleHelper.GiveMeDouble("Podaj liczbę: ");

Console.WriteLine($"Liczba całkowita: {intInt}");
Console.WriteLine($"Tekst: {stringString}");
Console.WriteLine($"Liczba: {doubleDouble}");