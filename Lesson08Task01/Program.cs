using Helpers;

NumberHelpers numberHelpers = new NumberHelpers();


byte counter = 1;

Console.Write("Liczby pierwsze 2");

for (int i = 3; i <= 100; i++)
{
    if (numberHelpers.PrimeNumber(i))
    {
        counter++;
        Console.Write($", {i}");
    }
}

Console.WriteLine($"\n\rW ciągu 1-100 liczb pierwszych jest jest {counter}");