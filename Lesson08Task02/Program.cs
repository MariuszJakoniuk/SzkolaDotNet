using Helpers;

NumberHelpers numberHelpers = new NumberHelpers();


int counter = 0;

Console.WriteLine("Liczby parzyste zakres 1-1000:");

for (int i = 0; i <= 1000; i++)
{
    if (numberHelpers.EvenNumbers(i))
    {
        counter++;
        Console.Write($"{i}, ");
    }
}

Console.WriteLine($"\n\rW ciągu parzystych 1-100 jest {counter}");