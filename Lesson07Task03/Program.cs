using Helpers;

LongHelpers longHelpers = new LongHelpers();

Console.WriteLine("Sprawdzamy liczbę czy jest dodatnią, ujemną, a może zerem");
long number = longHelpers.GiveMe("Podaj liczbe: ");

if (number > 0)
    Console.WriteLine(number + " jest liczbą dodatnią");
else if (number < 0)
    Console.WriteLine(number + " jest liczbą ujemną");
else
    Console.WriteLine(number + " to ZERO");