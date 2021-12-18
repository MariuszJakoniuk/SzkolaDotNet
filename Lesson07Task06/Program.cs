using Helpers;

IntHelpers IntHelpers = new IntHelpers();

Console.WriteLine("Dopasowanie wzrostu do kategori.");
int height = IntHelpers.GiveMe("Podaj wzrost: ");

switch (height)
{
    case > 220:
        Console.WriteLine("Wielki");
        break;
    case > 200:
        Console.WriteLine("Bardzo wysoki");
        break;
    case > 180:
        Console.WriteLine("Wysoki");
        break; ;
    case > 160:
        Console.WriteLine("Normalny");
        break;
    case > 140:
        Console.WriteLine("Niski");
        break;
    case > 120:
        Console.WriteLine("Bardzo niski");
        break;
    default:
        Console.WriteLine("Za niski");
        break;
}