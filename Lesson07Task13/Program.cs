using Helpers;

DoubleHelpers doubleHelpers = new DoubleHelpers();
ByteHelpers byteHelpers = new ByteHelpers();

double first = doubleHelpers.GiveMe("Podaj pierwsza liczbę: ");
double second = doubleHelpers.GiveMe("Podaj drugą liczbę liczbę: ");
byte action;
bool isError = true;

Console.WriteLine("Podaj numer operacji: ");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");

do
{
    action = byteHelpers.GiveMe("Wybór działania:");
    if (action >= 1 && action <= 4)
        isError = false;
    else
        Console.WriteLine("Błąd podaj jeszcze raz.");
}
while (isError);

switch (action)
{
    case 1:
        Console.WriteLine($"Wynik: {first + second}");
        break;
    case 2:
        Console.WriteLine($"Wynik: {first - second}");
        break;
    case 3:
        Console.WriteLine($"Wynik: {first * second}");
        break;
    case 4:
        if (second != 0)
            Console.WriteLine($"Wynik: {first / second}");
        else
            Console.WriteLine("BŁĄD. Dzielenie przez zero");
        break;
}